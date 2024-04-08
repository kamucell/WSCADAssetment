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

namespace WSCADWpf
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Canvas canvas = new Canvas();
            canvas.Width = 600;
            canvas.Height = 600;
            this.Content = canvas;

            var rd = AppDataReader.DataReaderFactory.CreateDataReader(AppDataReader.DataReaderFactory.DataReaderType.JSONReader);
            var sourceObj = rd.Read(System.IO.Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName) +@"\ContentData.json");

            var dtoObj = new AppDTO.ConvertFromShape();
            var drawObj = dtoObj.ConvertTo((List<AppDataReader.JSONStrcuture.JSONStructure>)sourceObj);

            foreach (var item in drawObj)
            {
                item.Draw((Canvas)this.Content);
            }

        }
    }
}
