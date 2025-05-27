using Infrastructure.Persistence.EFCore.Entity.Base;

namespace Infrastructure.Persistence.EFCore.Entity.Registration;

public class Product : BaseEntity
{
    #region Properties
    public string Code { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Image { get; set; }
    public string? Observation { get; set; }
    public long BrandId { get; set; }
    public long CategoryId { get; set; }

    #endregion

    #region Controllers
    public Product(string code, string description, decimal price, string image, string? observation, long brandId, long categoryId)
    {
        Code = code;
        Description = description;
        Price = price;
        Image = image;
        Observation = observation;
        BrandId = brandId;
        CategoryId = categoryId;
    }

    public Product() { }

    #endregion

    #region Implicit Operators
    // De Product para ProductDto
    //public static implicit operator ProductDto(Product product)
    //{
    //    return new ProductDto
    //    {
    //        Id = product.Id,
    //        Code = product.Code,
    //        Description = product.Description,
    //        Price = product.Price,
    //        Image = product.Image,
    //        Observation = product.Observation,
    //        BrandId = product.BrandId
    //    };
    //}

    //// De ProductDto para Product
    //public static implicit operator Product(ProductDto dto)
    //{
    //    return new Product
    //    {
    //        Id = dto.Id,
    //        Code = dto.Code,
    //        Description = dto.Description,
    //        Price = dto.Price,
    //        Image = dto.Image,
    //        Observation = dto.Observation,
    //        BrandId = dto.BrandId
    //    };
    //}
    #endregion

    #region Conversion Methods
    //public ProductDto ToDto()
    //{
    //    return this;
    //}

    //public static Product ToEntry(ProductDto dto)
    //{
    //    return dto;
    //}
    #endregion
}