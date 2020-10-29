using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeeksGame1
{
    public partial class frm_Main : Form
    {
        Control activeControl;
        Point prevPosition;
        Task falldownTask;
        Task gotoBoxTask;
        public frm_Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void MyControl_MouseDown(object sender, MouseEventArgs e)
        {
            activeControl = sender as Control;
            prevPosition = e.Location;
            Cursor = Cursors.Hand;
        }

        private void MyControl_MouseUp(object sender, MouseEventArgs e)
        {
            ////Get center line
            //int centerVertLine=(activeControl.Parent.Width - activeControl.Width) / 2;
            //int centerHorzLine=(activeControl.Parent.Height - activeControl.Height) / 2;

            ////go left
            //if (activeControl.Left <= centerVertLine - 20) 
            //{
            //    //go up
            //    if (activeControl.Top <=  centerHorzLine-20)
            //    {
            //        slideToDestination(activeControl, dz_Japan, 100, start);

            //        //if (!bw_DropInABoxThread.IsBusy)
            //        //    bw_DropInABoxThread.RunWorkerAsync("UpperLeft");
            //    }
            //}
            //else
            //{
            //    if (activeControl.Top < ClientSize.Height - activeControl.Top)
            //    {
            //        //Go to upper right corner
            //    }
            //}

            ////activeControl = null;
            ////Cursor = Cursors.Default;


        }

        private void MyControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (activeControl == null || activeControl != sender ) return;

            var location = activeControl.Location;
            location.Offset(e.Location.X - prevPosition.X, e.Location.Y - prevPosition.Y);
            activeControl.Location = location;

            if (e.X == dz_Japan.Right)
                MessageBox.Show("Reached");

#if DEBUG
            lbl_ImageBottom.Text = activeControl.Bottom.ToString();
            lbl_ImageLeft.Text = activeControl.Left.ToString();
            lbl_ImageRight.Text = activeControl.Right.ToString();
            lbl_ImageTop.Text = activeControl.Top.ToString();
#endif
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            
            //Start a game
            if(btn_Play?.Tag?.ToString()=="Start")
            {
                //dropNewFaceImage();
                btn_Play.Tag = "Stop";
                btn_Play.Text = "Stop";
                btn_Play.ImageIndex = 5;
                start();

            }
            //Stop the game
            else if (btn_Play?.Tag?.ToString()=="Stop")
            {

                btn_Play.Tag = "Start";
                btn_Play.Text = "Play";
                btn_Play.ImageIndex = 3;
                splitContainer1.Panel2.Controls.Clear();
                stop();
            }
            //btn_Play.Tag = btn_Play?.Tag?.ToString() == "Stop" ? "Start" : "Stop";


        }

        private string getRandomImagePath(out string Nationality)
        {
            try
            {
                string imagesDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty, "Images");
                string[] nationalityDirectories = Directory.GetDirectories(imagesDirectory);
                Random rnd = new Random();
                int nationalityIndex = rnd.Next(0, 3);
                string selectedNationalityDirectory = nationalityDirectories[nationalityIndex];
                string[] faceFiles = Directory.GetFiles(selectedNationalityDirectory);
                int faceIndex = rnd.Next(0, faceFiles.Length - 1);
                string selectedFaceImagePath = faceFiles[faceIndex];
                Nationality = Path.GetDirectoryName(selectedNationalityDirectory);
                return selectedFaceImagePath;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, @"Error getting face image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Nationality = "";
                return "";
            }
            
        }

        private void start()
        {
            if (bw_FalldownThread.IsBusy != true)
                bw_FalldownThread.RunWorkerAsync();
        }

        private void stop()
        {
            if (bw_FalldownThread.WorkerSupportsCancellation)
                bw_FalldownThread.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (worker?.CancellationPending == true || btn_Play?.Tag?.ToString() == "Start")
                e.Cancel = true;
            else
                dropNewFaceImage();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
               // resultLabel.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                start();
            }

        }

        private void dropNewFaceImage()
        {
            var myControl = new PictureBox
            {
                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                Image = Image.FromFile(getRandomImagePath(out string nationalityTag)),
                Size = new Size(137, 142),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent,
                Top = 3,
                Visible = false,
                Tag = nationalityTag,
                Cursor=Cursors.Hand
            };


            myControl.MouseDown += MyControl_MouseDown;
            myControl.MouseMove += MyControl_MouseMove;
            myControl.MouseUp += MyControl_MouseUp;

            Invoke((Action) delegate
            {
                splitContainer1.Panel2.Controls.Add(myControl);
                myControl.Left = (myControl.Parent.Width - myControl.Width) / 2;
                myControl.Visible = true;
            });
            myControl.BringToFront();

            //Start moving
            var steps = myControl.Parent.ClientSize.Height - myControl.Top;
            var sleepInterval = 3000 / steps;

            while (myControl?.Top < myControl?.Parent?.ClientSize.Height)
            {
                if (bw_DropInABoxThread.IsBusy) break;
                myControl.Top++;
                Thread.Sleep(sleepInterval);
            }

            //dropNewFaceImage();
        }

        private void dz_Japan_Click(object sender, EventArgs e)
        {

        }


        //private void dropInABox(string direction)
        //{
        //    //Start moving
        //    //var steps = activeControl.Parent.ClientSize.Height - activeControl.Top;
        //    //var sleepInterval = 1500 / steps;

        //    switch (direction)
        //    {
        //        case "UpperLeft":

        //            while (activeControl?.Top > activeControl?.Parent?.ClientRectangle.Top)
        //            {
        //                activeControl.Top--;
        //                while (activeControl?.Left > activeControl?.Parent?.ClientRectangle.Left)
        //                    activeControl.Left--;
        //                Thread.Sleep(100);
        //                activeControl.Width--;
        //                activeControl.Height--;
        //            }

        //            break;
        //    }

        //}

        //private void bw_DropInABoxThread_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    //string direction = e.Argument.ToString();
        //    //dropInABox(direction);

        //}

        //private void bw_DropInABoxThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    start();
        //}


        //private void slideToDestination(Control destination, Control control, int delay, Action onFinish)
        //{
        //    new Task(() =>
        //    {
        //         int directionX = destination.Left > control.Left ? 1 : -1;
        //        int directionY = destination.Bottom > control.Top ? 1 : -1;

        //        while (control.Left != destination.Left || control.Top != destination.Bottom)
        //        {
        //            try
        //            {
        //                if (control.Left != destination.Left)
        //                {
        //                    this.Invoke((Action)delegate ()
        //                    {
        //                        control.Left += directionX;
        //                    });
        //                }
        //                if (control.Top != destination.Bottom)
        //                {
        //                    this.Invoke((Action)delegate ()
        //                    {
        //                        control.Top += directionY;
        //                    });
        //                }
        //                Thread.Sleep(delay);
        //            }
        //            catch
        //            {
        //            break;
        //            }
        //        }

        //        onFinish?.Invoke();

        //    }).Start();
        //}

    }
}
