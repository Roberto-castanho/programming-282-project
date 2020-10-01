namespace PlaneGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlGameSpace = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBase = new System.Windows.Forms.PictureBox();
            this.picPlane = new System.Windows.Forms.PictureBox();
            this.lblArmory = new System.Windows.Forms.Label();
            this.obstacleRange4 = new System.Windows.Forms.Panel();
            this.obstacleRange3 = new System.Windows.Forms.Panel();
            this.obstacleRange2 = new System.Windows.Forms.Panel();
            this.obstacleRange1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pgbFuel = new System.Windows.Forms.ProgressBar();
            this.lblOffice = new System.Windows.Forms.Label();
            this.lblMessHall = new System.Windows.Forms.Label();
            this.lblBarracks = new System.Windows.Forms.Label();
            this.picArmory = new System.Windows.Forms.PictureBox();
            this.picBarracks = new System.Windows.Forms.PictureBox();
            this.picDepot = new System.Windows.Forms.PictureBox();
            this.picStorage = new System.Windows.Forms.PictureBox();
            this.pnlGameSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArmory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGameSpace
            // 
            this.pnlGameSpace.BackColor = System.Drawing.Color.White;
            this.pnlGameSpace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlGameSpace.BackgroundImage")));
            this.pnlGameSpace.Controls.Add(this.picStorage);
            this.pnlGameSpace.Controls.Add(this.picDepot);
            this.pnlGameSpace.Controls.Add(this.picBarracks);
            this.pnlGameSpace.Controls.Add(this.picArmory);
            this.pnlGameSpace.Controls.Add(this.label2);
            this.pnlGameSpace.Controls.Add(this.label1);
            this.pnlGameSpace.Controls.Add(this.pictureBox1);
            this.pnlGameSpace.Controls.Add(this.picBase);
            this.pnlGameSpace.Controls.Add(this.picPlane);
            this.pnlGameSpace.Location = new System.Drawing.Point(0, 0);
            this.pnlGameSpace.Name = "pnlGameSpace";
            this.pnlGameSpace.Size = new System.Drawing.Size(765, 450);
            this.pnlGameSpace.TabIndex = 0;
            this.pnlGameSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGameSpace_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(518, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 58);
            this.label2.TabIndex = 4;
            this.label2.Text = "        ENEMY\r\nHEADQUARTERS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(46, 293);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "BASE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(19, 325);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 106);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // picBase
            // 
            this.picBase.BackColor = System.Drawing.Color.Transparent;
            this.picBase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBase.BackgroundImage")));
            this.picBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBase.Location = new System.Drawing.Point(601, 12);
            this.picBase.Name = "picBase";
            this.picBase.Size = new System.Drawing.Size(152, 102);
            this.picBase.TabIndex = 1;
            this.picBase.TabStop = false;
            this.picBase.Click += new System.EventHandler(this.picBase_Click);
            // 
            // picPlane
            // 
            this.picPlane.BackColor = System.Drawing.Color.Transparent;
            this.picPlane.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlane.BackgroundImage")));
            this.picPlane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlane.Location = new System.Drawing.Point(26, 336);
            this.picPlane.Name = "picPlane";
            this.picPlane.Size = new System.Drawing.Size(70, 82);
            this.picPlane.TabIndex = 0;
            this.picPlane.TabStop = false;
            // 
            // lblArmory
            // 
            this.lblArmory.AutoSize = true;
            this.lblArmory.BackColor = System.Drawing.Color.Transparent;
            this.lblArmory.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblArmory.Location = new System.Drawing.Point(872, 224);
            this.lblArmory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArmory.Name = "lblArmory";
            this.lblArmory.Size = new System.Drawing.Size(35, 13);
            this.lblArmory.TabIndex = 6;
            this.lblArmory.Text = "label4";
            // 
            // obstacleRange4
            // 
            this.obstacleRange4.BackColor = System.Drawing.Color.Transparent;
            this.obstacleRange4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obstacleRange4.BackgroundImage")));
            this.obstacleRange4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.obstacleRange4.ForeColor = System.Drawing.Color.Transparent;
            this.obstacleRange4.Location = new System.Drawing.Point(912, 157);
            this.obstacleRange4.Name = "obstacleRange4";
            this.obstacleRange4.Size = new System.Drawing.Size(80, 80);
            this.obstacleRange4.TabIndex = 4;
            this.obstacleRange4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.obstacleRange4_MouseDown);
            this.obstacleRange4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.obstacleRange4_MouseMove);
            this.obstacleRange4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.obstacleRange4_MouseUp);
            // 
            // obstacleRange3
            // 
            this.obstacleRange3.BackColor = System.Drawing.Color.Transparent;
            this.obstacleRange3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obstacleRange3.BackgroundImage")));
            this.obstacleRange3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.obstacleRange3.ForeColor = System.Drawing.Color.Transparent;
            this.obstacleRange3.Location = new System.Drawing.Point(787, 157);
            this.obstacleRange3.Name = "obstacleRange3";
            this.obstacleRange3.Size = new System.Drawing.Size(80, 80);
            this.obstacleRange3.TabIndex = 4;
            this.obstacleRange3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.obstacleRange3_MouseDown);
            this.obstacleRange3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.obstacleRange3_MouseMove);
            this.obstacleRange3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.obstacleRange3_MouseUp);
            // 
            // obstacleRange2
            // 
            this.obstacleRange2.BackColor = System.Drawing.Color.Transparent;
            this.obstacleRange2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obstacleRange2.BackgroundImage")));
            this.obstacleRange2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.obstacleRange2.ForeColor = System.Drawing.Color.Transparent;
            this.obstacleRange2.Location = new System.Drawing.Point(912, 55);
            this.obstacleRange2.Name = "obstacleRange2";
            this.obstacleRange2.Size = new System.Drawing.Size(80, 80);
            this.obstacleRange2.TabIndex = 4;
            this.obstacleRange2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.obstacleRange2_MouseDown);
            this.obstacleRange2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.obstacleRange2_MouseMove);
            this.obstacleRange2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.obstacleRange2_MouseUp);
            // 
            // obstacleRange1
            // 
            this.obstacleRange1.BackColor = System.Drawing.Color.Transparent;
            this.obstacleRange1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("obstacleRange1.BackgroundImage")));
            this.obstacleRange1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.obstacleRange1.ForeColor = System.Drawing.Color.Transparent;
            this.obstacleRange1.Location = new System.Drawing.Point(787, 55);
            this.obstacleRange1.Name = "obstacleRange1";
            this.obstacleRange1.Size = new System.Drawing.Size(80, 80);
            this.obstacleRange1.TabIndex = 3;
            this.obstacleRange1.Paint += new System.Windows.Forms.PaintEventHandler(this.obstacleRange1_Paint);
            this.obstacleRange1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.obstacleRange1_MouseDown);
            this.obstacleRange1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.obstacleRange1_MouseMove);
            this.obstacleRange1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.obstacleRange1_MouseUp);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(809, 294);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(151, 44);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Begin";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pgbFuel
            // 
            this.pgbFuel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pgbFuel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pgbFuel.Location = new System.Drawing.Point(787, 12);
            this.pgbFuel.Maximum = 580;
            this.pgbFuel.Name = "pgbFuel";
            this.pgbFuel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pgbFuel.RightToLeftLayout = true;
            this.pgbFuel.Size = new System.Drawing.Size(205, 23);
            this.pgbFuel.Step = 1;
            this.pgbFuel.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbFuel.TabIndex = 2;
            this.pgbFuel.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.BackColor = System.Drawing.Color.Transparent;
            this.lblOffice.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblOffice.Location = new System.Drawing.Point(872, 75);
            this.lblOffice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(35, 13);
            this.lblOffice.TabIndex = 3;
            this.lblOffice.Text = "label1";
            // 
            // lblMessHall
            // 
            this.lblMessHall.AutoSize = true;
            this.lblMessHall.BackColor = System.Drawing.Color.Transparent;
            this.lblMessHall.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMessHall.Location = new System.Drawing.Point(977, 45);
            this.lblMessHall.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessHall.Name = "lblMessHall";
            this.lblMessHall.Size = new System.Drawing.Size(35, 13);
            this.lblMessHall.TabIndex = 4;
            this.lblMessHall.Text = "label2";
            // 
            // lblBarracks
            // 
            this.lblBarracks.AutoSize = true;
            this.lblBarracks.BackColor = System.Drawing.Color.Transparent;
            this.lblBarracks.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblBarracks.Location = new System.Drawing.Point(925, 45);
            this.lblBarracks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarracks.Name = "lblBarracks";
            this.lblBarracks.Size = new System.Drawing.Size(35, 13);
            this.lblBarracks.TabIndex = 5;
            this.lblBarracks.Text = "label3";
            // 
            // picArmory
            // 
            this.picArmory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picArmory.BackgroundImage")));
            this.picArmory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picArmory.Location = new System.Drawing.Point(424, 65);
            this.picArmory.Name = "picArmory";
            this.picArmory.Size = new System.Drawing.Size(89, 70);
            this.picArmory.TabIndex = 5;
            this.picArmory.TabStop = false;
            this.picArmory.Visible = false;
            // 
            // picBarracks
            // 
            this.picBarracks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBarracks.BackgroundImage")));
            this.picBarracks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBarracks.Location = new System.Drawing.Point(361, 253);
            this.picBarracks.Name = "picBarracks";
            this.picBarracks.Size = new System.Drawing.Size(91, 70);
            this.picBarracks.TabIndex = 6;
            this.picBarracks.TabStop = false;
            this.picBarracks.Visible = false;
            // 
            // picDepot
            // 
            this.picDepot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDepot.BackgroundImage")));
            this.picDepot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDepot.Location = new System.Drawing.Point(220, 61);
            this.picDepot.Name = "picDepot";
            this.picDepot.Size = new System.Drawing.Size(89, 74);
            this.picDepot.TabIndex = 7;
            this.picDepot.TabStop = false;
            this.picDepot.Visible = false;
            // 
            // picStorage
            // 
            this.picStorage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picStorage.BackgroundImage")));
            this.picStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStorage.Location = new System.Drawing.Point(95, 193);
            this.picStorage.Name = "picStorage";
            this.picStorage.Size = new System.Drawing.Size(90, 60);
            this.picStorage.TabIndex = 8;
            this.picStorage.TabStop = false;
            this.picStorage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.lblArmory);
            this.Controls.Add(this.lblBarracks);
            this.Controls.Add(this.obstacleRange4);
            this.Controls.Add(this.lblMessHall);
            this.Controls.Add(this.obstacleRange3);
            this.Controls.Add(this.lblOffice);
            this.Controls.Add(this.obstacleRange2);
            this.Controls.Add(this.obstacleRange1);
            this.Controls.Add(this.pgbFuel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlGameSpace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlGameSpace.ResumeLayout(false);
            this.pnlGameSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArmory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarracks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDepot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStorage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameSpace;
        private System.Windows.Forms.PictureBox picPlane;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel obstacleRange1;
        private System.Windows.Forms.Panel obstacleRange4;
        private System.Windows.Forms.Panel obstacleRange3;
        private System.Windows.Forms.Panel obstacleRange2;
        private System.Windows.Forms.ProgressBar pgbFuel;
        private System.Windows.Forms.PictureBox picBase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblArmory;
        private System.Windows.Forms.Label lblBarracks;
        private System.Windows.Forms.Label lblMessHall;
        private System.Windows.Forms.Label lblOffice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picStorage;
        private System.Windows.Forms.PictureBox picDepot;
        private System.Windows.Forms.PictureBox picBarracks;
        private System.Windows.Forms.PictureBox picArmory;
    }
}

