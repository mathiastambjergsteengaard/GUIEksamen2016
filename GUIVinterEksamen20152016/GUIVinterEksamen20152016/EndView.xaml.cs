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

namespace GUIVinterEksamen20152016
{
    /// <summary>
    /// Interaction logic for EndView.xaml
    /// </summary>
    public partial class EndView : Window
    {
        public EndView(int points)
        {
            InitializeComponent();

            button.Content = "You got " + points + " Points\nPress here to continue";
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainWindow();
            window.Show();
            Close();
        }
    }
}
