using PharmacyManager.Business.Services.Interfaces;
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
    public partial class MedicamentAddForm : Form
    {
        private readonly IMedicamentService _medicamentService;
        private readonly Action _updateAction;

        public MedicamentAddForm(Action updateAction)
        {
            InitializeComponent();

            this._medicamentService = new MedicamentService();
            this._updateAction = updateAction ?? throw new ArgumentNullException(nameof(updateAction));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _updateAction();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var inputMedicament = GetInputMedicament();

            _medicamentService.Save(inputMedicament);

            _updateAction();
            this.Close();
        }

        private Medicament GetInputMedicament()
        {
            return new Medicament
            {
                Name = this.MedName.Text,
                Description = this.Description.Text,
                Manufacturer = this.Manufacturer.Text,
                IsAvailable = this.IsAvailable.Checked,
                ReceiptDate = ReceiptDate.Value,
            };
        }
    }
}
