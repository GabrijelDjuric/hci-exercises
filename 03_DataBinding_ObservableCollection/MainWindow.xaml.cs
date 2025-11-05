using _03_DataBinding_ObservableCollection.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _03_DataBinding_ObservableCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Book currentBook;

        public MainWindow()
        {
            InitializeComponent();

            currentBook = new Book
            {
                Title = "1984",
                Author = "George Orwell",
                Year = 1949,
                IsRead = false
            };

            this.DataContext = currentBook;
            // UpdateStatusText() više nije potreban!
        }

        private void MarkAsRead_Click(object sender, RoutedEventArgs e)
        {
            currentBook.IsRead = true;
            // UI se automatski ažurira! ✅
        }

        // UpdateStatusText() metod obrisan - više nije potreban
    }
}