using DAL.Entities;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public interface IContactRepository
    {
        IEnumerable<Contact> Get();
    }
}
