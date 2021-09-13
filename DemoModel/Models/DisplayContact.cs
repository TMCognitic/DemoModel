using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DemoModel.Models
{
    public class DisplayContact
    {
        public int Id { get; set; }
        [DisplayName("Nom")]
        public string LastName { get; set; }
        [DisplayName("Prenom")]
        public string FirstName { get; set; }
    }
}
