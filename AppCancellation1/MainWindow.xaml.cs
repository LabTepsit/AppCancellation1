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

namespace AppCancellation1
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            int max = Convert.ToInt32(txtMax.Text);
            int delay = Convert.ToInt32(txtdelay.Text);
            Task.Factory.StartNew(()=>DoWork(max, delay,lblCount));
        }

        //private void DoWork(int max, int delay)
        //{
        //    for (int i = 0; i < max; i++)
        //    {
        //        Thread.Sleep(delay);
        //        Dispatcher.Invoke(() => UpdateUI(i));

        //    }
        //}

        private void DoWork(int max, int delay, Label lbl)
        {
            for (int i = 0; i < max; i++)
            {
                Thread.Sleep(delay);
                Dispatcher.Invoke(() => UpdateUI(i,lbl));

            }
        }

        //private void UpdateUI(int i)
        //{
        //    lblCount.Content = i;
        //}

    private void UpdateUI(int i,Label lbl)
    {
        lbl.Content = i;
    }

    private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            int max = Convert.ToInt32(txtMax1.Text);
            Task.Factory.StartNew(()=>DoWork(max, 1000, lblCount1));
        }
    }
}
