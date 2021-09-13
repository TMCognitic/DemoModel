using DalContact = DAL.Entities.Contact;
using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mappers
{
    internal static class Mappers
    {
        internal static Contact ToBLL(this DalContact entity)
        {
            return new Contact(entity.Id, entity.LastName, entity.FirstName);
        }
    }
}
