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
    public partial class AddKeyword : Form
    {
        public AddKeyword()
        {
            InitializeComponent();
        }

        private void ButtonAddKeyword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextboxBefore.Text) && !string.IsNullOrEmpty(TextboxAfter.Text))
            {
                var keyword = new Keywords()
                {
                    Before = TextboxBefore.Text,
                    After = TextboxAfter.Text
                };

                SettingsManager.AddKeyword(keyword);

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
