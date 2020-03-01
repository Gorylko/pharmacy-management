namespace PharmacyManager.UI
{
    partial class UpdateMedicamentForm
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
            this.IsAvailable = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Manufacturer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MedName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IsAvailable
            // 
            this.IsAvailable.AutoSize = true;
            this.IsAvailable.Checked = true;
            this.IsAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsAvailable.Location = new System.Drawing.Point(521, 252);
            this.IsAvailable.Name = "IsAvailable";
            this.IsAvailable.Size = new System.Drawing.Size(130, 21);
            this.IsAvailable.TabIndex = 25;
            this.IsAvailable.Text = "Есть на складе";
            this.IsAvailable.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Дата поступления";
            // 
            // ReceiptDate
            // 
            this.ReceiptDate.Location = new System.Drawing.Point(521, 72);
            this.ReceiptDate.Name = "ReceiptDate";
            this.ReceiptDate.Size = new System.Drawing.Size(200, 22);
            this.ReceiptDate.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Производитель";
            // 
            // Manufacturer
            // 
            this.Manufacturer.Location = new System.Drawing.Point(89, 272);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(144, 22);
            this.Manufacturer.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Описание";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(89, 124);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(214, 117);
            this.Description.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Название";
            // 
            // MedName
            // 
            this.MedName.Location = new System.Drawing.Point(89, 72);
            this.MedName.Name = "MedName";
            this.MedName.Size = new System.Drawing.Size(144, 22);
            this.MedName.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 59);
            this.button2.TabIndex = 16;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 59);
            this.button1.TabIndex = 15;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UpdateMedicamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IsAvailable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReceiptDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UpdateMedicamentForm";
            this.Text = "UpdateMedicamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IsAvailable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ReceiptDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Manufacturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MedName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}