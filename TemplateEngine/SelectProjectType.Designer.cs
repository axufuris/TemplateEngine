namespace TemplateEngine
{
    partial class SelectProjectType
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
            this.ComboBoxProjectType = new System.Windows.Forms.ComboBox();
            this.LinkLabelAddProject = new System.Windows.Forms.LinkLabel();
            this.ButtonSelect = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxProjectType
            // 
            this.ComboBoxProjectType.FormattingEnabled = true;
            this.ComboBoxProjectType.Location = new System.Drawing.Point(53, 47);
            this.ComboBoxProjectType.Name = "ComboBoxProjectType";
            this.ComboBoxProjectType.Size = new System.Drawing.Size(194, 21);
            this.ComboBoxProjectType.TabIndex = 0;
            // 
            // LinkLabelAddProject
            // 
            this.LinkLabelAddProject.AutoSize = true;
            this.LinkLabelAddProject.Location = new System.Drawing.Point(253, 55);
            this.LinkLabelAddProject.Name = "LinkLabelAddProject";
            this.LinkLabelAddProject.Size = new System.Drawing.Size(78, 13);
            this.LinkLabelAddProject.TabIndex = 1;
            this.LinkLabelAddProject.TabStop = true;
            this.LinkLabelAddProject.Text = "Add New Type";
            this.LinkLabelAddProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAddProject_LinkClicked);
            // 
            // ButtonSelect
            // 
            this.ButtonSelect.Location = new System.Drawing.Point(53, 96);
            this.ButtonSelect.Name = "ButtonSelect";
            this.ButtonSelect.Size = new System.Drawing.Size(75, 23);
            this.ButtonSelect.TabIndex = 2;
            this.ButtonSelect.Text = "Select";
            this.ButtonSelect.UseVisualStyleBackColor = true;
            this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(172, 96);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // SelectProjectType
            // 
            this.AcceptButton = this.ButtonSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(354, 172);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSelect);
            this.Controls.Add(this.LinkLabelAddProject);
            this.Controls.Add(this.ComboBoxProjectType);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectProjectType";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Project Type";
            this.Load += new System.EventHandler(this.SelectProjectType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxProjectType;
        private System.Windows.Forms.LinkLabel LinkLabelAddProject;
        private System.Windows.Forms.Button ButtonSelect;
        private System.Windows.Forms.Button ButtonCancel;
    }
}