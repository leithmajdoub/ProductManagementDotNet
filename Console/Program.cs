using System;
using Domain.Entities;
using Service;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Data.Infrastructure;
using Data;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<ICategoryService,CategoryService>()
                                .AddTransient<IUnitOfWork, UnitOfWork>()
                                .AddTransient(typeof(IRepositoryBase<>), typeof(RepositoryBase<>))
                                .AddSingleton<IDatabaseFactory, DatabaseFactory>()
                                .AddScoped<IProductService, ProductService>()
                                .AddScoped<IProviderService, ProviderService>()
                                .AddScoped<IClientService, ClientService>()
                                .AddScoped<IFactureService, FactureService>()
                                .AddDbContext<ProductManagementContext>();
            var serviceProvider = serviceCollection.BuildServiceProvider();


        }
    }
}
