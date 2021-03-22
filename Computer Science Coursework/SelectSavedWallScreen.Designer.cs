namespace Computer_Science_Coursework
{
    partial class SelectSavedWallScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectSavedWallScreen));
            this.lstView_FileSelection = new System.Windows.Forms.ListView();
            this.imgLst_Icon = new System.Windows.Forms.ImageList(this.components);
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_ReturnHome = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstView_FileSelection
            // 
            this.lstView_FileSelection.BackColor = System.Drawing.Color.LavenderBlush;
            this.lstView_FileSelection.HideSelection = false;
            this.lstView_FileSelection.LargeImageList = this.imgLst_Icon;
            this.lstView_FileSelection.Location = new System.Drawing.Point(250, 0);
            this.lstView_FileSelection.Name = "lstView_FileSelection";
            this.lstView_FileSelection.Size = new System.Drawing.Size(520, 600);
            this.lstView_FileSelection.SmallImageList = this.imgLst_Icon;
            this.lstView_FileSelection.TabIndex = 0;
            this.lstView_FileSelection.UseCompatibleStateImageBehavior = false;
            this.lstView_FileSelection.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstView_FileSelection_ItemSelectionChanged);
            // 
            // imgLst_Icon
            // 
            this.imgLst_Icon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgLst_Icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLst_Icon.ImageStream")));
            this.imgLst_Icon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLst_Icon.Images.SetKeyName(0, "WallIcon.PNG");
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(776, 511);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(163, 40);
            this.btn_Select.TabIndex = 1;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_ReturnHome
            // 
            this.btn_ReturnHome.Location = new System.Drawing.Point(14, 10);
            this.btn_ReturnHome.Name = "btn_ReturnHome";
            this.btn_ReturnHome.Size = new System.Drawing.Size(59, 37);
            this.btn_ReturnHome.TabIndex = 2;
            this.btn_ReturnHome.Text = "Home ";
            this.btn_ReturnHome.UseVisualStyleBackColor = true;
            this.btn_ReturnHome.Click += new System.EventHandler(this.btn_ReturnHome_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(880, 10);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(59, 37);
            this.btn_Refresh.TabIndex = 2;
            this.btn_Refresh.Text = "Refresh ";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // SelectSavedWallScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_ReturnHome);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.lstView_FileSelection);
            this.Name = "SelectSavedWallScreen";
            this.Size = new System.Drawing.Size(1000, 600);
            this.Load += new System.EventHandler(this.SelectSavedWallScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstView_FileSelection;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.ImageList imgLst_Icon;
        private System.Windows.Forms.Button btn_ReturnHome;
        private System.Windows.Forms.Button btn_Refresh;
    }
}
