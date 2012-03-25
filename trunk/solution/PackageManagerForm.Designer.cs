namespace Msile
{
    /// <content>
    /// Contains designer-generated code.
    /// </content>
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.formContainer = new Msile.PackageManagerContainer();
            this.SuspendLayout();
            // 
            // formContainer
            // 
            resources.ApplyResources(this.formContainer, "formContainer");
            this.formContainer.Name = "formContainer";
            // 
            // PackageManagerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.formContainer);
            this.Name = "PackageManagerForm";
            this.Load += new System.EventHandler(this.PackageManagerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// Main container, used to group all the UI in the form.
        /// </summary>
        private PackageManagerContainer formContainer;
    }
}

