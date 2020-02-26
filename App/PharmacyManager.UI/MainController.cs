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
    public partial class MainController : Form
    {
        private readonly IMedicamentService _medicamentService = new MedicamentService();
        private readonly User _currentUser;

        public MainController(User user)
        {
            InitializeComponent();
            _medicamentService.Save(new Shared.Entities.Medicament
            {
                Name = "Гагага",
                Description = "dsdsd",
                Manufacturer = "dsdasaa"
            });
            this._currentUser = user;
            this.MedicamentList.DataSource =_medicamentService.GetAll();
        }

        private void MedicamentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
