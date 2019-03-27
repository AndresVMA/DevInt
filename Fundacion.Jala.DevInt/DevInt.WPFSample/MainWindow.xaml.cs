using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows;

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
            //using (var file = new StreamWriter("TextFile.txt"))
            //{
            //    for (int i = 0; i < TextContent.LineCount; i++)
            //    {
            //        var textLine = TextContent.GetLineText(i);
            //        file.Write(textLine);
            //    }
            //}
            File.WriteAllText("TextContent.txt", TextContent.Text);
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                TextContent.Text = File.ReadAllText(openFileDialog.FileName);
                var rootJObject = JObject.Parse(TextContent.Text);
                Root json = rootJObject.First.First.ToObject<Root>();
                MessageBox.Show(json.Name);
                //dynamic json = JObject.Parse(TextContent.Text);
                //MessageBox.Show($"{json.Root.Name}");

            }

        }
        public dynamic GetAnonymousType()
        {
            var myType = new
            {
                Root =  "value",
                Name = 12.5m
            };

            return myType;
        }

        public void Consume()
        {
            var myObj = GetAnonymousType();
            dynamic name = myObj.Name;
            Console.WriteLine(name); 
        }
    }
}
