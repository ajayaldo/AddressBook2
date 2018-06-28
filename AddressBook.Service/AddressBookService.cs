using DataLayer.Repository;
using System.Collections.Generic;
using DataLayer;
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

    public void AddAddress(AddressBook.Common.Models.AddressBookModel addressBook)
    {
      var addressBookEntity = new DataLayer.AddressBook
      {
        Contact = addressBook.Contact,
               In_The_Country = addressBook.In_The_Country,
        Name = addressBook.Name
      };

      _repository.AddAddress(addressBookEntity);
    }

    public IEnumerable<AddressBook.Common.Models.AddressBookModel> GetAllAddresses()
    {
      return _repository
        .GetAllAddresses()
        .Select(ab => new AddressBook.Common.Models.AddressBookModel
        {
          Contact = ab.Contact,
          DateOfBirth = ab.Date_Of_Birth,
          In_The_Country = ab.In_The_Country,
          Name = ab.Name
        });
    }
  }
}
