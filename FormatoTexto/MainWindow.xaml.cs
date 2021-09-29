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

namespace FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextoMostradoTextBlock.Text = TextoEscritoTextBox.Text;
        }

        private void NegritaCheck_Checked(object sender, RoutedEventArgs e)
        {
            if (NegritaCheck.IsChecked == true)
                TextoMostradoTextBlock.FontWeight = FontWeights.Bold;

        }
        private void NegritaCheck_UnChecked(object sender, RoutedEventArgs e)
        {
            TextoMostradoTextBlock.FontWeight = FontWeights.Normal;
        }

        private void CursivaCheck_Checked(object sender, RoutedEventArgs e)
        {
            if (CursivaCheck.IsChecked == true)
                TextoMostradoTextBlock.FontStyle = FontStyles.Italic;
        }

        private void CursivaCheck_UnChecked(object sender, RoutedEventArgs e)
        {
            TextoMostradoTextBlock.FontStyle = FontStyles.Normal;
        }
        private void RojoRadio_Checked(object sender, RoutedEventArgs e)
        {
            TextoMostradoTextBlock.Foreground = Brushes.Red;
        }

        private void VerdeRadio_Checked(object sender, RoutedEventArgs e)
        {
            TextoMostradoTextBlock.Foreground = Brushes.Green;
        }

        private void AzulRadio_Checked(object sender, RoutedEventArgs e)
        {
            TextoMostradoTextBlock.Foreground = Brushes.Blue;
        }
    }
}
