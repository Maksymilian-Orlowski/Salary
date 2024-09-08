using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Salary
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Empl
        {
            public string Name;
            public string Job;
            public int Age;
            public double Salary;

            public Empl(string name, string job, int age)
            {
                Name = name;
                Job = job;
                Age = age;
                CalculateSalary();
            }

            private void CalculateSalary()
            {
                switch (Job)
                {
                    case "Driver":
                        Salary = 6000 * 1.1 * Age;
                        break;
                    case "Mechanic":
                        Salary = 5000 * 1.1 * Age;
                        break;
                    case "CS":
                        Salary = 4000 * 1.1 * Age;
                        break;
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string name = EName.Text;
            string job = string.Empty;

            if (Driver.IsChecked == true)
            {
                job = "Driver";
            }
            else if (Mechanic.IsChecked == true)
            {
                job = "Mechanic";
            }
            else if (CS.IsChecked == true)
            {
                job = "CS";
            }

            int age = Convert.ToInt32(EAge.Text);

            Empl empl1 = new Empl(name, job, age);


            MessageBox.Show("Salary: " + empl1.Salary);
        }
    }
}
