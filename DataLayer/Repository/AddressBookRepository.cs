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

    public void UpdateAddress(AddressBook entity)
    {
      var addressBook = _context.AddressBooks.SingleOrDefault(a => a.Id == entity.Id);
      if (addressBook != null)
      {
        addressBook.Contact = entity.Contact;
        addressBook.Date_Of_Birth = entity.Date_Of_Birth;
        entity.In_The_Country = entity.In_The_Country;
        entity.Name = entity.Name;

        _context.SaveChanges();
      }
    }

    public IEnumerable<AddressBook> GetAllAddresses()
    {
      return _context.AddressBooks.ToList();
    }
  }
}
