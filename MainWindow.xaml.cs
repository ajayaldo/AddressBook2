using System.Windows;
using System.Threading.Tasks;
using System;

namespace AddressBook
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {

    public MainWindow()
    {
      InitializeComponent();
    }
    private void Add_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
      var proxy = new ServiceReference1.AddressBookServiceClient();
      var addressBook = new Common.Models.AddressBookModel()
      {
        Contact = 121211111,
        DateOfBirth = DateTime.Now.AddYears(-10),
        In_The_Country = true,
        Name = "Eman"
      };
      proxy.AddAddress(addressBook);
    }
  }
}
