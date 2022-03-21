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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly List<string> source = new List<string>()
        {
            "111",
            "123",
            "234"
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AutoComplete_PatternChanged(object sender, AutoComplete.AutoCompleteArgs args)
        {
            //check
            if (string.IsNullOrEmpty(args.Pattern))
                args.CancelBinding = true;
            else
                args.DataSource = source.Where(s => s.Contains(args.Pattern)).ToList();
        }
    }
}
