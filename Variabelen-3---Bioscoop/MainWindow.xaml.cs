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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Variabelen_3___Bioscoop
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Declaratie van variabelen.     
            short amountNormal;
            short amountReduction;
            short amountStudents;
            float total;
            const float PriceNormal = 9.10f;
            const float PriceReduction = 8.10f;
            const float PriceStudent = 6.90f;

            // Gegevens opvragen.     
            amountNormal = short.Parse(normalTextBox.Text);
            amountReduction = short.Parse(reductionTextBox.Text);
            amountStudents = short.Parse(studentTextBox.Text);

            // Ticketprijs berekenen.     
            total = (amountNormal * PriceNormal) +
                (amountReduction * PriceReduction) +
                (amountStudents * PriceStudent);

            // Afdrukken.      
            priceToPayTextBox.Text = total.ToString(); // Convert.ToString(totaal);
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            reductionTextBox.Text = "0";
            normalTextBox.Text = "0";
            studentTextBox.Text = "0";
            priceToPayTextBox.Text = string.Empty;
        }
    }
}
