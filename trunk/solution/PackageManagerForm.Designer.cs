namespace Msile
{
    partial class PackageManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageManagerForm));
            this.packageManagerContainer1 = new Msile.PackageManagerContainer();
            this.SuspendLayout();
            // 
            // packageManagerContainer1
            // 
            resources.ApplyResources(this.packageManagerContainer1, "packageManagerContainer1");
            this.packageManagerContainer1.Name = "packageManagerContainer1";
            // 
            // PackageManagerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.packageManagerContainer1);
            this.Name = "PackageManagerForm";
            this.Load += new System.EventHandler(this.PackageManagerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PackageManagerContainer packageManagerContainer1;
    }
}

