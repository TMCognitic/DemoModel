using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoModel.Web.Models.Forms
{
    public class CreateContactForm
    {
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
    }
}
