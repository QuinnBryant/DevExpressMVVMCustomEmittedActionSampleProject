using System.Collections.ObjectModel;
using System.Windows;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.PropertyGrid;
using PropertyGridSample.ViewModels;

namespace PropertyGridSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = ViewModelSource.Create<ApplicationViewModel>(() => new ApplicationViewModel());
        }
    }
}