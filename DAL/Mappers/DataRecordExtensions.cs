using DAL.Entities;
using System.Data;

namespace DAL.Mappers
{
    internal static class DataRecordExtensions
    {
        internal static Contact ToContact(this IDataRecord dataRecord)
        {
            return new Contact()
            {
                Id = (int)dataRecord["Id"],
                LastName = (string)dataRecord["LastName"],
                FirstName = (string)dataRecord["FirstName"]
            };
        }
    }
}
