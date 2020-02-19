using PharmacyManager.Business.Services.Realization;
using PharmacyManager.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManager.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var service = new MedicamentService();
            var medicament = new Medicament
            {
                Name = "Жопазал",
                Description = "Для жопы",
                Manufacturer = "Хохляндия"
            };
            service.Save(medicament);
        }
    }
}
