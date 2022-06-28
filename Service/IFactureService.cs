using Domain.Entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface IFactureService : IEntityService<Facture>
    {
        public IEnumerable<Facture> GetFactureByPrice(string prix);
    }
}
