using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Model
{
    public class StudentModel
    {
    }

    public class Student : INotifyPropertyChanged
    {
        private string firstname;
        private string surname;

        public string Firstname
        {
            get { 
                return firstname; }
            set {
                if(firstname != value)
                {
                    firstname = value;
                    RaisePropertyChanged("Firstname");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (surname != value)
                {
                    surname = value;
                    RaisePropertyChanged("Surname");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        public string FullName
        {
            get
            {
                return firstname + " " + surname;
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
