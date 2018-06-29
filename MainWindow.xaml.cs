using System.Windows;
using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using AddressBook.Common.Models;
using AddressBook.AddressBookServiceReference;

namespace AddressBook
{
  public partial class MainWindow : Window
  {
    private AddressBookServiceClient _serviceReference;

    public MainWindow()
    {
      InitializeComponent();
      _serviceReference = new AddressBookServiceClient();
      PopulateGrid();
    }

    private void PopulateGrid()
    {
      var addressBooks = _serviceReference.GetAllAddresses();
      var obsAddressBooks = new ObservableCollection<AddressBookModel>(addressBooks);
      dgAB.ItemsSource = obsAddressBooks;
    }

    private void dgAB_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
    {
      var dataContext = e.Row.DataContext as AddressBookModel;
      var f = dataContext;
      _serviceReference.UpdateAddress(f);
    }

    private void Add_Click(object sender, RoutedEventArgs e)
    {
      var addressBook = new AddressBookModel()
      {
        Contact = 999999999,
        DateOfBirth = DateTime.Now.AddYears(-10),
        InTheCountry = true,
        Name = "Eman"
      };

      _serviceReference.AddAddress(addressBook);
      PopulateGrid();
    }
  }
}
