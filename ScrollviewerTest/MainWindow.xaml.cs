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

namespace ScrollviewerTest
{
    using System.Collections.ObjectModel;

    using Prism.Mvvm;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel vm;

        public MainWindow()
        {
            InitializeComponent();
            vm = new ViewModel();
            DataContext = vm;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var insert = i.ToString();
                vm.Presets.Add(insert);
                
            }
        }
    }

    public class ViewModel : BindableBase
    {
        private ObservableCollection<string> presets = new ObservableCollection<string>();

        public ObservableCollection<string> Presets
        {
            get { return presets; }

            set { SetProperty(ref presets, value); }
        }
    }
}
