using System.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using AddressBook.Common.Models;
using AddressBook.ServiceReference2;

namespace AddressBook
{
  public partial class MainWindow : Window
  {
    private AddressBookServiceClient _serviceReference;

    public MainWindow()
    {
      InitializeComponent();
      _serviceReference = new AddressBookServiceClient();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      PopulateGrid();
    }

    private void PopulateGrid()
    {
      var list = new List<AddressBookModel>();
      var addressBook = new AddressBookModel()
      {
        Id = 2242442424,
        Contact = 999999999,
        DateOfBirth = DateTime.Now.AddYears(-10),
        InTheCountry = true,
        Name = "Eman"
      };

      list.Add(addressBook);

      var obs = new ObservableCollection<AddressBookModel>(list);
      dgAB.ItemsSource = list;
    }

    private void dgAB_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
    {
      var dataContext = e.Row.DataContext as AddressBookModel;
      var f = dataContext;
    }

    private void Add_Click(object sender, RoutedEventArgs e)
    {

      var addressBook = new AddressBookModel()
      {
        Id = 2242442424,
        Contact = 999999999,
        DateOfBirth = DateTime.Now.AddYears(-10),
        InTheCountry = true,
        Name = "Eman"
      };
      _serviceReference.AddAddress(addressBook);
    }

  }
}
