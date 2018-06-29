using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Repository
{
  public sealed class AddressBookRepository
    : IAddressBookRepository
  {
    public void AddAddress(address_book entity)
    {
      using (var context = new AddressBookDbEntities())
      {
        context.address_book.Add(entity);
        context.SaveChanges();
      }
    }

    public void UpdateAddress(address_book entity)
    {
      using (var context = new AddressBookDbEntities())
      {
        var addressBook = context.address_book.SingleOrDefault(a => a.id == entity.id);
        if (addressBook != null)
        {
          addressBook.contact = entity.contact;
          addressBook.date_of_birth = entity.date_of_birth;
          addressBook.in_the_country = entity.in_the_country;
          addressBook.name = entity.name;

          context.SaveChanges();
        }
      }
    }

    public IEnumerable<address_book> GetAllAddresses()
    {
      using (var context = new AddressBookDbEntities())
      {
        return context.address_book.ToList();
      }
    }
  }
}
