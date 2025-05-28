using Arguments.Argument.Base.Crud;
using System.ComponentModel.DataAnnotations;

namespace Arguments.Argument.Registration.Product
{
    public class InputCreateProduct(string code, string description, decimal price, string image, string observation, long brandId, long categoryId) : BaseInputCreate<InputCreateProduct>
    {
        [Required(ErrorMessage = "Campo {0} é Obrigatório")]
        public string Code { get; private set; } = code;
        public string Description { get; private set; } = description;
        public decimal Price { get; private set; } = price;
        public string Image { get; private set; } = image;
        public string? Observation { get; private set; } = observation;
        public long BrandId { get; private set; } = brandId;
        public long CategoryId { get; private set; } = categoryId;
    }
}