using PharmacyManager.Business.Services.Interfaces;
using PharmacyManager.Business.Services.Realization;
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
    public partial class MainController : Form
    {
        IMedicamentService _medicamentService = new MedicamentService();

        public MainController()
        {
            InitializeComponent();
            _medicamentService.Save(new Shared.Entities.Medicament
            {
                Name = "Гагага",
                Description = "dsdsd",
                Manufacturer = "dsdasaa"
            });
            this.MedicamentList.DataSource =_medicamentService.GetAll();
        }

        private void MedicamentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
