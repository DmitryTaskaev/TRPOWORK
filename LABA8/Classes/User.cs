using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_26_10.Classes
{
    class User:INotifyPropertyChanged
    {
        private string username;
        private string status;
        public string Username {
            get
            {
                return username;
            }
            set
            {
                username = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Username"));
                }
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
                if (PropertyChanged!= null)
                {
                    NotifyPropertyChanged("Status");
                }
            }
        }
        public DateTime LastLogin { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
