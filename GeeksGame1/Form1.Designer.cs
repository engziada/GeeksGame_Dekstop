using System.ComponentModel;
using System.Windows.Forms;

namespace GeeksGame1
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_ImageBottom = new System.Windows.Forms.Label();
            this.lbl_ImageTop = new System.Windows.Forms.Label();
            this.lbl_ImageRight = new System.Windows.Forms.Label();
            this.lbl_ImageLeft = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bw_FalldownThread = new System.ComponentModel.BackgroundWorker();
            this.bw_DropInABoxThread = new System.ComponentModel.BackgroundWorker();
            this.dz_Korea = new System.Windows.Forms.PictureBox();
            this.dz_China = new System.Windows.Forms.PictureBox();
            this.dz_Japan = new System.Windows.Forms.PictureBox();
            this.dz_Tailand = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dz_Korea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dz_China)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dz_Japan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dz_Tailand)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_ImageBottom);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_ImageTop);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_ImageRight);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_ImageLeft);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Exit);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Play);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.dz_Tailand);
            this.splitContainer1.Panel2.Controls.Add(this.dz_Japan);
            this.splitContainer1.Panel2.Controls.Add(this.dz_China);
            this.splitContainer1.Panel2.Controls.Add(this.dz_Korea);
            this.splitContainer1.Size = new System.Drawing.Size(1282, 711);
            this.splitContainer1.SplitterDistance = 311;
            this.splitContainer1.TabIndex = 1;
            // 
            // lbl_ImageBottom
            // 
            this.lbl_ImageBottom.AutoSize = true;
            this.lbl_ImageBottom.Location = new System.Drawing.Point(93, 350);
            this.lbl_ImageBottom.Name = "lbl_ImageBottom";
            this.lbl_ImageBottom.Size = new System.Drawing.Size(94, 17);
            this.lbl_ImageBottom.TabIndex = 6;
            this.lbl_ImageBottom.Text = "Image Bottom";
            // 
            // lbl_ImageTop
            // 
            this.lbl_ImageTop.AutoSize = true;
            this.lbl_ImageTop.Location = new System.Drawing.Point(93, 289);
            this.lbl_ImageTop.Name = "lbl_ImageTop";
            this.lbl_ImageTop.Size = new System.Drawing.Size(75, 17);
            this.lbl_ImageTop.TabIndex = 5;
            this.lbl_ImageTop.Text = "Image Top";
            // 
            // lbl_ImageRight
            // 
            this.lbl_ImageRight.AutoSize = true;
            this.lbl_ImageRight.Location = new System.Drawing.Point(164, 321);
            this.lbl_ImageRight.Name = "lbl_ImageRight";
            this.lbl_ImageRight.Size = new System.Drawing.Size(83, 17);
            this.lbl_ImageRight.TabIndex = 4;
            this.lbl_ImageRight.Text = "Image Right";
            // 
            // lbl_ImageLeft
            // 
            this.lbl_ImageLeft.AutoSize = true;
            this.lbl_ImageLeft.Location = new System.Drawing.Point(28, 321);
            this.lbl_ImageLeft.Name = "lbl_ImageLeft";
            this.lbl_ImageLeft.Size = new System.Drawing.Size(74, 17);
            this.lbl_ImageLeft.TabIndex = 3;
            this.lbl_ImageLeft.Text = "Image Left";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Exit.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Navy;
            this.btn_Exit.ImageIndex = 4;
            this.btn_Exit.ImageList = this.imageList2;
            this.btn_Exit.Location = new System.Drawing.Point(10, 190);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(289, 76);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "1rightarrow.png");
            this.imageList2.Images.SetKeyName(1, "exit.png");
            this.imageList2.Images.SetKeyName(2, "forward.png");
            this.imageList2.Images.SetKeyName(3, "joystick.png");
            this.imageList2.Images.SetKeyName(4, "shutdown.png");
            this.imageList2.Images.SetKeyName(5, "stop_64.png");
            // 
            // btn_Play
            // 
            this.btn_Play.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Play.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.ForeColor = System.Drawing.Color.Navy;
            this.btn_Play.ImageIndex = 3;
            this.btn_Play.ImageList = this.imageList2;
            this.btn_Play.Location = new System.Drawing.Point(10, 114);
            this.btn_Play.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(289, 76);
            this.btn_Play.TabIndex = 1;
            this.btn_Play.Tag = "Start";
            this.btn_Play.Text = "Play";
            this.btn_Play.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 104);
            this.label1.TabIndex = 0;
            this.label1.Text = "Geeks\' Game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bw_FalldownThread
            // 
            this.bw_FalldownThread.WorkerSupportsCancellation = true;
            this.bw_FalldownThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.bw_FalldownThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // dz_Korea
            // 
            this.dz_Korea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dz_Korea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dz_Korea.Image = global::GeeksGame1.Properties.Resources.KoreanBox;
            this.dz_Korea.Location = new System.Drawing.Point(645, -1);
            this.dz_Korea.Name = "dz_Korea";
            this.dz_Korea.Size = new System.Drawing.Size(321, 251);
            this.dz_Korea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dz_Korea.TabIndex = 4;
            this.dz_Korea.TabStop = false;
            this.dz_Korea.Tag = "Korean";
            // 
            // dz_China
            // 
            this.dz_China.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dz_China.Image = global::GeeksGame1.Properties.Resources.ChineeseBox;
            this.dz_China.Location = new System.Drawing.Point(1, -1);
            this.dz_China.Name = "dz_China";
            this.dz_China.Size = new System.Drawing.Size(321, 251);
            this.dz_China.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dz_China.TabIndex = 5;
            this.dz_China.TabStop = false;
            this.dz_China.Tag = "Chineese";
            // 
            // dz_Japan
            // 
            this.dz_Japan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dz_Japan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dz_Japan.Image = global::GeeksGame1.Properties.Resources.JapaneseBox;
            this.dz_Japan.Location = new System.Drawing.Point(645, 459);
            this.dz_Japan.Name = "dz_Japan";
            this.dz_Japan.Size = new System.Drawing.Size(321, 251);
            this.dz_Japan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dz_Japan.TabIndex = 6;
            this.dz_Japan.TabStop = false;
            this.dz_Japan.Tag = "Japanese";
            this.dz_Japan.Click += new System.EventHandler(this.dz_Japan_Click);
            // 
            // dz_Tailand
            // 
            this.dz_Tailand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dz_Tailand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dz_Tailand.Image = global::GeeksGame1.Properties.Resources.ThaiBox;
            this.dz_Tailand.Location = new System.Drawing.Point(1, 459);
            this.dz_Tailand.Name = "dz_Tailand";
            this.dz_Tailand.Size = new System.Drawing.Size(321, 251);
            this.dz_Tailand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dz_Tailand.TabIndex = 7;
            this.dz_Tailand.TabStop = false;
            this.dz_Tailand.Tag = "Thai";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(113, 641);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 58);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Score: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Points";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 711);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Geeks\' Game";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dz_Korea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dz_China)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dz_Japan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dz_Tailand)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Button btn_Play;
        private Button btn_Exit;
        private ImageList imageList2;
        private BackgroundWorker bw_FalldownThread;
        private BackgroundWorker bw_DropInABoxThread;
        private Label lbl_ImageLeft;
        private Label lbl_ImageBottom;
        private Label lbl_ImageTop;
        private Label lbl_ImageRight;
        private PictureBox dz_Tailand;
        private PictureBox dz_Japan;
        private PictureBox dz_China;
        private PictureBox dz_Korea;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
    }
}

