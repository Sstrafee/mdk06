using PrQ.Directories;
//использование папки Directories
using PrQ.Pages;
//использование папки Pages
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Threading;

namespace PrQ
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        { 
            
            InitializeComponent();
            //Открывает Page2 в MeinFrame при запуске приложения
            MeinFrame.Navigate(new Page2());
            //Добавление нового таймера
            DispatcherTimer timer = new DispatcherTimer();
            //Интервал в 1 секунду
            timer.Interval = TimeSpan.FromSeconds(1);
            //Событие TimerTick
            timer.Tick += timer_Tick;
            //Запуск таймера
            timer.Start();
            
        }
        void timer_Tick(object sender, EventArgs e)
        {
            //Вывод таймера в Label
            Timers.Content = DateTime.Now.ToLongTimeString();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            //Выход из приложения
            Application.Current.Shutdown();
        }

        private void BtnSettings_Click(object sender, RoutedEventArgs e)
        {
            //переход на окно Window1 (Настройки)
            Window1 window = new Window1();
            window.Show();
        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {
            //Переход на окно Window2 (Информация)
            Window2 window = new Window2();
            window.Show();
        }

        private void BtnPage1_Click(object sender, RoutedEventArgs e)
        { 
            //Открывает Page1 (Страница 2) в Frame
            MeinFrame.Navigate(new Page1());
        }

        private void BtnPage2_Click(object sender, RoutedEventArgs e)
        {
            //Открывает Page2 (Страница 1) в Frame
            MeinFrame.Navigate(new Page2());
            
        }
    }
}
