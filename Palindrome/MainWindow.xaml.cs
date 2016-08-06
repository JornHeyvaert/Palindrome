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

namespace Palindrome
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbHelp.Text = "A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward or forward";
        }

        private void btnExecute_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool canContinue = !string.IsNullOrEmpty(txtPalindrome.Text) && (rbWord.IsChecked == true || rbSentence.IsChecked == true);
                if (canContinue)
                {
                    bool result = (rbWord.IsChecked == true) ? PalindromeChecker.isWordAPalindrome(txtPalindrome.Text) : PalindromeChecker.isSentenceAPalindrome(txtPalindrome.Text);
                    tbResult.Text = result ? $"{txtPalindrome.Text} is a palindrome" : $"{txtPalindrome.Text} is not a palindrome";
                }
                else
                {
                    tbResult.Text = "Please input a word or sentence and select if it is a word or sentence!!!";
                }
            }
            catch (Exception)
            {
                tbResult.Text = "An error has occurred. Please try again!";
            }
        }
    }
}
