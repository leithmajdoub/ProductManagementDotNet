﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ServicePattern;

namespace Service
{
    public interface IProductService : IEntityService<Product>
    {

    }
}
