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
using System.Windows.Media.Animation;

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
            DoubleAnimation animation = new DoubleAnimation();
            DoubleAnimation animation2 = new DoubleAnimation();
            DoubleAnimation animation3 = new DoubleAnimation();
            animation.From = 0;
            animation.To = 200;
            animation.Duration = TimeSpan.FromSeconds(5);
            ButtonMen.BeginAnimation(Button.WidthProperty, animation);
            ButtonWomen.BeginAnimation(Button.WidthProperty, animation);
            ButtonChild.BeginAnimation(Button.WidthProperty, animation);
            ButtonSport.BeginAnimation(Button.WidthProperty, animation);
            animation2.From = 110;
            animation2.To = 200;
            animation2.Duration = TimeSpan.FromSeconds(2);
            animation2.AutoReverse = true;
            animation2.RepeatBehavior = RepeatBehavior.Forever;
            animation3.From = 200;
            animation3.To = 110;
            animation3.Duration = TimeSpan.FromSeconds(2);
            animation3.AutoReverse = true;
            animation3.RepeatBehavior = RepeatBehavior.Forever;
            ButtonForget.BeginAnimation(Button.WidthProperty, animation2);
            ButtonNewAccount.BeginAnimation(Button.WidthProperty, animation3);
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
