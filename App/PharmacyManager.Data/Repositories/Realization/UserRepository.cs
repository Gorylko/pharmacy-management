using PharmacyManager.Data.Repositories.Interfaces;
using PharmacyManager.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManager.Data.Repositories.Realization
{
    public class UserRepository : IUserRepository
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Medicament GetAll()
        {
            throw new NotImplementedException();
        }

        public Medicament GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Medicament obj)
        {
            throw new NotImplementedException();
        }

        public void Save(User obj)
        {
            throw new NotImplementedException();
        }

        User IRepository<User>.GetAll()
        {
            throw new NotImplementedException();
        }

        User IRepository<User>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
