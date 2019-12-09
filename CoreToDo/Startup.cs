using AutoMapper;
using CoreBase;
using CoreToDo.Persistance;
using CoreToDo.Persistance.Finders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CoreToDo
{
    public class Startup : BaseStartup
    {
        public Startup(IHostEnvironment env) : base(env) { }

        public override void ConfigureServices(IServiceCollection services)
        {
            base.ConfigureServices(services);

            services.AddScoped<IPersonFinder, PersonFinder>();
            services.AddScoped<IItemFinder, ItemFinder>();
            services.AddScoped<ICategoryFinder, CategoryFinder>();

            services.AddAutoMapper(typeof(BaseStartup), typeof(Startup));

        }
    }
}
