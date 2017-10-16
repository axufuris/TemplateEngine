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

namespace TemplateEngine
{
    public partial class SelectProjectType : Form
    {
        public SelectProjectType()
        {
            InitializeComponent();
        }

        private void SelectProjectType_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LinkLabelAddProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var projectType = new AddProjectType();

            Hide();

            if (projectType.ShowDialog() == DialogResult.OK)
            {
                LoadSettings();
            }

            Show();
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ComboBoxProjectType.SelectedItem.ToString()))
            {
                var addProject = new AddItem(ComboBoxProjectType.SelectedItem.ToString());

                Hide();

                addProject.ShowDialog();

                Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void LoadSettings()
        {
            var settings = SettingsManager.GetSettings();

            if (settings != null)
            {
                foreach (var projectType in settings.ProjectTypes.OrderBy(n => n.DisplayName))
                {
                    ComboBoxProjectType.Items.Add(projectType.DisplayName);
                }
            }
        }
    }  // End of Class
}
