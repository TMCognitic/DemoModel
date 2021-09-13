using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class Contact
    {
        public int Id { get; private set; }
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        internal Contact(int id, string lastName, string firstName)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
        }
    }
}
