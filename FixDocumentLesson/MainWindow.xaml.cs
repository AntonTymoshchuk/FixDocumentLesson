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

namespace FixDocumentLesson
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //PageContent pageContent1 = new PageContent();
            //PageContent pageContent2 = new PageContent();
            //var r = new FixedPage();
            //r.Children.Add(new TextBox() { Text = "aaaa" });
            //pageContent1.Child = r;

            //fixedDocument.Pages.Add(pageContent1);
            ////fixedDocument.Pages.Add(pageContent2);
        }
    }
}
