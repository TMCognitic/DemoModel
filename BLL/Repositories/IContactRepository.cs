using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public interface IContactRepository
    {
        IEnumerable<Contact> Get();
        IEnumerable<Contact> Get(Func<Contact,bool> predicate);
    }
}
