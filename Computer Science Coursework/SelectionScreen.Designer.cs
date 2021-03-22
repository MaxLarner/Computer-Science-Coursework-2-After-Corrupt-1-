namespace Computer_Science_Coursework
{
    partial class SelectionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionScreen));
            this.btn_Climb = new System.Windows.Forms.Button();
            this.btn_BuildWall = new System.Windows.Forms.Button();
            this.btn_SavedWalls = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Climb
            // 
            this.btn_Climb.Location = new System.Drawing.Point(382, 201);
            this.btn_Climb.Name = "btn_Climb";
            this.btn_Climb.Size = new System.Drawing.Size(266, 54);
            this.btn_Climb.TabIndex = 0;
            this.btn_Climb.Text = "CLIMB";
            this.btn_Climb.UseVisualStyleBackColor = true;
            // 
            // btn_BuildWall
            // 
            this.btn_BuildWall.Location = new System.Drawing.Point(382, 277);
            this.btn_BuildWall.Name = "btn_BuildWall";
            this.btn_BuildWall.Size = new System.Drawing.Size(266, 54);
            this.btn_BuildWall.TabIndex = 0;
            this.btn_BuildWall.Text = "BUILD WALL";
            this.btn_BuildWall.UseVisualStyleBackColor = true;
            this.btn_BuildWall.Click += new System.EventHandler(this.btn_BuildWall_Click);
            // 
            // btn_SavedWalls
            // 
            this.btn_SavedWalls.Location = new System.Drawing.Point(382, 357);
            this.btn_SavedWalls.Name = "btn_SavedWalls";
            this.btn_SavedWalls.Size = new System.Drawing.Size(266, 54);
            this.btn_SavedWalls.TabIndex = 0;
            this.btn_SavedWalls.Text = "SAVED WALLS";
            this.btn_SavedWalls.UseVisualStyleBackColor = true;
            this.btn_SavedWalls.Click += new System.EventHandler(this.btn_SavedWalls_Click);
            // 
            // SelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_SavedWalls);
            this.Controls.Add(this.btn_BuildWall);
            this.Controls.Add(this.btn_Climb);
            this.Name = "SelectionScreen";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.SelectionScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Climb;
        private System.Windows.Forms.Button btn_BuildWall;
        private System.Windows.Forms.Button btn_SavedWalls;
    }
}
