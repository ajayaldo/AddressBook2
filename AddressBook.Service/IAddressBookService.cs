using System.Collections.Generic;
using System.ServiceModel;
using AddressBook.Common.Models;

namespace AddressBookService
{
  [ServiceContract]
  public interface IAddressBookService
  {
    [OperationContract]
    IEnumerable<AddressBookModel> GetAllAddresses();

    [OperationContract]
    void AddAddress(AddressBookModel addressBook);

    [OperationContract]
    void UpdateAddress(AddressBookModel addressBook);
  }
}
