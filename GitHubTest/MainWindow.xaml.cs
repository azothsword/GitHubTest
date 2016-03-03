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
using GitHubTest.TestClass;

namespace GitHubTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            delegateClass.AddActionEvent += new DelegateClass.AddActionEventHandler(DelegateClass_AddActionEvent);
            delegateClass.ShowActionEvent += new DelegateClass.ShowActionEventHandler((a, b) => MessageBox.Show((a + b).ToString()));
        }

        private int DelegateClass_AddActionEvent(int _num1, int _num2)
        {
            Console.WriteLine((_num1 - _num2).ToString());
            return 1;
        }

        DelegateClass delegateClass = new DelegateClass();

        private void AddActionButton_Click(object sender, RoutedEventArgs e)
        {
            delegateClass.AddAction();
        }

        private void ShowActionButton_Click(object sender, RoutedEventArgs e)
        {
            delegateClass.ShowAction();
        }
    }
}
