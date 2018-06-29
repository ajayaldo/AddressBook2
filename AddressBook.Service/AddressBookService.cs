using DataLayer.Repository;
using System.Collections.Generic;
using AddressBook.Common.Models;
using System.Linq;

namespace AddressBookService
{
  public class AddressBookService
    : IAddressBookService
  {
    private readonly IAddressBookRepository _repository;
    AddressBookService()
    {
      _repository = new AddressBookRepository();
    }

    public void AddAddress(AddressBookModel addressBook)
    {
      var addressBookEntity = new DataLayer.AddressBook
      {
        Contact = addressBook.Contact,
               In_The_Country = addressBook.InTheCountry,
        Name = addressBook.Name
      };

      _repository.AddAddress(addressBookEntity);
    }

    public void UpdateAddress(AddressBookModel addressBook)
    {
      var addressBook = new DataLayer.AddressBook
      {

      }
    }

    public IEnumerable<AddressBookModel> GetAllAddresses()
    {
      return _repository
        .GetAllAddresses()
        .Select(ab => new AddressBook.Common.Models.AddressBookModel
        {
          Contact = ab.Contact,
          DateOfBirth = ab.Date_Of_Birth,
          InTheCountry = ab.In_The_Country,
          Name = ab.Name
        });
    }
  }
}
