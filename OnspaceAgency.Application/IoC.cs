using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using OnspaceAgency.Application.Company.Handlers;
using OnspaceAgency.Application.Files.Handlers;
using OnspaceAgency.Application.Portfolio.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application
{
    public static class IoC
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ICompanyHandler, CompanyHandler>();
            services.AddTransient<IFilesHandler, FilesHandler>();
            services.AddTransient<IPortfolioHandler, PortfolioHandler>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
