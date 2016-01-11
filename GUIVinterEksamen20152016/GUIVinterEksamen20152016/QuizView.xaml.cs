﻿using System;
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
        public QuizView(Quiz quiz)
        {
            InitializeComponent();

            quizMaster.NewQuestion(currentQuestion,quiz[0]);

            DataContext = currentQuestion;
        }

        

        CurrentQuestion currentQuestion = new CurrentQuestion();

        QuizMaster quizMaster = new QuizMaster();

        public class CurrentQuestion : QuestionAnswer
        {

        }
    }
}