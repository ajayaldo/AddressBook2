namespace AddressBook.Common.Models
{
  public sealed class AddressBookModel
  {
    public long Id { get; set; }
    public string Name { get; set; }
    public System.DateTime DateOfBirth { get; set; }
    public long Contact { get; set; }
    public bool InTheCountry { get; set; }
  }
}
