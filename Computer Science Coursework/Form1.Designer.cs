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
            this.pnl_Screen = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_Screen
            // 
            this.pnl_Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Screen.Location = new System.Drawing.Point(0, 0);
            this.pnl_Screen.Name = "pnl_Screen";
            this.pnl_Screen.Size = new System.Drawing.Size(984, 561);
            this.pnl_Screen.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnl_Screen);
            this.Name = "Form1";
            this.Text = "Wall Build";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Screen;
    }
}

