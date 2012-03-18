using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace msile
{
    public partial class PackageManagerForm : Form
    {
        public PackageManagerForm()
        {
            InitializeComponent();
        }

        private void LoadHandler(object sender, EventArgs e)
        {
            UpdateTitle();
        }

        private void UpdateTitle()
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Format("Msile Package Manager v{0}.{1} Alpha r{2}", version.Major, version.Minor, version.Build);
        }
    }
}
