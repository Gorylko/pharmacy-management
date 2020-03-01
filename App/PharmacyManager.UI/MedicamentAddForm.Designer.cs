namespace PharmacyManager.UI
{
    partial class MedicamentAddForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MedName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Manufacturer = new System.Windows.Forms.TextBox();
            this.ReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.IsAvailable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // MedName
            // 
            this.MedName.Location = new System.Drawing.Point(96, 86);
            this.MedName.Name = "MedName";
            this.MedName.Size = new System.Drawing.Size(144, 22);
            this.MedName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Описание";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(96, 138);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(214, 117);
            this.Description.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Производитель";
            // 
            // Manufacturer
            // 
            this.Manufacturer.Location = new System.Drawing.Point(96, 286);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(144, 22);
            this.Manufacturer.TabIndex = 8;
            // 
            // ReceiptDate
            // 
            this.ReceiptDate.Location = new System.Drawing.Point(528, 86);
            this.ReceiptDate.Name = "ReceiptDate";
            this.ReceiptDate.Size = new System.Drawing.Size(200, 22);
            this.ReceiptDate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Дата поступления";
            // 
            // IsAvailable
            // 
            this.IsAvailable.AutoSize = true;
            this.IsAvailable.Checked = true;
            this.IsAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsAvailable.Location = new System.Drawing.Point(528, 266);
            this.IsAvailable.Name = "IsAvailable";
            this.IsAvailable.Size = new System.Drawing.Size(130, 21);
            this.IsAvailable.TabIndex = 14;
            this.IsAvailable.Text = "Есть на складе";
            this.IsAvailable.UseVisualStyleBackColor = true;
            // 
            // MedicamentAddForm
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
            this.Name = "MedicamentAddForm";
            this.Text = "MedicamentAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox MedName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Manufacturer;
        private System.Windows.Forms.DateTimePicker ReceiptDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox IsAvailable;
    }
}