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

namespace solodkaya_lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent();
        }

        private void CreateDateButton_Click ( object sender, RoutedEventArgs e )
        {
            try
            {
                Date date = new Date(DateTextBox.Text);
                ResultTextBox.Text = $"Date created: {date.GetYear()}.{date.GetMonth()}.{date.GetDay()} \n" +
                                     $"Is leap year: {date.IsLeapYear()} \n";

                Date otherDate = new Date(2022, 12, 31);
                ResultTextBox.Text += $"Days between dates: {date.GetDaysBetween(otherDate)} \n";

                date.AddDays(10);
                ResultTextBox.Text += $"Date after adding 10 days: {date.GetYear()}.{date.GetMonth()}.{date.GetDay()} \n";

                date.SubtractDays(5);
                ResultTextBox.Text += $"Date after subtracting 5 days: {date.GetYear()}.{date.GetMonth()}.{date.GetDay()} \n";
            }
            catch (Exception ex)
            {
                ResultTextBox.Text = $"Error: {ex.Message}";
            }
        }
    }
}