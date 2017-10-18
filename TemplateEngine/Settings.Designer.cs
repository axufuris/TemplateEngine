namespace TemplateEngine
{
    partial class Settings
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
            this.ButtonFolderCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextboxCreateDirectory = new System.Windows.Forms.TextBox();
            this.FolderBrowserCreate = new System.Windows.Forms.FolderBrowserDialog();
            this.ListViewProjectTypes = new System.Windows.Forms.ListView();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonDeleteItem = new System.Windows.Forms.Button();
            this.ButtonAddItem = new System.Windows.Forms.Button();
            this.ButtonAddKeyword = new System.Windows.Forms.Button();
            this.ButtonDeleteKeyword = new System.Windows.Forms.Button();
            this.ListViewKeywords = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonFolderCreate
            // 
            this.ButtonFolderCreate.Location = new System.Drawing.Point(254, 72);
            this.ButtonFolderCreate.Name = "ButtonFolderCreate";
            this.ButtonFolderCreate.Size = new System.Drawing.Size(51, 23);
            this.ButtonFolderCreate.TabIndex = 8;
            this.ButtonFolderCreate.Text = "Folder";
            this.ButtonFolderCreate.UseVisualStyleBackColor = true;
            this.ButtonFolderCreate.Click += new System.EventHandler(this.ButtonFolderCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Default Directory";
            // 
            // TextboxCreateDirectory
            // 
            this.TextboxCreateDirectory.Location = new System.Drawing.Point(27, 72);
            this.TextboxCreateDirectory.Name = "TextboxCreateDirectory";
            this.TextboxCreateDirectory.Size = new System.Drawing.Size(203, 20);
            this.TextboxCreateDirectory.TabIndex = 7;
            // 
            // ListViewProjectTypes
            // 
            this.ListViewProjectTypes.FullRowSelect = true;
            this.ListViewProjectTypes.Location = new System.Drawing.Point(27, 133);
            this.ListViewProjectTypes.MultiSelect = false;
            this.ListViewProjectTypes.Name = "ListViewProjectTypes";
            this.ListViewProjectTypes.Size = new System.Drawing.Size(941, 256);
            this.ListViewProjectTypes.TabIndex = 10;
            this.ListViewProjectTypes.UseCompatibleStateImageBehavior = false;
            this.ListViewProjectTypes.View = System.Windows.Forms.View.Details;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(330, 72);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 11;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(892, 697);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 12;
            this.ButtonCancel.Text = "Close";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonDeleteItem
            // 
            this.ButtonDeleteItem.Location = new System.Drawing.Point(27, 104);
            this.ButtonDeleteItem.Name = "ButtonDeleteItem";
            this.ButtonDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeleteItem.TabIndex = 13;
            this.ButtonDeleteItem.Text = "Delete Item";
            this.ButtonDeleteItem.UseVisualStyleBackColor = true;
            this.ButtonDeleteItem.Click += new System.EventHandler(this.ButtonDeleteItem_Click);
            // 
            // ButtonAddItem
            // 
            this.ButtonAddItem.Location = new System.Drawing.Point(893, 104);
            this.ButtonAddItem.Name = "ButtonAddItem";
            this.ButtonAddItem.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddItem.TabIndex = 14;
            this.ButtonAddItem.Text = "Add Item";
            this.ButtonAddItem.UseVisualStyleBackColor = true;
            this.ButtonAddItem.Click += new System.EventHandler(this.ButtonAddItem_Click);
            // 
            // ButtonAddKeyword
            // 
            this.ButtonAddKeyword.Location = new System.Drawing.Point(893, 402);
            this.ButtonAddKeyword.Name = "ButtonAddKeyword";
            this.ButtonAddKeyword.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddKeyword.TabIndex = 17;
            this.ButtonAddKeyword.Text = "Add Item";
            this.ButtonAddKeyword.UseVisualStyleBackColor = true;
            this.ButtonAddKeyword.Click += new System.EventHandler(this.ButtonAddKeyword_Click);
            // 
            // ButtonDeleteKeyword
            // 
            this.ButtonDeleteKeyword.Location = new System.Drawing.Point(27, 402);
            this.ButtonDeleteKeyword.Name = "ButtonDeleteKeyword";
            this.ButtonDeleteKeyword.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeleteKeyword.TabIndex = 16;
            this.ButtonDeleteKeyword.Text = "Delete Item";
            this.ButtonDeleteKeyword.UseVisualStyleBackColor = true;
            this.ButtonDeleteKeyword.Click += new System.EventHandler(this.ButtonDeleteKeyword_Click);
            // 
            // ListViewKeywords
            // 
            this.ListViewKeywords.FullRowSelect = true;
            this.ListViewKeywords.Location = new System.Drawing.Point(26, 435);
            this.ListViewKeywords.MultiSelect = false;
            this.ListViewKeywords.Name = "ListViewKeywords";
            this.ListViewKeywords.Size = new System.Drawing.Size(941, 256);
            this.ListViewKeywords.TabIndex = 15;
            this.ListViewKeywords.UseCompatibleStateImageBehavior = false;
            this.ListViewKeywords.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Keywords";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Projects";
            // 
            // Settings
            // 
            this.AcceptButton = this.ButtonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(979, 732);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonAddKeyword);
            this.Controls.Add(this.ButtonDeleteKeyword);
            this.Controls.Add(this.ListViewKeywords);
            this.Controls.Add(this.ButtonAddItem);
            this.Controls.Add(this.ButtonDeleteItem);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ListViewProjectTypes);
            this.Controls.Add(this.ButtonFolderCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextboxCreateDirectory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonFolderCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextboxCreateDirectory;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserCreate;
        private System.Windows.Forms.ListView ListViewProjectTypes;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonDeleteItem;
        private System.Windows.Forms.Button ButtonAddItem;
        private System.Windows.Forms.Button ButtonAddKeyword;
        private System.Windows.Forms.Button ButtonDeleteKeyword;
        private System.Windows.Forms.ListView ListViewKeywords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}