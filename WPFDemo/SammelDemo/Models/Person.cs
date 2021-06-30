using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammelDemo.Models
{
    public class Person : INotifyPropertyChanged
    {
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set 
            { 
                _lastName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
            }
        }

        public string FirstName { get; set; }
        public int Age { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
