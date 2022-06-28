﻿using Domain.Entities;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface IClientService : IEntityService<Client>
    {
        public float GetTotalFacturePrice(int clientid);
    }

    
}
