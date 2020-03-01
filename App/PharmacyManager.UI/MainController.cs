using PharmacyManager.Business.Services.Interfaces;
using PharmacyManager.Business.Services.Realization;
using PharmacyManager.Shared.Entities;
using PharmacyManager.Shared.Enums;
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
        private readonly IMedicamentService _medicamentService;
        private readonly User _currentUser;

        public MainController(User user)
        {
            this._medicamentService = = new MedicamentService();

            InitializeComponent();

            this._currentUser = user;
            this.MedicamentList.DataSource =_medicamentService.GetAll();

            InitializeByUserRole();
        }

        private void MedicamentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddMedButton_Click(object sender, EventArgs e)
        {
            var addMenu = new MedicamentAddForm(UpdateMedicamentList);

            addMenu.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var medicament = (Medicament)this.MedicamentList.SelectedItem;

            _medicamentService.Delete(medicament);

            UpdateMedicamentList();
        }

        private void UpdateMedicamentList()
        {
            this.MedicamentList.DataSource = _medicamentService.GetAll();
        }

        private void InitializeByUserRole()
        {
            if(this._currentUser == null)
            {
                throw new Exception("wtf");
            }

            if(this._currentUser.Role == RoleType.User)
            {
                this.addMedButton.Hide();
                this.DeleteButton.Hide();
            }
        }
    }
}
