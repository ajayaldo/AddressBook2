using System.Collections.Generic;

namespace DataLayer.Repository
{
  public interface IAddressBookRepository
  {
    void AddAddress(AddressBook addressBook);
    IEnumerable<AddressBook> GetAllAddresses();
  }
}
