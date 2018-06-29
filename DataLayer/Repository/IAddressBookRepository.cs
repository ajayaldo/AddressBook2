using System.Collections.Generic;

namespace DataLayer.Repository
{
  public interface IAddressBookRepository
  {
    void AddAddress(address_book addressBook);
    IEnumerable<address_book> GetAllAddresses();
    void UpdateAddress(address_book entity);
  }
}
