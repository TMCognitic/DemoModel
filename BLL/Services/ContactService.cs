using DAL_IContactRepository = DAL.Repositories.IContactRepository;
using BLL.Entities;
using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Mappers;

namespace BLL.Services
{
    public class ContactService : IContactRepository
    {
        private readonly DAL_IContactRepository _contactRepository;

        public ContactService(DAL_IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IEnumerable<Contact> Get()
        {
            return _contactRepository.Get().Select(c => c.ToBLL());
        }

        public IEnumerable<Contact> Get(Func<Contact, bool> predicate)
        {
            return _contactRepository.Get().Select(c => c.ToBLL()).Where(predicate);
        }
    }
}
