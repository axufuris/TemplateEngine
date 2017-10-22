using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using TemplateEngine.Managers;
using TemplateEngine.Models;

namespace TemplateEngine
{
    public partial class FormCreateProject : Form
    {
        private string solutionGUID;
        private string solutionProjectGUID;
        private List<KeyValuePair<string, string>> newNames;

        private string FromSolutionDirectory
        {
            get
            {
                return Environment.CurrentDirectory + "\\src\\Solution";
            }
        }
        private string SolutionDirectory
        {
            get
            {
                return TextboxCreateDirectory.Text + "\\" + TextboxNamespace.Text;
            }
        }
        private string SolutionFile
        {
            get
            {
                return SolutionDirectory + "\\" + TextboxNamespace.Text + ".sln";
            }
        }
        private string SolutionGUID
        {
            get
            {
                return solutionGUID;
            }
            set
            {
                solutionGUID = value;
            }
        }
        private string SolutionProjectGUID
        {
            get
            {
                return "{" + solutionProjectGUID + "}";
            }
            set
            {
                solutionProjectGUID = value;
            }
        }
        private List<Project> projects { get; set; }

        public FormCreateProject()
        {
            InitializeComponent();
        }

        private void FormCreateProject_Load(object sender, EventArgs e)
        {
            var settings = SettingsManager.GetSettings();
            projects = new List<Project>();
            solutionGUID = Guid.NewGuid().ToString();
            solutionProjectGUID = Guid.NewGuid().ToString();
            newNames = SettingsManager.GetAllFinalNames();

            if (ComboboxProject.Items.Count > 0)
            {
                ComboboxProject.SelectedItem = ComboboxProject.Items[0];

                DisplayProjects(null);
            }

            if (settings != null)
            {
                FileDialogSolution.InitialDirectory = settings.DefaultDirectory;
                FolderBrowserCreate.SelectedPath = settings.DefaultDirectory;
                TextboxCreateDirectory.Text = settings.DefaultDirectory;
            }

            //CreateSettings();
        }

        private static void CreateSettings()
        {
            var coreGUID = Guid.NewGuid().ToString();
            var netGUID = Guid.NewGuid().ToString();

            var settings = new Models.Settings()
            {
                DefaultDirectory = "F:\\Tests\\Core",
                ProjectTypes = new List<ProjectType>()
                {
                    new ProjectType()
                    {
                        DisplayName = "Full .NET",
                        Projects = new List<Project>()
                        {
                            new Project()
                            {
                                Directory = "Templates.ClassLibraryNet\\Templates.ClassLibraryNet.csproj",
                                FinalName = "Templates.ClassLibrary",
                                Name = "ClassLibraryNet",
                                GUID = netGUID,
                                GUIDTwo = Guid.NewGuid().ToString()
                            },
                            new Project()
                            {
                                Directory = "Templates.MVC6Net\\Templates.MVC6Net.csproj",
                                FinalName = "Templates",
                                Name = "MVC6Net",
                                GUID = netGUID,
                                GUIDTwo = Guid.NewGuid().ToString()
                            },
                            new Project()
                            {
                                Directory = "Templates.TestNet\\Templates.TestNet.csproj",
                                FinalName = "Templates.Test",
                                Name = "TestNet",
                                GUID = netGUID,
                                GUIDTwo = Guid.NewGuid().ToString()
                            },
                            new Project()
                            {
                                Directory = "Templates.WebAPI2\\Templates.WebAPI2.csproj",
                                FinalName = "Templates.WebAPI",
                                Name = "WebAPI2",
                                GUID = netGUID,
                                GUIDTwo = Guid.NewGuid().ToString()
                            }
                        }
                    },
                    new ProjectType()
                    {
                        DisplayName = "Core",
                        Projects = new List<Project>()
                        {
                            new Project()
                            {
                                Directory = "Templates.ClassLibraryCore\\Templates.ClassLibraryCore.csproj",
                                FinalName = "Templates.ClassLibrary",
                                Name = "ClassLibraryCore",
                                GUID = coreGUID,
                                GUIDTwo = Guid.NewGuid().ToString()
                            },
                            new Project()
                            {
                                Directory = "Templates.MVC6Core\\Templates.MVC6Core.csproj",
                                FinalName = "Templates",
                                Name = "MVC6Core",
                                GUID = coreGUID,
                                GUIDTwo = Guid.NewGuid().ToString()
                            },
                            new Project()
                            {
                                Directory = "Templates.TestCore\\Templates.TestCore.csproj",
                                FinalName = "Templates.Test",
                                Name = "TestCore",
                                GUID = coreGUID,
                                GUIDTwo = Guid.NewGuid().ToString()
                            },
                            new Project()
                            {
                                Directory = "Templates.WebAPICore2\\Templates.WebAPICore2.csproj",
                                FinalName = "Templates.WebAPI",
                                Name = "WebAPICore2",
                                GUID = coreGUID,
                                GUIDTwo = Guid.NewGuid().ToString()
                            }
                        }
                    }
                }
            };

            if (File.Exists("Settings.json"))
            {
                File.Delete("Settings.json");
            }

            File.WriteAllText("Settings.json", JsonConvert.SerializeObject(settings));
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            CreateProjectAndSolution();

            MessageBox.Show("Finshed!");
        }

        private void CreateProjectAndSolution()
        {
            var settings = SettingsManager.GetSettings();

            if (ComboboxProject.SelectedItem != null)
            {
                var projectType = settings.ProjectTypes.Where(n => n.DisplayName == ComboboxProject.SelectedItem.ToString()).FirstOrDefault();

                if (!string.IsNullOrEmpty(TextboxNamespace.Text))
                {
                    if (!Directory.Exists(SolutionDirectory))
                    {
                        CopyFilesRecursively(new DirectoryInfo(FromSolutionDirectory), new DirectoryInfo(TextboxCreateDirectory.Text));

                        foreach (ListViewItem item in ListViewProjects.Items)
                        {
                            if (item.Checked)
                            {
                                var project = projectType.Projects.Where(n => n.Name == item.Text).FirstOrDefault();

                                var itemName = item.Text;
                                itemName = RenameLibraryAndTest(itemName);

                                foreach (var folder in Directory.GetDirectories(Environment.CurrentDirectory + "\\src"))
                                {
                                    var length = folder.Length - folder.IndexOf("src\\") - 4;

                                    if (folder.Contains("src\\") && (folder.Substring(folder.IndexOf("src\\") + 4, length)) == project.FolderName)
                                    {
                                        CopyFilesRecursively(new DirectoryInfo(folder), new DirectoryInfo(SolutionDirectory));
                                    }
                                }
                            }
                        }

                        EditSolution();
                    }
                    else
                    {
                        if (MessageBox.Show($"This Directory already exists {Environment.NewLine}{SolutionDirectory}, {Environment.NewLine}" +
                            $"would you like to delete it and create a project here?", "Non Empty Directory", 
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            Directory.Delete(SolutionDirectory, true);
                            CreateProjectAndSolution();
                        }
                    }
                }
                else
                {

                }
            }
            else
            {

            }
        }

        private string RenameLibraryAndTest(string itemName)
        {
            if (itemName == "Test")
            {
                if (ComboboxProject.SelectedItem.ToString() == "Core")
                {
                    itemName = "TestCore";
                }
                else
                {
                    itemName = "TestNet";
                }
            }

            if (itemName == "Class Library")
            {
                if (ComboboxProject.SelectedItem.ToString() == "Core")
                {
                    itemName = "ClassLibraryCore";
                }
                else
                {
                    itemName = "ClassLibraryNet";
                }
            }

            return itemName;
        }

        public void CopyFilesRecursively(DirectoryInfo source, DirectoryInfo target)
        {
            foreach (DirectoryInfo dir in source.GetDirectories())
            {
                if (!dir.Name.Contains("bin") && !dir.Name.Contains("obj"))
                {
                    if (newNames.Where(n => dir.Name.Contains(n.Key)).Count() == 0)
                    {
                        if (dir.GetFiles() == null)
                        {
                            Directory.CreateDirectory(Path.Combine(ReplaceKeywords(target.FullName), ReplaceKeywords(source.FullName)));
                        }

                        CopyFilesRecursively(dir, target.CreateSubdirectory(ReplaceKeywords(dir.Name)));
                    }
                    else
                    {
                        var newName = newNames.Where(n => dir.Name.Contains(n.Key)).FirstOrDefault();

                        if (dir.GetFiles() == null)
                        {
                            Directory.CreateDirectory(Path.Combine(ReplaceKeywords(newName, target.FullName), ReplaceKeywords(newName, source.FullName)));
                        }

                        CopyFilesRecursively(dir, target.CreateSubdirectory(ReplaceKeywords(newName, dir.Name)));
                    }
                }
            }

            foreach (FileInfo file in source.GetFiles())
            {
                if (!File.Exists(Path.Combine(ReplaceKeywords(target.FullName), ReplaceKeywords(file.Name))))
                {
                    if (newNames.Where(n => file.Name.Contains(n.Key)).Count() == 0)
                    {
                        var newPath = Path.Combine(ReplaceKeywords(target.FullName), ReplaceKeywords(file.Name));
                        file.CopyTo(newPath);

                        if (File.Exists(newPath))
                        {
                            string text = File.ReadAllText(newPath);

                            text = ReplaceFileKeywords(text);

                            File.WriteAllText(newPath, text);
                        }

                        AddProjectsToSolution(target, file);
                    }
                    else
                    {
                        var newName = newNames.Where(n => file.Name.Contains(n.Key)).FirstOrDefault();
                        var newPath = Path.Combine(ReplaceKeywords(newName, target.FullName), ReplaceKeywords(newName, file.Name));

                        file.CopyTo(newPath);

                        if (File.Exists(newPath))
                        {
                            string text = File.ReadAllText(newPath);

                            text = ReplaceFileKeywords(text);

                            File.WriteAllText(newPath, text);
                        }

                        AddProjectsToSolution(target, file);
                    }
                }
            }
        }

        private void AddProjectsToSolution(DirectoryInfo target, FileInfo file)
        {
            FileInfo newFileInfo = null;

            if (newNames.Where(n => file.Name.Contains(n.Key)).Count() == 0)
            {
                newFileInfo = new FileInfo(Path.Combine(ReplaceKeywords(target.FullName), ReplaceKeywords(file.Name)));
            }
            else
            {
                var newName = newNames.Where(n => file.Name.Contains(n.Key)).FirstOrDefault();
                newFileInfo = new FileInfo(Path.Combine(ReplaceKeywords(newName, target.FullName), ReplaceKeywords(newName, file.Name)));
            }

            if (newFileInfo.Name.Contains(".csproj"))
            {
                if (newFileInfo.Name.Length == (newFileInfo.Name.IndexOf(".csproj") + 7))
                {
                    if (newNames.Where(n => file.Name.Contains(n.Key)).Count() == 0)
                    {
                        projects.Add(new Project()
                        {
                            Name = newFileInfo.Name.Replace(".csproj", string.Empty),
                            Directory = newFileInfo.FullName.Replace(SolutionDirectory + "\\", string.Empty),
                            GUID = SolutionProjectGUID,
                            GUIDTwo = Guid.NewGuid().ToString()
                        });
                    }
                    else
                    {
                        var newName = newNames.Where(n => file.Name.Contains(n.Key)).FirstOrDefault();

                        projects.Add(new Project()
                        {
                            Name = ReplaceKeywords(newName, newFileInfo.Name.Replace(".csproj", string.Empty)),
                            Directory = ReplaceKeywords(newName, newFileInfo.FullName.Replace(SolutionDirectory + "\\", string.Empty)),
                            GUID = SolutionProjectGUID,
                            GUIDTwo = Guid.NewGuid().ToString()
                        });
                    }
                }
            }
        }

        private void EditSolution()
        {
            var fileInfo = new FileInfo(SolutionFile);
            var temp = fileInfo.Directory.FullName + "\\Temp.sln";

            if (fileInfo.Exists)
            {
                File.Move(fileInfo.FullName, temp);

                const Int32 BufferSize = 128;
                var newFile = string.Empty;

                using (var fileStream = File.OpenRead(temp))
                {
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                    {
                        String line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            using (var writeStream = new FileStream(SolutionFile, FileMode.Append))
                            {
                                using (var writer = new StreamWriter(writeStream))
                                {
                                    if (line.Contains("MinimumVisualStudioVersion"))
                                    {
                                        writer.WriteLine($"{newFile}{line}");

                                        foreach (var project in projects)
                                        {
                                            writer.WriteLine($"{newFile}Project(\"{SolutionProjectGUID}\") = \"{project.Name}\", \"{project.Directory}\", \"" + "{" + Guid.NewGuid().ToString() + "}" + $"\"");
                                            writer.WriteLine($"{newFile}EndProject");
                                        }
                                    }
                                    else if (line == "Global")
                                    {
                                        writer.WriteLine($"	GlobalSection(SolutionConfigurationPlatforms) = preSolution");
                                        writer.WriteLine($"		Debug|Any CPU = Debug|Any CPU");
                                        writer.WriteLine($"		Dev|Any CPU = Dev|Any CPU");
                                        writer.WriteLine($"		Stage|Any CPU = Stage|Any CPU");
                                        writer.WriteLine($"		xProduction|Any CPU = xProduction|Any CPU");
                                        writer.WriteLine($"	EndGlobalSection");
                                        writer.WriteLine($"	GlobalSection(ProjectConfigurationPlatforms) = postSolution");

                                        foreach (var project in projects)
                                        {
                                            writer.WriteLine("		{" + project.GUID + "}" + ".Debug|Any CPU.ActiveCfg = Debug|Any CPU");
                                            writer.WriteLine("		{" + project.GUID + "}" + ".Debug|Any CPU.Build.0 = Debug|Any CPU");
                                            writer.WriteLine("		{" + project.GUID + "}" + ".Dev|Any CPU.ActiveCfg = Dev|Any CPU");
                                            writer.WriteLine("		{" + project.GUID + "}" + ".Dev|Any CPU.Build.0 = Dev|Any CPU");
                                            writer.WriteLine("		{" + project.GUID + "}" + ".Stage|Any CPU.ActiveCfg = Stage|Any CPU");
                                            writer.WriteLine("		{" + project.GUID + "}" + ".Stage|Any CPU.Build.0 = Stage|Any CPU");
                                            writer.WriteLine("		{" + project.GUID + "}" + ".xProduction|Any CPU.ActiveCfg = xProduction|Any CPU");
                                            writer.WriteLine("		{" + project.GUID + "}" + ".xProduction|Any CPU.Build.0 = xProduction|Any CPU");
                                        }

                                        writer.WriteLine($"	EndGlobalSection");
                                    }
                                    else
                                    {
                                        writer.WriteLine($"{newFile}{line}");
                                    }
                                }
                            }
                        }
                    }
                }

                if (File.Exists(SolutionFile))
                {
                    File.Delete(temp);
                }
            }
        }

        private string ReplaceKeywords(string item)
        {
            item = item.Replace("Templates.Templates", TextboxNamespace.Text);
            item = item.Replace(TextboxNamespace.Text + "." + TextboxNamespace.Text, TextboxNamespace.Text);
            item = item.Replace("Templates", TextboxNamespace.Text);

            if (!item.Contains(".sln"))
            {
                item = item.Replace("CoreWebAPI", "WebAPI");
            }

            return item;
        }

        private string ReplaceKeywords(KeyValuePair<string, string> newName, string item)
        {
            item = item.Replace(newName.Key, newName.Value);

            item = ReplaceKeywords(item);

            return item;
        }

        private string ReplaceFileKeywords(string text)
        {
            foreach(var name in newNames)
            {
                text = text.Replace(name.Key, name.Value);
            }

            text = text.Replace("Templates.Templates", TextboxNamespace.Text);
            text = text.Replace("Templates", TextboxNamespace.Text);
            text = text.Replace("Application name", TextboxNamespace.Text);

            var settings = SettingsManager.GetSettings();

            foreach (var keyword in settings.Keywords)
            {
                //text = text.Replace("..\\..\\..\\..\\packages", "..\\packages");
                text = text.Replace(keyword.Before, keyword.After);
            }

            return text;
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

        private void ComboboxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayProjects(sender);
        }

        private void DisplayProjects(object sender)
        {
            ListViewProjects.Items.Clear();

            ListViewProjects.Columns.Add(new ColumnHeader() { Text = "Test", Width = 500 });

            if (sender != null)
            {
                var projects = SettingsManager.GetProjects(((ComboBox)sender).SelectedItem.ToString());

                foreach(var project in projects)
                {
                    ListViewProjects.Items.Add(new ListViewItem(project.Name));
                }
            }
            else
            {
                var projects = SettingsManager.GetProjects(ComboboxProject.SelectedItem.ToString());

                foreach (var project in projects)
                {
                    ListViewProjects.Items.Add(new ListViewItem(project.Name));
                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settings = new TemplateEngine.Settings();
            this.Hide();
            settings.ShowDialog();
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonBrowseSolution_Click(object sender, EventArgs e)
        {
            if (FileDialogSolution.ShowDialog() == DialogResult.OK)
            {
                TextBoxSolution.Text = FileDialogSolution.FileName;
            }
        }
    }  // End of Class
}
