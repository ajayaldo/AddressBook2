using System.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using AddressBook.Common.Models;

namespace AddressBook
{
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
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
  }
}
