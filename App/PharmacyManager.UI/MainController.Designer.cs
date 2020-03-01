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
            this.addMedButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MedicamentList
            // 
            this.MedicamentList.DisplayMember = "Name";
            this.MedicamentList.FormattingEnabled = true;
            this.MedicamentList.ItemHeight = 16;
            this.MedicamentList.Location = new System.Drawing.Point(16, 15);
            this.MedicamentList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MedicamentList.Name = "MedicamentList";
            this.MedicamentList.Size = new System.Drawing.Size(725, 420);
            this.MedicamentList.TabIndex = 0;
            this.MedicamentList.SelectedIndexChanged += new System.EventHandler(this.MedicamentList_SelectedIndexChanged);
            // 
            // addMedButton
            // 
            this.addMedButton.Location = new System.Drawing.Point(795, 15);
            this.addMedButton.Name = "addMedButton";
            this.addMedButton.Size = new System.Drawing.Size(204, 58);
            this.addMedButton.TabIndex = 1;
            this.addMedButton.Text = "Добавить";
            this.addMedButton.UseVisualStyleBackColor = true;
            this.addMedButton.Click += new System.EventHandler(this.AddMedButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(795, 98);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(204, 58);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MainController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 534);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.addMedButton);
            this.Controls.Add(this.MedicamentList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainController";
            this.Text = "MainController";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MedicamentList;
        private System.Windows.Forms.Button addMedButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}