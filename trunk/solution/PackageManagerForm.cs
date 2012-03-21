using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Msile
{
    public partial class PackageManagerForm : Form
    {
        public PackageManagerForm()
        {
            InitializeComponent();
        }

        private void PackageManagerForm_Load(object sender, EventArgs e)
        {
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Version version = assembly.GetName().Version;
            CultureInfo culture = CultureInfo.CurrentUICulture;
            String format = Properties.Resources.PackageManagerFormTitleFormat;
            this.Text = String.Format(culture, format, this.Text, version.Major, version.Minor, version.Build);
        }
    }
}
