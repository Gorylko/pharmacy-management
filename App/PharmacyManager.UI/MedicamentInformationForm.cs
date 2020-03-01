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
    public partial class MedicamentInformationForm : Form
    {
        private readonly Medicament _currentMeticament;

        public MedicamentInformationForm(Medicament medicament)
        {
            this._currentMeticament = medicament ?? throw new ArgumentNullException(nameof(medicament));

            InitializeComponent();
        }

        private void MedicamentInformationForm_Load(object sender, EventArgs e)
        {
            RenderMedicament();
        }

        private void RenderMedicament()
        {
            this.MName.Text = this._currentMeticament.Name;
            this.MDescr.Text = this._currentMeticament.Description;
            this.MManufacturer.Text = this._currentMeticament.Manufacturer;
            this.MDate.Text = this._currentMeticament.ReceiptDate.ToString();
            this.IsAvailable.Text = this._currentMeticament.IsAvailable ? "Да" : "Нет";
        }
    }
}
