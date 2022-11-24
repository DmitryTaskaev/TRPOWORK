using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_26_10.Classes
{
    public class User : INotifyPropertyChanged
    {
        private string username;
        private string status;
        private DateTime lastLogin;
        public string Username {
            get
            {
                return username;
            }
            set
            {
                username = value;
                NotifyPropertyChanged();
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
                NotifyPropertyChanged();
            }
        }
        public DateTime LastLogin 
        { 
            get {
                return lastLogin;
            }
            set
            {
                lastLogin = value;
                NotifyPropertyChanged();
            }
        }

        public User(string username, string status, DateTime LastLogin)
        {
            Username = username;
            Status = status;
            LastLogin = lastLogin;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
