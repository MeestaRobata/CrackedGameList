namespace CrackedGameList {
    partial class QueryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.GetUpdateButton = new System.Windows.Forms.Button();
            this.GameData = new System.Windows.Forms.DataGridView();
            this.GameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WebsiteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateUploaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crohasitColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iGGGamesColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macGamesColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.GameData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetUpdateButton
            // 
            this.GetUpdateButton.Location = new System.Drawing.Point(12, 415);
            this.GetUpdateButton.Name = "GetUpdateButton";
            this.GetUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.GetUpdateButton.TabIndex = 0;
            this.GetUpdateButton.Text = "Get Update";
            this.GetUpdateButton.UseVisualStyleBackColor = true;
            this.GetUpdateButton.Click += new System.EventHandler(this.getUpdate);
            // 
            // GameData
            // 
            this.GameData.AccessibleName = "GameData";
            this.GameData.AllowUserToAddRows = false;
            this.GameData.AllowUserToDeleteRows = false;
            this.GameData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GameData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GameName,
            this.WebsiteName,
            this.DateUploaded});
            this.GameData.Location = new System.Drawing.Point(25, 38);
            this.GameData.Name = "GameData";
            this.GameData.ReadOnly = true;
            this.GameData.Size = new System.Drawing.Size(750, 350);
            this.GameData.TabIndex = 2;
            // 
            // GameName
            // 
            this.GameName.HeaderText = "Name";
            this.GameName.Name = "GameName";
            this.GameName.ReadOnly = true;
            this.GameName.Width = 236;
            // 
            // WebsiteName
            // 
            this.WebsiteName.HeaderText = "Website";
            this.WebsiteName.Name = "WebsiteName";
            this.WebsiteName.ReadOnly = true;
            this.WebsiteName.Width = 236;
            // 
            // DateUploaded
            // 
            this.DateUploaded.HeaderText = "Date";
            this.DateUploaded.Name = "DateUploaded";
            this.DateUploaded.ReadOnly = true;
            this.DateUploaded.Width = 235;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crohasitColorToolStripMenuItem,
            this.iGGGamesColorToolStripMenuItem,
            this.macGamesColorToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // crohasitColorToolStripMenuItem
            // 
            this.crohasitColorToolStripMenuItem.Name = "crohasitColorToolStripMenuItem";
            this.crohasitColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crohasitColorToolStripMenuItem.Text = "Crohasit Color";
            this.crohasitColorToolStripMenuItem.Click += new System.EventHandler(this.changeCroColor);
            // 
            // iGGGamesColorToolStripMenuItem
            // 
            this.iGGGamesColorToolStripMenuItem.Name = "iGGGamesColorToolStripMenuItem";
            this.iGGGamesColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iGGGamesColorToolStripMenuItem.Text = "IGG-Games Color";
            // 
            // macGamesColorToolStripMenuItem
            // 
            this.macGamesColorToolStripMenuItem.Name = "macGamesColorToolStripMenuItem";
            this.macGamesColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.macGamesColorToolStripMenuItem.Text = "Mac-Games Color";
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GameData);
            this.Controls.Add(this.GetUpdateButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "QueryForm";
            this.Text = "Cracked Game Query";
            ((System.ComponentModel.ISupportInitialize)(this.GameData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetUpdateButton;
        private System.Windows.Forms.DataGridView GameData;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WebsiteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateUploaded;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crohasitColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iGGGamesColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macGamesColorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

