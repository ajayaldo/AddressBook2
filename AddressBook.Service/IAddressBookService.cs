using System.Collections.Generic;
using System.ServiceModel;

namespace AddressBookService
{
  [ServiceContract]
  public interface IAddressBookService
  {
    [OperationContract]
    IEnumerable<AddressBook.Common.Models.AddressBookModel> GetAllAddresses();

    [OperationContract]
    void AddAddress(AddressBook.Common.Models.AddressBookModel addressBook);
  }
}
