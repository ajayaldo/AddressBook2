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
      var addressBookEntity = new DataLayer.address_book
      {
        contact = addressBook.Contact,
        in_the_country = addressBook.InTheCountry,
        name = addressBook.Name
      };

      _repository.AddAddress(addressBookEntity);
    }

    public void UpdateAddress(AddressBookModel addressBook)
    {
      var addressBookEntity = new DataLayer.address_book
      {
        contact = addressBook.Contact,
        in_the_country = addressBook.InTheCountry,
        name = addressBook.Name,
        id = addressBook.Id,
        date_of_birth = addressBook.DateOfBirth
      };
      // _repository.UpdateAddress()
    }

    public IEnumerable<AddressBookModel> GetAllAddresses()
    {
      return _repository
        .GetAllAddresses()
        .Select(ab => new AddressBookModel
        {
          Id = ab.id,
          Contact = ab.contact,
          DateOfBirth = ab.date_of_birth,
          InTheCountry = ab.in_the_country,
          Name = ab.name
        });
    }
  }
}
