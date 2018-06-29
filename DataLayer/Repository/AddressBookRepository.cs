using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Repository
{
  public sealed class AddressBookRepository
    : IAddressBookRepository
  {
    private AddressBookDbEntities _context;
    public AddressBookRepository()
    {
      _context = new AddressBookDbEntities();
    }

    public void AddAddress(address_book entity)
    {
      using (_context)
      {
        _context.address_book.Add(entity);
        _context.SaveChanges();
      }
    }

    public void UpdateAddress(address_book entity)
    {
      var addressBook = _context.address_book.SingleOrDefault(a => a.id == entity.id);
      if (addressBook != null)
      {
        addressBook.contact = entity.contact;
        addressBook.date_of_birth = entity.date_of_birth;
        entity.in_the_country = entity.in_the_country;
        entity.name = entity.name;

        _context.SaveChanges();
      }
    }

    public IEnumerable<address_book> GetAllAddresses()
    {
      return _context.address_book.ToList();
    }
  }
}
