using System;
using System.Collections.Generic;
using System.Text;
using G = DemoModel.Api.Models.Global;
using DemoModel.Api.Models.Client;

namespace DemoModel.Api.Models.Client.Mappers
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
