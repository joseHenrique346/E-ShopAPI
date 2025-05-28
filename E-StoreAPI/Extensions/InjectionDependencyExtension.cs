using Domain.Interface.Repository;
using Domain.Interface.Service.Brand;
using Domain.Interface.Service.Category;
using Domain.Interface.Service.Customer;
using Domain.Interface.Service.Product;
using Domain.Service.Registration.Brand;
using Domain.Service.Registration.Category;
using Domain.Service.Registration.Customer;
using Domain.Service.Registration.Product;
using Infrastructure.Persistence.EFCore.UnitOfWork.Interface;
using Infrastructure.Persistence.EFCore.UnitOfWork.UnitOfWork;
using Infrastructure.Persistence.Repository.Registration;

namespace E_StoreAPI.Extensions
{
    internal static class InjectionDependencyExtension
    {
        public static IServiceCollection ConfigureInjectionDependency(this IServiceCollection services)
        {
            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IBrandValidateService, BrandValidateService>();
            services.AddScoped<ICustomerValidateService, CustomerValidateService>();
            services.AddScoped<ICategoryValidateService, CategoryValidateService>();
            services.AddScoped<IProductValidateService, ProductValidateService>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}