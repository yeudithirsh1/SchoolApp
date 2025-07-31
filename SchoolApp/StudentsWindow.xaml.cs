using BLL;
using ENTITES.Models;
using ENTITES;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace SchoolApp
{
    /// <summary>
    /// Interaction logic for StudentsWindow.xaml
    /// </summary>
    public partial class StudentsWindow : Window
    {
        public StudentsWindow()
        {
            InitializeComponent();
            DataContext = this;

            function bl = new function();
            allStudents = bl.LoadStudentsDetails();
            Students = allStudents;
            Class = bl.LoadClass();
            Class.Insert(0, "All Student");
        }
        public List<Student> Students { get; set; }
        public List<Student> allStudents { get; set; }
        public List<string> Class { get; set; }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedClass;
            ComboBox comboBox = sender as ComboBox;
            if (comboBox?.SelectedItem != null)
            {
                selectedClass = comboBox.SelectedItem.ToString();
                if (selectedClass != "All Student")
                    Students = allStudents.Where(s => s.Class == selectedClass).ToList();
                else
                    Students = allStudents;
                DataContext = null;
                DataContext = this;
            }
        }
    }

}
