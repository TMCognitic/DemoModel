using System;
using System.Collections.Generic;
using System.Text;
using G = DemoModel.Models.Global;
using DemoModel.Models.Client;

namespace DemoModel.Models.Client.Mappers
{
    internal static class Mappers
    {
        internal static G.Contact ToGlobal(this Contact entity)
        {
            return new G.Contact() { Id = entity.Id, Nom = entity.Nom, Prenom = entity.Prenom };
        }

        internal static Contact ToClient(this G.Contact entity)
        {
            return new Contact(entity.Id, entity.Nom, entity.Prenom);
        }
    }
}
