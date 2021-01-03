namespace Computer_Science_Coursework
{
    partial class BuildWallScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildWallScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctBox_PurpleHoldButton = new System.Windows.Forms.PictureBox();
            this.pctBox_GreenHoldButton = new System.Windows.Forms.PictureBox();
            this.pctBox_BlueHoldButton = new System.Windows.Forms.PictureBox();
            this.pctBox_RedHoldButton = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_WallWidth = new System.Windows.Forms.TextBox();
            this.txt_WallHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_DimensionsSlideButton = new System.Windows.Forms.Button();
            this.pnl_SlideOutWallBuild = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PurpleHoldButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_GreenHoldButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_BlueHoldButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_RedHoldButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pctBox_PurpleHoldButton);
            this.panel1.Controls.Add(this.pctBox_GreenHoldButton);
            this.panel1.Controls.Add(this.pctBox_BlueHoldButton);
            this.panel1.Controls.Add(this.pctBox_RedHoldButton);
            this.panel1.Location = new System.Drawing.Point(238, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 160);
            this.panel1.TabIndex = 2;
            // 
            // pctBox_PurpleHoldButton
            // 
            this.pctBox_PurpleHoldButton.BackColor = System.Drawing.Color.Purple;
            this.pctBox_PurpleHoldButton.Location = new System.Drawing.Point(34, 26);
            this.pctBox_PurpleHoldButton.Name = "pctBox_PurpleHoldButton";
            this.pctBox_PurpleHoldButton.Size = new System.Drawing.Size(138, 119);
            this.pctBox_PurpleHoldButton.TabIndex = 4;
            this.pctBox_PurpleHoldButton.TabStop = false;
            this.pctBox_PurpleHoldButton.Click += new System.EventHandler(this.pctBox_PurpleHoldButton_Click);
            // 
            // pctBox_GreenHoldButton
            // 
            this.pctBox_GreenHoldButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pctBox_GreenHoldButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBox_GreenHoldButton.BackgroundImage")));
            this.pctBox_GreenHoldButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBox_GreenHoldButton.Location = new System.Drawing.Point(524, 26);
            this.pctBox_GreenHoldButton.Name = "pctBox_GreenHoldButton";
            this.pctBox_GreenHoldButton.Size = new System.Drawing.Size(125, 119);
            this.pctBox_GreenHoldButton.TabIndex = 2;
            this.pctBox_GreenHoldButton.TabStop = false;
            this.pctBox_GreenHoldButton.Click += new System.EventHandler(this.pctBox_GreenHoldButton_Click);
            // 
            // pctBox_BlueHoldButton
            // 
            this.pctBox_BlueHoldButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pctBox_BlueHoldButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBox_BlueHoldButton.BackgroundImage")));
            this.pctBox_BlueHoldButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBox_BlueHoldButton.Location = new System.Drawing.Point(365, 26);
            this.pctBox_BlueHoldButton.Name = "pctBox_BlueHoldButton";
            this.pctBox_BlueHoldButton.Size = new System.Drawing.Size(133, 119);
            this.pctBox_BlueHoldButton.TabIndex = 1;
            this.pctBox_BlueHoldButton.TabStop = false;
            this.pctBox_BlueHoldButton.Click += new System.EventHandler(this.pctBox_BlueHoldButton_Click);
            // 
            // pctBox_RedHoldButton
            // 
            this.pctBox_RedHoldButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pctBox_RedHoldButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctBox_RedHoldButton.BackgroundImage")));
            this.pctBox_RedHoldButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBox_RedHoldButton.Location = new System.Drawing.Point(196, 26);
            this.pctBox_RedHoldButton.Name = "pctBox_RedHoldButton";
            this.pctBox_RedHoldButton.Size = new System.Drawing.Size(141, 119);
            this.pctBox_RedHoldButton.TabIndex = 0;
            this.pctBox_RedHoldButton.TabStop = false;
            this.pctBox_RedHoldButton.Click += new System.EventHandler(this.pctBox_RedHoldButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_WallSubmit_Click);
            // 
            // txt_WallWidth
            // 
            this.txt_WallWidth.Location = new System.Drawing.Point(731, 158);
            this.txt_WallWidth.Name = "txt_WallWidth";
            this.txt_WallWidth.Size = new System.Drawing.Size(89, 23);
            this.txt_WallWidth.TabIndex = 1;
            // 
            // txt_WallHeight
            // 
            this.txt_WallHeight.Location = new System.Drawing.Point(731, 130);
            this.txt_WallHeight.Name = "txt_WallHeight";
            this.txt_WallHeight.Size = new System.Drawing.Size(89, 23);
            this.txt_WallHeight.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            // 
            // btn_DimensionsSlideButton
            // 
            this.btn_DimensionsSlideButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DimensionsSlideButton.BackgroundImage")));
            this.btn_DimensionsSlideButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DimensionsSlideButton.Location = new System.Drawing.Point(238, 92);
            this.btn_DimensionsSlideButton.Name = "btn_DimensionsSlideButton";
            this.btn_DimensionsSlideButton.Size = new System.Drawing.Size(85, 84);
            this.btn_DimensionsSlideButton.TabIndex = 0;
            this.btn_DimensionsSlideButton.UseVisualStyleBackColor = true;
            this.btn_DimensionsSlideButton.Click += new System.EventHandler(this.btn_DimensionsSlideButton_Click);
            // 
            // pnl_SlideOutWallBuild
            // 
            this.pnl_SlideOutWallBuild.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnl_SlideOutWallBuild.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_SlideOutWallBuild.Location = new System.Drawing.Point(0, 0);
            this.pnl_SlideOutWallBuild.Name = "pnl_SlideOutWallBuild";
            this.pnl_SlideOutWallBuild.Size = new System.Drawing.Size(105, 600);
            this.pnl_SlideOutWallBuild.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BuildWallScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.btn_DimensionsSlideButton);
            this.Controls.Add(this.pnl_SlideOutWallBuild);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_WallHeight);
            this.Controls.Add(this.txt_WallWidth);
            this.Controls.Add(this.panel1);
            this.Name = "BuildWallScreen";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.BuildWallScreen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PurpleHoldButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_GreenHoldButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_BlueHoldButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_RedHoldButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctBox_PurpleHoldButton;
        private System.Windows.Forms.PictureBox pctBox_GreenHoldButton;
        private System.Windows.Forms.PictureBox pctBox_BlueHoldButton;
        private System.Windows.Forms.PictureBox pctBox_RedHoldButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_WallWidth;
        private System.Windows.Forms.TextBox txt_WallHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_DimensionsSlideButton;
        private System.Windows.Forms.Panel pnl_SlideOutWallBuild;
        private System.Windows.Forms.Timer timer1;
    }
}
