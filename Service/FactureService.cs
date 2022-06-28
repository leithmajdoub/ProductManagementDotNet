using Data.Infrastructure;
using Domain.Entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class FactureService : EntityService<Facture>, IFactureService
    {
        public FactureService(IUnitOfWork utwk, IRepositoryBase<Facture> repository) : base(utwk, repository)
        {
        }
        public IEnumerable<Facture> GetFactureByPrice(string prix)
        {
            return this.GetMany().Where(f => f.Prix.ToString() == prix );
        }
    }
}
