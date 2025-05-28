using Arguments.Argument.Registration.Product;
using Domain.DTO.Entity.Product;
using Domain.Interface.Service.Product;
using E_StoreAPI.Controllers.Base;
using Infrastructure.Persistence.EFCore.UnitOfWork.Interface;
using Microsoft.AspNetCore.Mvc;

namespace E_StoreAPI.Controllers.Registration
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : BaseController<IProductService, ProductDTO, OutputProduct, InputIdentityViewProduct, InputCreateProduct, InputIdentityUpdateProduct, InputIdentityDeleteProduct>
    {
        public ProductController(IProductService service, IUnitOfWork unitOfWork) : base(service, unitOfWork) { }
    }
}
