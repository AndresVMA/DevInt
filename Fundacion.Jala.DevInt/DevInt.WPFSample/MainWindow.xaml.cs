using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace DevInt.WPFSample
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (var file = new StreamWriter("TextFile.txt"))
            {
                for (int i = 0; i < TextContent.LineCount; i++)
                {
                    var textLine = TextContent.GetLineText(i);
                    file.Write(textLine);
                }
            }
            //File.WriteAllText("TextContent.txt", TextContent.Text);
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                TextContent.Text = File.ReadAllText(openFileDialog.FileName);
                //dynamic json = JObject.Parse(TextContent.Text);
                //MessageBox.Show($"Root:{json.Root}");
                
            }
        }
    }
}
