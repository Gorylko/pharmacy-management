namespace PharmacyManager.UI
{
    partial class MedicamentInformationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.MManufacturer = new System.Windows.Forms.Label();
            this.MName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MDate = new System.Windows.Forms.Label();
            this.MDescr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IsAvailable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // MManufacturer
            // 
            this.MManufacturer.AutoSize = true;
            this.MManufacturer.Location = new System.Drawing.Point(185, 73);
            this.MManufacturer.Name = "MManufacturer";
            this.MManufacturer.Size = new System.Drawing.Size(46, 17);
            this.MManufacturer.TabIndex = 1;
            this.MManufacturer.Text = "label2";
            // 
            // MName
            // 
            this.MName.AutoSize = true;
            this.MName.Location = new System.Drawing.Point(185, 33);
            this.MName.Name = "MName";
            this.MName.Size = new System.Drawing.Size(46, 17);
            this.MName.TabIndex = 2;
            this.MName.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(332, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(26, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Производитель";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(26, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Дата поступления";
            // 
            // MDate
            // 
            this.MDate.AutoSize = true;
            this.MDate.Location = new System.Drawing.Point(185, 110);
            this.MDate.Name = "MDate";
            this.MDate.Size = new System.Drawing.Size(46, 17);
            this.MDate.TabIndex = 16;
            this.MDate.Text = "label7";
            // 
            // MDescr
            // 
            this.MDescr.AutoSize = true;
            this.MDescr.Location = new System.Drawing.Point(420, 33);
            this.MDescr.MaximumSize = new System.Drawing.Size(350, 700);
            this.MDescr.Name = "MDescr";
            this.MDescr.Size = new System.Drawing.Size(46, 17);
            this.MDescr.TabIndex = 17;
            this.MDescr.Text = "label8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Есть на складе : ";
            // 
            // IsAvailable
            // 
            this.IsAvailable.AutoSize = true;
            this.IsAvailable.Location = new System.Drawing.Point(185, 154);
            this.IsAvailable.Name = "IsAvailable";
            this.IsAvailable.Size = new System.Drawing.Size(46, 17);
            this.IsAvailable.TabIndex = 19;
            this.IsAvailable.Text = "label7";
            // 
            // MedicamentInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IsAvailable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MDescr);
            this.Controls.Add(this.MDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MName);
            this.Controls.Add(this.MManufacturer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MedicamentInformationForm";
            this.Text = "MedicamentInformationForm";
            this.Load += new System.EventHandler(this.MedicamentInformationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MManufacturer;
        private System.Windows.Forms.Label MName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label MDate;
        private System.Windows.Forms.Label MDescr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IsAvailable;
    }
}