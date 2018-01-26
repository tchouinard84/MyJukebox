using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyJukebox
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

        private void OnCanExecuteOpen(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OnCanExecutePlay(object sender, CanExecuteRoutedEventArgs e)
        {
            //e.CanExecute = 
        }

        private void OnCanExecutePause(object sender, CanExecuteRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnCanExecuteStop(object sender, CanExecuteRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnExecutedOpen(object sender, ExecutedRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnExecutedPlay(object sender, ExecutedRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnExecutedPause(object sender, ExecutedRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnExecutedStop(object sender, ExecutedRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
