using DAL.Entities;
using DAL.Mappers;
using DAL.Repositories;
using System.Collections.Generic;
using Tools.Connections.Database;

namespace DAL.Services
{
    public class ContactService : IContactRepository
    {
        private readonly IConnection _connection;

        public ContactService(IConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Contact> Get()
        {
            Command command = new Command("SELECT [Id], [LastName], [FirstName] FROM [Contact];", false);
            return _connection.ExecuteReader(command, dr => dr.ToContact());
        }
    }
}
