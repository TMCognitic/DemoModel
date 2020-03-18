using DemoModel.Api.Models.Global.Mappers;
using DemoModel.Api.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolBox.Connections;

namespace DemoModel.Api.Models.Global.Services
{
    public class ContactRepository : IContactRepository<Contact>
    {
        private const string ConnectionString = @"Data Source=AW-BRIAREOS\SQL2016DEV;Initial Catalog=DemoModel;Integrated Security=True";
        private Connection _dbConnection;

        public ContactRepository()
        {
            _dbConnection = new Connection(ConnectionString);
        }

        public IEnumerable<Contact> Get()
        {
            Command command = new Command("Select Id, Nom, Prenom, Created from Contact;");
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToContact());
        }

        public Contact Get(int id)
        {
            Command command = new Command("Select Id, Nom, Prenom, Created from Contact where Id = @Id;");
            command.AddParameter("Id", id);
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToContact()).SingleOrDefault();
        }

        public Contact Insert(Contact entity)
        {
            Command command = new Command("Insert into Contact (Nom, Prenom) output inserted.* values (@Nom, @Prenom);");
            command.AddParameter("Nom", entity.Nom);
            command.AddParameter("Prenom", entity.Prenom);
            return _dbConnection.ExecuteReader(command, (dr) => dr.ToContact()).Single();
        }
    }
}
