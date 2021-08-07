using System;
using System.Windows;
using System.Windows.Input;
using CryptID;

namespace Licensing
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_give_Click(object sender, RoutedEventArgs e)
        {
            try { textbox_key.Text = CryptUN.ToAUN(textbox_id.Text); }
            catch (Exception) { }
        }

        private void textbox_key_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            Clipboard.SetText(textbox_key.Text);
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            textbox_id.Clear();
            textbox_key.Clear();
        }
    }
}
