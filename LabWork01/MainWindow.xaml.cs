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

namespace LabWork01
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

        private void ButtonMen_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Муржской отдел");
        }

        private void ButtonWomen_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Женский отдел");
        }

        private void ButtonChild_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Детский отдел");
        }

        private void ButtonSport_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Отдел спортивного снаряжения");
        }

        private void ButtonForget_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Аккаунт удален");
        }

        private void ButtonNewAccount_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Новый аккаунт создан");
        }
    }
}
