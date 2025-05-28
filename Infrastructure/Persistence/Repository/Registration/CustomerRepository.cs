using Arguments.Argument.Registration.Customer;
using Domain.DTO.Entity.Customer;
using Domain.Interface.Repository;
using Infrastructure.Persistence.EFCore.Context;
using Infrastructure.Persistence.EFCore.Entity.Registration;
using Infrastructure.Persistence.Repository.Base;

namespace Infrastructure.Persistence.Repository.Registration
{
    public class CustomerRepository(AppDbContext context) : BaseRepository<Customer, CustomerDTO, InputIdentityViewCustomer>(context), ICustomerRepository { }
}