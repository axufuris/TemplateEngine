using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateEngine.Managers;
using TemplateEngine.Models;

namespace TemplateEngine
{
    public partial class AddItem : Form
    {
        private string projectTypeString = string.Empty;

        public AddItem(string projectType)
        {
            InitializeComponent();

            projectTypeString = projectType;
        }

        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextboxName.Text) && !string.IsNullOrEmpty(TextboxFinalName.Text)
                && !string.IsNullOrEmpty(TextboxDirectory.Text))
            {
                var project = new Project()
                {
                    Directory = TextboxDirectory.Text,
                    FinalName = TextboxFinalName.Text,
                    Name = TextboxName.Text,
                    GUID = Guid.NewGuid().ToString(),
                    GUIDTwo = Guid.NewGuid().ToString(),
                    FolderName = TextboxFolderName.Text
                };

                SettingsManager.AddProject(projectTypeString, project);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }  // End of Class
}
