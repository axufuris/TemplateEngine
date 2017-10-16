using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using TemplateEngine.Models;

namespace TemplateEngine.Managers
{
    public static class SettingsManager
    {
        public static Models.Settings GetSettings()
        {
            if (File.Exists("Settings.json"))
            {
                var settingString = File.ReadAllText("Settings.json");

                var settings = JsonConvert.DeserializeObject<Models.Settings>(settingString);

                return settings;
            }

            return null;
        }

        public static void SaveSettings(Models.Settings settings)
        {
            if (File.Exists("Settings.json"))
            {
                File.Move("Settings.json", "Settings-" + DateTime.Now.ToString() + ".json");

                File.WriteAllText("Settings.json", JsonConvert.SerializeObject(settings));
            }
        }

        public static void AddProject(string projectTypeName, Project project)
        {
            var settings = GetSettings();

            var projectType = settings.ProjectTypes.Where(n => n.DisplayName == projectTypeName).FirstOrDefault();

            if (projectType != null)
            {
                projectType.Projects.Add(project);

                SaveSettings(settings);
            }
        }

        public static void AddProjectType(string projectTypeName)
        {
            var settings = GetSettings();

            var projectType = new ProjectType()
            {
                DisplayName = projectTypeName
            };

            settings.ProjectTypes.Add(projectType);

            SaveSettings(settings);
        }

        public static bool DeleteValue(ListViewItem selected)
        {
            var settings = GetSettings();

            if (selected != null)
            {
                var projectType = settings.ProjectTypes.Where(n => n.DisplayName == selected.SubItems[0].Text).FirstOrDefault();

                var item = projectType.Projects.Where(z => z.Name == selected.SubItems[1].Text &&
                        z.Directory == selected.SubItems[3].Text).FirstOrDefault();

                projectType.Projects.Remove(item);

                SaveSettings(settings);

                return true;
            }

            return false;
        }

        public static List<Project> GetProjects(string projectTypeName)
        {
            var settings = GetSettings();

            if (settings != null)
            {
                var projectType = settings.ProjectTypes.Where(n => n.DisplayName == projectTypeName).FirstOrDefault();

                if (projectType != null)
                {
                    return projectType.Projects;
                }
            }

            return null;
        }

        public static List<KeyValuePair<string, string>> GetAllFinalNames()
        {
            var names = new List<KeyValuePair<string, string>>();

            foreach(var projectType in GetSettings().ProjectTypes)
            {
                foreach (var project in projectType.Projects)
                {
                    names.Add(new KeyValuePair<string, string>(project.Name, project.FinalName));
                }
            }

            return names;
        }
    }  // End of Class
}
