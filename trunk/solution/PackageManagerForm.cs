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
    /// <summary>
    /// The main form, used to manage the packages.
    /// </summary>
    public partial class PackageManagerForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageManagerForm"/> class.
        /// </summary>
        public PackageManagerForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Load event handler for the <see cref="PackageManagerForm"/>.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void PackageManagerForm_Load(object sender, EventArgs e)
        {
            this.UpdateTitle();
        }

        /// <summary>
        /// Updates the form's title, using a localized representation of the current name and version of the program.
        /// </summary>
        private void UpdateTitle()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Version version = assembly.GetName().Version;
            CultureInfo culture = CultureInfo.CurrentUICulture;
            string format = Properties.Resources.PackageManagerFormTitleFormat;
            this.Text = string.Format(culture, format, this.Text, version.Major, version.Minor, version.Build);
        }
    }
}
