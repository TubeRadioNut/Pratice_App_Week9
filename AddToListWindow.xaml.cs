using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pratice_App_Week9
{
    /// <summary>
    /// Interaction logic for AddToListWindow.xaml
    /// </summary>
    public partial class AddToListWindow : Window
    {
        public AddToListWindow()
        {
            InitializeComponent();

            lvBooks.ItemsSource = Data.Books;
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            
            Data.AddBook(title, author);
        }
    }
}
