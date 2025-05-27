using Domain.DTO.Base;
using Domain.DTO.Entity.Brand;
using Domain.DTO.Entity.Category;

namespace Domain.DTO.Entity.Product
{
    public class ProductDTO : BaseDTO
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

        #region Constructors
        public ProductDTO(string code, string description, decimal price, string image, string? observation, long brandId, long categoryId)
        {
            Code = code;
            Description = description;
            Image = image;
            Observation = observation;
            BrandId = brandId;
            CategoryId = categoryId;
        }
        public ProductDTO() { }
        #endregion

        #region Internal

        public virtual BrandDTO? BrandDTO { get; set; }
        public virtual CategoryDTO? CategoryDTO { get; set; }

        #endregion
    }
}