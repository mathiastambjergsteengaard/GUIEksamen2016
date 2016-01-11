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

namespace GUIVinterEksamen20152016
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
            var choosedialog = new ChooseFileDialog();
            choosedialog.Owner = this;
            choosedialog.Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            var json = new FileDeserializer();
            var quiz = new Quiz();
            quiz = json.Deserialize(Properties.Settings.Default.FilePath);
            var quizview = new QuizView(quiz);
            quizview.Width = Width;
            quizview.Height = Height;
            Close();
            quizview.Show();
        }
    }
}
