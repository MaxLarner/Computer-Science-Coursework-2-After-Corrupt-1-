namespace Computer_Science_Coursework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_WallSubmit = new System.Windows.Forms.Button();
            this.txt_WallWidth = new System.Windows.Forms.TextBox();
            this.txt_WallHeight = new System.Windows.Forms.TextBox();
            this.pnl_Holds = new System.Windows.Forms.Panel();
            this.pctBox_PurpleHoldButton = new System.Windows.Forms.PictureBox();
            this.pctBox_GreenHoldButton = new System.Windows.Forms.PictureBox();
            this.pctBox_BlueHoldButton = new System.Windows.Forms.PictureBox();
            this.pctBox_RedHoldButton = new System.Windows.Forms.PictureBox();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.pnl_Holds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PurpleHoldButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_GreenHoldButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_BlueHoldButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_RedHoldButton)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_WallSubmit
            // 
            this.btn_WallSubmit.Location = new System.Drawing.Point(98, 218);
            this.btn_WallSubmit.Name = "btn_WallSubmit";
            this.btn_WallSubmit.Size = new System.Drawing.Size(89, 31);
            this.btn_WallSubmit.TabIndex = 0;
            this.btn_WallSubmit.Text = "Submit ";
            this.btn_WallSubmit.UseVisualStyleBackColor = true;
            this.btn_WallSubmit.Click += new System.EventHandler(this.btn_WallSubmit_Click);
            // 
            // txt_WallWidth
            // 
            this.txt_WallWidth.Location = new System.Drawing.Point(98, 157);
            this.txt_WallWidth.Name = "txt_WallWidth";
            this.txt_WallWidth.Size = new System.Drawing.Size(89, 23);
            this.txt_WallWidth.TabIndex = 1;
            // 
            // txt_WallHeight
            // 
            this.txt_WallHeight.Location = new System.Drawing.Point(98, 186);
            this.txt_WallHeight.Name = "txt_WallHeight";
            this.txt_WallHeight.Size = new System.Drawing.Size(89, 23);
            this.txt_WallHeight.TabIndex = 1;
            // 
            // pnl_Holds
            // 
            this.pnl_Holds.Controls.Add(this.pctBox_PurpleHoldButton);
            this.pnl_Holds.Controls.Add(this.pctBox_GreenHoldButton);
            this.pnl_Holds.Controls.Add(this.pctBox_BlueHoldButton);
            this.pnl_Holds.Controls.Add(this.pctBox_RedHoldButton);
            this.pnl_Holds.Location = new System.Drawing.Point(289, 560);
            this.pnl_Holds.Name = "pnl_Holds";
            this.pnl_Holds.Size = new System.Drawing.Size(671, 160);
            this.pnl_Holds.TabIndex = 2;
            // 
            // pctBox_PurpleHoldButton
            // 
            this.pctBox_PurpleHoldButton.BackColor = System.Drawing.Color.Purple;
            this.pctBox_PurpleHoldButton.Location = new System.Drawing.Point(33, 26);
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
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Location = new System.Drawing.Point(54, 157);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(43, 15);
            this.lbl_Height.TabIndex = 3;
            this.lbl_Height.Text = "Height";
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Location = new System.Drawing.Point(54, 189);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(39, 15);
            this.lbl_Width.TabIndex = 3;
            this.lbl_Width.Text = "Width";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.lbl_Width);
            this.Controls.Add(this.lbl_Height);
            this.Controls.Add(this.pnl_Holds);
            this.Controls.Add(this.txt_WallHeight);
            this.Controls.Add(this.txt_WallWidth);
            this.Controls.Add(this.btn_WallSubmit);
            this.Name = "Form1";
            this.Text = "Wall Build";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_Holds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_PurpleHoldButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_GreenHoldButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_BlueHoldButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox_RedHoldButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_WallSubmit;
        private System.Windows.Forms.TextBox txt_WallWidth;
        private System.Windows.Forms.TextBox txt_WallHeight;
        private System.Windows.Forms.Panel pnl_Holds;
        private System.Windows.Forms.PictureBox pctBox_BlueHoldButton;
        private System.Windows.Forms.PictureBox pctBox_GreenHoldButton;
        private System.Windows.Forms.PictureBox pctBox_RedHoldButton;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.PictureBox pctBox_PurpleHoldButton;
    }
}

