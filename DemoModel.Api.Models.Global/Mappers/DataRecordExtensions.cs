using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DemoModel.Api.Models.Global.Mappers
{
    internal static class DataRecordExtensions
    {
        internal static Contact ToContact(this IDataRecord dataRecord)
        {
            return new Contact() { Id = (int)dataRecord["Id"], Nom = (string)dataRecord["Nom"], Prenom = (string)dataRecord["Prenom"], Created = (DateTime)dataRecord["Created"] };
        }
    }
}
