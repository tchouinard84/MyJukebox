using Microsoft.Win32;
using MyJukebox.ViewModel;
using System.ComponentModel;
using System.Windows;

namespace MyJukebox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string InitialDirectory = @"C:\Users\tchouina\Music";
        private const string FileFilter = "MP3 Files (*.mp3)|*.mp3";

        private readonly MusicFileViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            viewModel = FindResource("ViewModel") as MusicFileViewModel;
        }

        private void OnClickOpen(object sender, RoutedEventArgs e)
        {
            var openDialog = new OpenFileDialog
            {
                Title = "Open a File",
                InitialDirectory = InitialDirectory,
                Filter = FileFilter
            };

            if (openDialog.ShowDialog() == false) { return; }

            //var file = openDialog.FileName;
            //viewModel.Open(file);
        }

    }

    public class User : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (_name == value) { return; }
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null) { return; }
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
