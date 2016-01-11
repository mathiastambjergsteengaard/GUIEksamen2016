using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for QuizView.xaml
    /// </summary>
    public partial class QuizView : Window
    {
        public QuizView(Quiz quiz1)
        {
            InitializeComponent();

            quiz = quiz1;
            quizMaster.NewQuestion(currentQuestion,quiz[0]);

            DataContext = currentQuestion;

            PointLabel.DataContext = data;
        }

        
        Quiz quiz = new Quiz();

        QuizView.CurrentQuestion currentQuestion = new CurrentQuestion();

        QuizMaster quizMaster = new QuizMaster();

        public class CurrentQuestion : QuestionAnswer
        {
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var window = new MainWindow();
            window.Show();
            Close();
        }

        private void ABtn_Click(object sender, RoutedEventArgs e)
        {
            int point = quizMaster.HandleAnswer(currentQuestion, "A");
            Points += point;
            if(point == 4 || point == 0)
            {
                quizMaster.localCounter = 0;
                if (quizMaster.Counter != quiz.Count-1)
                {
                    quizMaster.NewQuestion(currentQuestion, quiz[++quizMaster.Counter]);
                }
                else
                {
                    var window = new EndView(Points);
                    //window.WindowState = WindowState.Maximized;
                    window.Show();
                    Close();
                }
            }
        }

        private void BBtn_Click(object sender, RoutedEventArgs e)
        {
            
            int point = quizMaster.HandleAnswer(currentQuestion, "B");
            Points += point;
            if (point == 4 || point == 0)
            {
                quizMaster.localCounter = 0;
                if (quizMaster.Counter != quiz.Count-1)
                {
                    quizMaster.NewQuestion(currentQuestion, quiz[++quizMaster.Counter]);
                }
                else
                {
                    var window = new EndView(Points);
                    //window.WindowState = WindowState.Maximized;
                    window.Show();
                    Close();
                }
            }
        }

        private void CBtn_Click(object sender, RoutedEventArgs e)
        {
            int point = quizMaster.HandleAnswer(currentQuestion, "C");
            Points += point;
            if (point == 4 || point == 0)
            {
                quizMaster.localCounter = 0;
                if (quizMaster.Counter != quiz.Count-1)
                {
                    quizMaster.NewQuestion(currentQuestion, quiz[++quizMaster.Counter]);
                }
                else
                {
                    var window = new EndView(Points);
                    //window.WindowState = WindowState.Maximized;
                    window.Show();
                    Close();
                }
            }
        }

        private void DBtn_Click(object sender, RoutedEventArgs e)
        {
            int point = quizMaster.HandleAnswer(currentQuestion, "D");
            Points += point;
            if (point == 4 || point == 0)
            {
                quizMaster.localCounter = 0;
                if (quizMaster.Counter != quiz.Count-1)
                {
                    quizMaster.NewQuestion(currentQuestion, quiz[++quizMaster.Counter]);
                    
                }
                else
                {
                    var window = new EndView(Points);
                    //window.WindowState = WindowState.Maximized;
                    window.Show();
                    Close();
                }
            }
        }

        class Data : INotifyPropertyChanged
        {
            int _points;
            public int Points
            {
                get { return _points; }
                set { _points = value; Notify("Points"); }
            }

            // INotifyPropertyChanged Members
            public event PropertyChangedEventHandler PropertyChanged;
            void Notify(string prop) { if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); } }
        }

        Data data = new Data();

        public int Points
        {
            get { return data.Points; }
            set { data.Points = value; }
        }
    }
}
