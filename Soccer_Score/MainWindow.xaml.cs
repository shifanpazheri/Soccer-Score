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

namespace Soccer_Score
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Soccer>matches = new List<Soccer>();
            matches.Add(new Soccer("Ger", "Bra", 7, 0, 80));
            matches.Add(new Soccer("Fra", "Ita", 0, 1, 40));
            matches.Add(new Soccer("Esp", "Arg", 1, 1, 90));
            matches.Add(new Soccer("Urg", "Aus", 2, 2, 20));
            IbMatches.ItemsSource = matches;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(IbMatches.SelectedItem != null)
            {
                MessageBox.Show("Match is between "+(IbMatches.SelectedItem as Soccer).Team1 +" "+
                    "and " + (IbMatches.SelectedItem as Soccer).Team2 + " " +
                    "Scores are " + (IbMatches.SelectedItem as Soccer).Score1 + " " +
                    "-" + (IbMatches.SelectedItem as Soccer).Score2 + " " +
                    " Time Now " + (IbMatches.SelectedItem as Soccer).Completion + " " );
            }
        }
    }
}
