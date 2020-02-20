using Microsoft.EntityFrameworkCore;
using PharmacyManager.Business.Services.Interfaces;
using PharmacyManager.Data.Context;
using PharmacyManager.Shared.Entities;
using System.Collections.Generic;

namespace PharmacyManager.Business.Services.Realization
{
    class UserService : IService<User>
    {
        private readonly PMContext _context = new PMContext();
        public UserService()
        {

        }


        public IEnumerable<User> GetAll()
        {
            return _context.AsQueryable();
        }

        public User GetById(int id)
        {
            return _context.Medicaments.Find(id);
        }

        public void Save(User obj)
        {
            _context.Medicaments.Add(obj);
        }

        public void Delete(int id)
        {
            var medicament = _context.Find<User>(id);
            Delete(medicament);
        }

        public void Delete(User medicament)
        {
            if (_context.Entry(medicament).State == EntityState.Detached)
            {
                _context.Attach(medicament);
            }

            _context.Remove(medicament);
        }
    }
}
