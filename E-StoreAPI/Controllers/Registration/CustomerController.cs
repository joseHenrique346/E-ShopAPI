using Arguments.Argument.Registration.Customer;
using Domain.DTO.Entity.Customer;
using Domain.Interface.Service.Customer;
using E_StoreAPI.Controllers.Base;
using Infrastructure.Persistence.EFCore.UnitOfWork.Interface;
using Microsoft.AspNetCore.Mvc;

namespace E_StoreAPI.Controllers.Registration
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : BaseController<ICustomerService, CustomerDTO, OutputCustomer, InputIdentityViewCustomer, InputCreateCustomer, InputIdentityUpdateCustomer, InputIdentityDeleteCustomer>
    {
        public CustomerController(ICustomerService service, IUnitOfWork unitOfWork) : base(service, unitOfWork) { }
    }
}
