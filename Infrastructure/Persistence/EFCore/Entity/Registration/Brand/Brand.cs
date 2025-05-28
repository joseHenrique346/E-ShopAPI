using Infrastructure.Persistence.EFCore.Entity.Base;

namespace Infrastructure.Persistence.EFCore.Entity.Registration;

public class Brand : BaseEntity
{
    #region Properties
    public string Code { get; set; }
    public string Description { get; set; }
    #endregion

    #region Mapping
    public List<Product> ListProduct { get; set; } = [];

    #endregion

    #region Controllers

    public Brand(string code, string description, List<Product> listProduct)
    {
        Code = code;
        Description = description;
        ListProduct = listProduct;
    }

    public Brand() { }

    #endregion

    #region Implicit Operators
    // Conversão implícita de Brand para BrandDto
    //public static implicit operator BrandDto(Brand brand)
    //{
    //    return new BrandDto
    //    {
    //        Id = brand.Id,
    //        Code = brand.Code,
    //        Description = brand.Description
    //    };
    //}

    // Conversão implícita de BrandDto para Brand
    //public static implicit operator Brand(BrandDto dto)
    //{
    //    return new Brand
    //    {
    //        Id = dto.Id,
    //        Code = dto.Code,
    //        Description = dto.Description
    //    };
    //}
    #endregion

    #region Conversion Methods
    // Converte a entidade atual em DTO
    //public BrandDto ToDto()
    //{
    //    return this;
    //}

    // Converte um DTO em entidade
    //public static Brand ToEntry(BrandDto dto)
    //{
    //    return dto;
    //}
    #endregion

}