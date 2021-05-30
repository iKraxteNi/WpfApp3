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
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for OcenyWindow.xaml
    /// </summary>
    public partial class OcenyWindow : Window
    {
        
        public List<COcena> OC { get; set; }

        public OcenyWindow(Student student)

        {
            OC = new List<COcena>();
            OC = student.Oceny;
           
           
            InitializeComponent();
            DGOcena.Columns.Add(new DataGridTextColumn() { Header = "info", Binding = new Binding("info") });
            DGOcena.Columns.Add(new DataGridTextColumn() { Header = "ocena", Binding = new Binding("ocena") });
            DGOcena.AutoGenerateColumns = false;
            DGOcena.ItemsSource = OC;
        }

        private void btDO_Click(object sender, RoutedEventArgs e)
        {
            if (DGOcena.SelectedItem is COcena)
            {
                OC.Remove((COcena)DGOcena.SelectedItem);
                DGOcena.Items.Refresh();
            }
        }
    }
}
