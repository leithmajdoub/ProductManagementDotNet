using Data.Infrastructure;
using Domain.Entities;
using ServicePattern;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class ClientService : EntityService<Client>, IClientService
    {
        public ClientService(IUnitOfWork utwk, IRepositoryBase<Client> repository) : base(utwk, repository)
        {

        }
        public float GetTotalFacturePrice(int clientid)
        {
            float total = 0;
            var client = this.GetById((int)clientid);
            foreach(var f in client.Factures)
            {
                total = total + f.Prix;
            }
            return total;
        }
    }
}
