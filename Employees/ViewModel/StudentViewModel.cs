using Employees.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.ViewModel
{
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students
        {
            get;
            set;
        }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            students.Add(new Student { Firstname = "Tom", Surname = "Lewis" });
            students.Add(new Student { Firstname = "Sarah", Surname = "Williams" });
            students.Add(new Student { Firstname = "James", Surname = "Taylor" });

            Students = students;
        }
    }
}
