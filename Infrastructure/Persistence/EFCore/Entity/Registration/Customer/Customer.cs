using Infrastructure.Persistence.EFCore.Entity.Base;

namespace Infrastructure.Persistence.EFCore.Entity.Registration;

public class Customer : BaseEntity
{
    #region Properties
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Code { get; private set; }
    public string Phone { get; private set; }
    public DateOnly? BirthDate { get; private set; }
    public string Document { get; private set; }
    #endregion

    #region Controllers
    public Customer(string firstName, string lastName, string code, string phone, DateOnly? birthDate, string document)
    {
        FirstName = firstName;
        LastName = lastName;
        Code = code;
        Phone = phone;
        BirthDate = birthDate;
        Document = document;
    }

    public Customer() { }
    #endregion

    #region Implicit Operators

    #endregion

    #region Conversion Methods

    #endregion
}