using System;
using System.Collections.Generic;
using System.Text;

namespace DemoModel.Api.Models.Client
{
    public class Contact
    {
        public int Id { get; private set; }
        public string Nom { get; private set; }
        public string Prenom { get; private set; }

        public Contact(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        internal Contact(int id, string nom, string prenom)
            : this(nom, prenom)
        {
            Id = id;
        }
    }
}
