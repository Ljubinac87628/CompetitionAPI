using Competition.BusinessLogic;
using Competition.BusinessLogic.Interfaces;
using Competition.Services;
using Competition.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Competition.DependecyInjection
{
    public static class DIAdapter
    {
        public static void AddMyServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICompetitorBusinessLogic, CompetitorBusinessLogic>( );
            services.AddScoped<ICompetitorService, CompetitorService>();
        }
    }
}
