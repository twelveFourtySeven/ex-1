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

namespace ex_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       Questions examQuestion;

        public MainWindow()
        {
            examQuestion.questionCount = 0;
            InitializeComponent(); 
            switch (examQuestion.questionCount)
            {
                case 0: examQuestion.Question = "Q1";
                    examQuestion.Answers = new string[] {"a1","a2","a3","a4" };
                    examQuestion.CorrectAnswer = "a3"; examQuestion.choiceShuffle();
                    radioButtonsFillUp(); questionLabel.Content = examQuestion.Question; break;
                case 1:
                    examQuestion.Question = "Q2";
                    examQuestion.Answers = new string[] { "a1", "a2", "a3", "a4" };
                    examQuestion.CorrectAnswer = "a1"; examQuestion.choiceShuffle();
                    radioButtonsFillUp(); questionLabel.Content = examQuestion.Question; break;
                case 2:
                    examQuestion.Question = "Q3";
                    examQuestion.Answers = new string[] { "a1", "a2", "a3", "a4" };
                    examQuestion.CorrectAnswer = "a1"; examQuestion.choiceShuffle();
                    radioButtonsFillUp(); questionLabel.Content = examQuestion.Question; break;
                case 3:
                    question1RadioButton.Visibility = Visibility.Hidden;
                    question2RadioButton.Visibility = Visibility.Hidden;
                    question3RadioButton.Visibility = Visibility.Hidden;
                    question4RadioButton.Visibility = Visibility.Hidden;
                    questionLabel.Visibility = Visibility.Hidden; break;

            }
            
        }


        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            examQuestion.questionCount++;
        }

        private void radioButtonsFillUp()
        {
            question1RadioButton.Content = examQuestion.Answers[0];
            question2RadioButton.Content = examQuestion.Answers[1];
            question3RadioButton.Content = examQuestion.Answers[2];
            question4RadioButton.Content = examQuestion.Answers[3];
        }
    }
}
