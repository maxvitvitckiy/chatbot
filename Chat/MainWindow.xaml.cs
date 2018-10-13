using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Chat
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Answer ans;
        public MainWindow()
        {
            InitializeComponent();
            ans = new Answer();
        }

        private void ButtonA_Click(object sender, RoutedEventArgs e)
        {
            if (TextA.Text.Length > 0) AddTextA();
        }

        //private void ButtonB_Click(object sender, RoutedEventArgs e)
        //{
        //    if (TextB.Text.Length > 0) AddTextB();
        //}

        private void TextA_KeyDown(object sender, KeyEventArgs e)
        {
            if (TextA.Text.Length > 0 && e.Key == Key.Enter) AddTextA();
        }

        //private void TextB_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (TextB.Text.Length > 0 && e.Key == Key.Enter) AddTextB();

        //}

        void AddTextA()
        {
            TextBox textBoxA = new TextBox();
            textBoxA.Foreground = Brushes.Blue;
            textBoxA.FontSize = 36;
            textBoxA.Text += "A: " + TextA.Text + "\n";
            textBoxA.TextAlignment = TextAlignment.Left;
            StackChat.Children.Add(textBoxA);
            TextA.Text = "";
            MyScrollViewer.ScrollToBottom();
            Answer();
        }

        void Answer()
        {
            TextBox textBoxB = new TextBox();
            textBoxB.Foreground = Brushes.Red;
            textBoxB.FontSize = 36;

            textBoxB.Text += "B: " + ans.GetAnswer() + "\n";
            textBoxB.TextAlignment = TextAlignment.Right;
            StackChat.Children.Add(textBoxB);
            MyScrollViewer.ScrollToBottom();
        }

        //void AddTextB()
        //{
        //    ChatView.Text += "B: " + TextB.Text + "\n";
        //    TextB.Text = "";
        //    MyScrollViewer.ScrollToBottom();
        //}
    }
}
