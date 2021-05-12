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

namespace CardPickerWPF
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string[] pickedCards = CardPicker.PickSomeCards((int)numberOfCards.Value);

            listOfCards.Items.Clear();

            foreach(string card in pickedCards)
            {
                listOfCards.Items.Add(card);
            }

        }

        private void numberOfCards_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            currentNumberBox.Text = numberOfCards.Value.ToString("0");
        }
    }
}
