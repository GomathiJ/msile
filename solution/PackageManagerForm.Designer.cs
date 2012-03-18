namespace msile
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
            this.packageManagerContainer1 = new msile.PackageManagerContainer();
            this.SuspendLayout();
            // 
            // packageManagerContainer1
            // 
            this.packageManagerContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageManagerContainer1.Location = new System.Drawing.Point(0, 0);
            this.packageManagerContainer1.Name = "packageManagerContainer1";
            this.packageManagerContainer1.Size = new System.Drawing.Size(632, 446);
            this.packageManagerContainer1.TabIndex = 0;
            // 
            // PackageManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 446);
            this.Controls.Add(this.packageManagerContainer1);
            this.Name = "PackageManagerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PackageManagerContainer packageManagerContainer1;
    }
}

