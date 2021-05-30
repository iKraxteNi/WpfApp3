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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> ListaStudentow { get; set; }


        public MainWindow()
        {
            ListaStudentow = new List<Student>();

            var student2 = new Student("Jan", "Kowalski", 1234, "KIS");

            student2.Oceny.Add(
                new COcena
                {
                    info = "testowe info",
                    ocena = 3
                });
            ListaStudentow.Add(student2);
        
            
    

            InitializeComponent();

            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Imię", Binding = new Binding("imie") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Nazwikso", Binding = new Binding("nazwisko") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "NR INdeksu", Binding = new Binding("NrIndeksu") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Wydział", Binding = new Binding("wydzial") });
            

            dgStudent.AutoGenerateColumns = false;
            dgStudent.ItemsSource = ListaStudentow;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ADD_Student_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new StudentWindow();
            if (dialog.ShowDialog() == true)
            {
                ListaStudentow.Add(dialog.student);
                dgStudent.Items.Refresh();
            }
        }

        private void R_Student_Click(object sender, RoutedEventArgs e)
        {
            if (dgStudent.SelectedItem is Student)
            {
                ListaStudentow.Remove((Student)dgStudent.SelectedItem);
                dgStudent.Items.Refresh();
            }
        }

        private void ADD_Oceny_Click(object sender, RoutedEventArgs e)
        {
            if (dgStudent.SelectedItem is Student selectedStudent)
            {
                var dialog = new AddOcenaWindow(selectedStudent);
                dialog.ShowDialog();

                dgStudent.Items.Refresh();
            }
        }

        private void Oceny_Student_Click(object sender, RoutedEventArgs e)
        {
            if (dgStudent.SelectedItem is Student selectedStudent)
            {
                var dialog = new OcenyWindow(selectedStudent);
                dialog.ShowDialog();

                dgStudent.Items.Refresh();
            }
        }
    }
}
