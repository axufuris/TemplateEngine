namespace TemplateEngine
{
    partial class FormCreateProject
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
            this.ComboboxProject = new System.Windows.Forms.ComboBox();
            this.TextboxNamespace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextboxCreateDirectory = new System.Windows.Forms.TextBox();
            this.FolderBrowserNamespace = new System.Windows.Forms.FolderBrowserDialog();
            this.ButtonFolderCreate = new System.Windows.Forms.Button();
            this.FolderBrowserCreate = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ListViewProjects = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboboxProject
            // 
            this.ComboboxProject.FormattingEnabled = true;
            this.ComboboxProject.Items.AddRange(new object[] {
            "Full .NET",
            "Core"});
            this.ComboboxProject.Location = new System.Drawing.Point(141, 43);
            this.ComboboxProject.Name = "ComboboxProject";
            this.ComboboxProject.Size = new System.Drawing.Size(203, 21);
            this.ComboboxProject.TabIndex = 0;
            this.ComboboxProject.SelectedIndexChanged += new System.EventHandler(this.ComboboxProject_SelectedIndexChanged);
            // 
            // TextboxNamespace
            // 
            this.TextboxNamespace.Location = new System.Drawing.Point(141, 242);
            this.TextboxNamespace.Name = "TextboxNamespace";
            this.TextboxNamespace.Size = new System.Drawing.Size(203, 20);
            this.TextboxNamespace.TabIndex = 1;
            this.TextboxNamespace.Text = "Lead";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Namespace";
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(141, 349);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreate.TabIndex = 4;
            this.ButtonCreate.Text = "Create";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Create Directory";
            // 
            // TextboxCreateDirectory
            // 
            this.TextboxCreateDirectory.Location = new System.Drawing.Point(141, 294);
            this.TextboxCreateDirectory.Name = "TextboxCreateDirectory";
            this.TextboxCreateDirectory.Size = new System.Drawing.Size(203, 20);
            this.TextboxCreateDirectory.TabIndex = 2;
            this.TextboxCreateDirectory.Text = "F:\\Tests\\Core";
            // 
            // ButtonFolderCreate
            // 
            this.ButtonFolderCreate.Location = new System.Drawing.Point(368, 294);
            this.ButtonFolderCreate.Name = "ButtonFolderCreate";
            this.ButtonFolderCreate.Size = new System.Drawing.Size(51, 23);
            this.ButtonFolderCreate.TabIndex = 3;
            this.ButtonFolderCreate.Text = "Folder";
            this.ButtonFolderCreate.UseVisualStyleBackColor = true;
            this.ButtonFolderCreate.Click += new System.EventHandler(this.ButtonFolderCreate_Click);
            // 
            // ListViewProjects
            // 
            this.ListViewProjects.CheckBoxes = true;
            this.ListViewProjects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListViewProjects.Location = new System.Drawing.Point(141, 83);
            this.ListViewProjects.Name = "ListViewProjects";
            this.ListViewProjects.Scrollable = false;
            this.ListViewProjects.Size = new System.Drawing.Size(144, 119);
            this.ListViewProjects.TabIndex = 9;
            this.ListViewProjects.UseCompatibleStateImageBehavior = false;
            this.ListViewProjects.View = System.Windows.Forms.View.Details;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormCreateProject
            // 
            this.AcceptButton = this.ButtonCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 553);
            this.Controls.Add(this.ListViewProjects);
            this.Controls.Add(this.ButtonFolderCreate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextboxCreateDirectory);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxNamespace);
            this.Controls.Add(this.ComboboxProject);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormCreateProject";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Project";
            this.Load += new System.EventHandler(this.FormCreateProject_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboboxProject;
        private System.Windows.Forms.TextBox TextboxNamespace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextboxCreateDirectory;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserNamespace;
        private System.Windows.Forms.Button ButtonFolderCreate;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserCreate;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListView ListViewProjects;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

