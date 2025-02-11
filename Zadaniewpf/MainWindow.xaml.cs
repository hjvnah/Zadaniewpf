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

namespace Zadaniewpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 




    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string GenerujHaslo ( int dlugosc, bool czyWielkieLitery, bool czyCyfry, bool czySpecjalne)
        {
            char[] haslo = new char[dlugosc];
            Random random = new Random();
            string maleLitery = "abcdefghijklmnopqrstuvwxyz";
            string wielkielitery = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cyfry = "1234567890";
            string znakiSpecjalne = "!@#$%^&*()_+-=";

            for (int i = 0; i < dlugosc; i++)
            {
                haslo[i] = maleLitery[random.Next(maleLitery.Length)];
            }
        }


    }


}