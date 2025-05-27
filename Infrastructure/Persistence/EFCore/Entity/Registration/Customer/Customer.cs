using Infrastructure.Persistence.EFCore.Entity.Base;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Persistence.EFCore.Entity.Registration;

public class Customer : BaseEntity
{
    #region Properties
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string Phone { get; set; }
    #endregion

    #region Controllers
    public Customer(string userName, string email, string address, string city, string region, string postalCode, string country, string phone)
    {
        UserName = userName;
        Email = email;
        Address = address;
        City = city;
        Region = region;
        PostalCode = postalCode;
        Country = country;
        Phone = phone;
    }

    public Customer() { }
    #endregion

    #region Implicit Operators
    // Conversão implícita de Customer para CustomerDto
    //public static implicit operator CustomerDto(Customer customer)
    //{
    //    return new CustomerDto
    //    {
    //        Id = customer.Id,
    //        UserName = customer.UserName,
    //        Email = customer.Email,
    //        Address = customer.Address,
    //        City = customer.City,
    //        Region = customer.Region,
    //        PostalCode = customer.PostalCode,
    //        Country = customer.Country,
    //        Phone = customer.Phone
    //    };
    //}

    // Conversão implícita de CustomerDto para Customer
    //public static implicit operator Customer(CustomerDto dto)
    //{
    //    return new Customer
    //    {
    //        Id = dto.Id,
    //        UserName = dto.UserName,
    //        Email = dto.Email,
    //        Address = dto.Address,
    //        City = dto.City,
    //        Region = dto.Region,
    //        PostalCode = dto.PostalCode,
    //        Country = dto.Country,
    //        Phone = dto.Phone
    //    };
    //}
    #endregion

    #region Conversion Methods
    // Converte a entidade atual em DTO
    //public CustomerDto ToDto()
    //{
    //    return this;
    //}

    // Converte um DTO em entidade
    //public static Customer ToEntry(CustomerDto dto)
    //{
    //    return dto;
    //}
    #endregion
}