using Microsoft.EntityFrameworkCore;
using PharmacyManager.Business.Services.Interfaces;
using PharmacyManager.Data.Context;
using PharmacyManager.Shared.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PharmacyManager.Business.Services.Realization
{
    public class UserService : IUserService
    {
        private readonly PMContext _context = new PMContext();
        public UserService()
        {

        }

        public User GetByCredentials(string login, string password)
        {
            return _context.Users
                .FirstOrDefault(user => user.Login == login
                             && user.Password == password);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.AsQueryable();
        }

        public User GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public void Save(User obj)
        {
            _context.Users.Add(obj);
            _context.SaveChanges();
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
