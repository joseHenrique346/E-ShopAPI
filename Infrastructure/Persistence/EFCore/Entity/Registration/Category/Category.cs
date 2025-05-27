using Infrastructure.Persistence.EFCore.Entity.Base;

namespace Infrastructure.Persistence.EFCore.Entity.Registration;

public class Category : BaseEntity
{
    #region Properties
    public string Code { get; set; }
    public string Description { get; set; }
    #endregion

    #region Mapping
    public List<Product> ListProducts { get; set; } = [];

    #endregion

    #region Controllers
    public Category(string code, string description, List<Brand> listBrands)
    {
        Code = code;
        Description = description;
        ListBrands = listBrands;
    }

    public Category() { }
    #endregion

    #region Implicit Operators
    // Conversão implícita de Category para CategoryDto
    //public static implicit operator CategoryDto(Category category)
    //{
    //    return new CategoryDto
    //    {
    //        Id = category.Id,
    //        Code = category.Code,
    //        Description = category.Description
    //    };
    //}

    // Conversão implícita de CategoryDto para Category
    //public static implicit operator Category(CategoryDto dto)
    //{
    //    return new Category
    //    {
    //        Id = dto.Id,
    //        Code = dto.Code,
    //        Description = dto.Description
    //    };
    //}
    #endregion

    #region Conversion Methods
    // Converte a entidade atual em DTO
    //public CategoryDto ToDto()
    //{
    //    return this;
    //}

    // Converte um DTO em entidade
    //public static Category ToEntry(CategoryDto dto)
    //{
    //    return dto;
    //}
    #endregion
}