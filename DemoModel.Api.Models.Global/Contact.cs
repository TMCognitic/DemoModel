using System;

namespace DemoModel.Api.Models.Global
{
    public class Contact
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Created { get; set; }
    }
}
