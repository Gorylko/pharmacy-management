using Microsoft.EntityFrameworkCore;
using PharmacyManager.Business.Services.Interfaces;
using PharmacyManager.Data.Context;
using PharmacyManager.Shared.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PharmacyManager.Business.Services.Realization
{
    public class MedicamentService : IMedicamentService
    {
        private readonly PMContext _context = new PMContext();
        public MedicamentService()
        {

        }

        public IEnumerable<Medicament> GetAll()
        {
            return _context.Medicaments.ToList();
        }

        public Medicament GetById(int id)
        {
            return _context.Medicaments.Find(id);
        }

        public void Save(Medicament obj)
        {
            _context.Medicaments.Add(obj);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var medicament = _context.Find<Medicament>(id);
            Delete(medicament);
        }

        public void Delete(Medicament medicament)
        {
            if (_context.Entry(medicament).State == EntityState.Detached)
            {
                _context.Attach(medicament);
            }

            _context.Remove(medicament);
        }
    }
}
