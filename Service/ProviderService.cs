using Data.Infrastructure;
using Domain.Entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class ProviderService : EntityService<Provider>, IProviderService
    {
        public ProviderService(IUnitOfWork utwk, IRepositoryBase<Provider> repository) : base(utwk, repository)
        {

        }
    }
}
