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

namespace Class2
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

        private void Addbtb_Click(object sender, RoutedEventArgs e)
        {
            string id, firstname, lastname, probabtion, gpa, bursar;

            id = IDbox.Text;
            firstname = FBox.Text;
            lastname = LBox.Text;
            probabtion = ProbBox.Text;
            gpa = GPAbox.Text;
            bursar = BurBox.Text;

            Student stud = new Student(Convert.ToInt32(id), firstname, lastname, Convert.ToDouble(bursar));
            stud.GPA = Convert.ToDouble(gpa);

            if (probabtion.ToLower()=="yes")
            {
                stud.IsOnProbation = true;
            }
            else
            {
                stud.IsOnProbation = false;


            }
            lstStud.Items.Add(stud);
        }

        private void lstStud_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student selected = (Student) lstStud.SelectedItem;// () casting 
            MessageBox.Show($"{ selected.ToString()} has a Bursar Balance of {selected.CheckBalance().ToString("C")}");
        }
    }
}
