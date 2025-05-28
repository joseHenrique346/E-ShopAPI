using Arguments.Argument.Registration.Category;
using Domain.DTO.Entity.Category;
using Domain.Interface.Service.Category;
using E_StoreAPI.Controllers.Base;
using Infrastructure.Persistence.EFCore.UnitOfWork.Interface;
using Microsoft.AspNetCore.Mvc;

namespace E_StoreAPI.Controllers.Registration
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : BaseController<ICategoryService, CategoryDTO, OutputCategory, InputIdentityViewCategory, InputCreateCategory, InputIdentityUpdateCategory, InputIdentityDeleteCategory>
    {
        public CategoryController(ICategoryService service, IUnitOfWork unitOfWork) : base(service, unitOfWork) { }
    }
}
