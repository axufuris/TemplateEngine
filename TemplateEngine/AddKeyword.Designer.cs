namespace TemplateEngine
{
    partial class AddKeyword
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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonAddKeyword = new System.Windows.Forms.Button();
            this.TextboxBefore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxAfter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(174, 191);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonAddKeyword
            // 
            this.ButtonAddKeyword.Location = new System.Drawing.Point(32, 191);
            this.ButtonAddKeyword.Name = "ButtonAddKeyword";
            this.ButtonAddKeyword.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddKeyword.TabIndex = 7;
            this.ButtonAddKeyword.Text = "Create";
            this.ButtonAddKeyword.UseVisualStyleBackColor = true;
            this.ButtonAddKeyword.Click += new System.EventHandler(this.ButtonAddKeyword_Click);
            // 
            // TextboxBefore
            // 
            this.TextboxBefore.Location = new System.Drawing.Point(32, 51);
            this.TextboxBefore.Name = "TextboxBefore";
            this.TextboxBefore.Size = new System.Drawing.Size(217, 20);
            this.TextboxBefore.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Before";
            // 
            // TextboxAfter
            // 
            this.TextboxAfter.Location = new System.Drawing.Point(34, 128);
            this.TextboxAfter.Name = "TextboxAfter";
            this.TextboxAfter.Size = new System.Drawing.Size(217, 20);
            this.TextboxAfter.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "After";
            // 
            // AddKeyword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TextboxAfter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextboxBefore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonAddKeyword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddKeyword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Keyword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonAddKeyword;
        private System.Windows.Forms.TextBox TextboxBefore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextboxAfter;
        private System.Windows.Forms.Label label2;
    }
}