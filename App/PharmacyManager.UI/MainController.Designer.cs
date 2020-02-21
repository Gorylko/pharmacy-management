namespace PharmacyManager.UI
{
    partial class MainController
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
            this.MedicamentList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MedicamentList
            // 
            this.MedicamentList.FormattingEnabled = true;
            this.MedicamentList.Location = new System.Drawing.Point(12, 12);
            this.MedicamentList.Name = "MedicamentList";
            this.MedicamentList.Size = new System.Drawing.Size(545, 342);
            this.MedicamentList.TabIndex = 0;
            this.MedicamentList.SelectedIndexChanged += new System.EventHandler(this.MedicamentList_SelectedIndexChanged);
            // 
            // MainController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 434);
            this.Controls.Add(this.MedicamentList);
            this.Name = "MainController";
            this.Text = "MainController";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MedicamentList;
    }
}