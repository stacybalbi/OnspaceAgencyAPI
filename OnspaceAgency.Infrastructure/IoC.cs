using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnspaceAgency.Application.Interfaces;
using OnspaceAgency.Infrastructure.Context;
using OnspaceAgency.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Infrastructure
{
    public static class IoC
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<IFilesService, FilesService>();
            services.AddTransient<IPortfolioService, PortfolioService>();
            services.AddTransient<IOnspaceAgencyDbContext, OnspaceAgencyDbContext>();


            services.AddDbContext<OnspaceAgencyDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("OnspaceAgencydb")));

            return services;


        }
    }
}
