using System;
using System.Windows.Forms;
using TemplateEngine.Managers;

namespace TemplateEngine
{
    public partial class Settings : Form
    {
        private Models.Settings settings = new Models.Settings();

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            settings = SettingsManager.GetSettings();

            if (settings != null)
            {
                ListViewProjectTypes.Columns.Add("Project Type");
                ListViewProjectTypes.Columns.Add("Name");
                ListViewProjectTypes.Columns.Add("Final Name");
                ListViewProjectTypes.Columns.Add("Directory");
                ListViewProjectTypes.Columns.Add("Solution GUID");
                ListViewProjectTypes.Columns.Add("GUID Two");

                TextboxCreateDirectory.Text = settings.DefaultDirectory;

                foreach (var projectType in settings.ProjectTypes)
                {
                    foreach (var project in projectType.Projects)
                    {
                        var item = new ListViewItem(projectType.DisplayName);
                        item.SubItems.Add(project.Name);
                        item.SubItems.Add(project.FinalName);
                        item.SubItems.Add(project.Directory);
                        item.SubItems.Add(project.GUID);
                        item.SubItems.Add(project.GUIDTwo);

                        ListViewProjectTypes.Items.Add(item);
                    }
                }
            }
        }

        private void ButtonFolderCreate_Click(object sender, EventArgs e)
        {
            FolderBrowserCreate.SelectedPath = TextboxCreateDirectory.Text;

            if (FolderBrowserCreate.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(FolderBrowserCreate.SelectedPath))
                {
                    TextboxCreateDirectory.Text = FolderBrowserCreate.SelectedPath;
                }
                else
                {

                }
            }
            else
            {

            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SettingsManager.SaveSettings(settings);

            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            var select = new SelectProjectType();

            Hide();
            select.ShowDialog();
            Show();
        }

        private void ButtonDeleteItem_Click(object sender, EventArgs e)
        {
            var selected = ListViewProjectTypes.SelectedItems[0];

            SettingsManager.DeleteValue(selected);
        }
    }  // End of Class
}
