using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Repository
{
  public sealed class AddressBookRepository
    : IAddressBookRepository
  {
    private AddressBookDBEntities _context;
    public AddressBookRepository()
    {
      _context = new AddressBookDBEntities();
    }

    public void AddAddress(AddressBook entity)
    {
      _context.AddressBooks.Add(entity);
      _context.SaveChanges();
    }

    public IEnumerable<AddressBook> GetAllAddresses()
    {
      return _context.AddressBooks.ToList();
    }
  }
}
