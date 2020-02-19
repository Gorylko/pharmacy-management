using PharmacyManager.Business.Services.Interfaces;
using PharmacyManager.Data.Context;
using PharmacyManager.Shared.Entities;

namespace PharmacyManager.Business.Services.Realization
{
    public class MedicamentService : IMedicamentService
    {
        private readonly PMContext _context = new PMContext();
        public MedicamentService()
        {

        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Medicament GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Medicament GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Medicament obj)
        {
            _context.Medicaments.Add(obj);
        }
    }
}
