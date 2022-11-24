using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp8.Classes
{
    public class User : INotifyPropertyChanged
    {
        private string _username;
        private string _status;
        private DateTime _lastLogin;
        public string Username 
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                NotifyPropertyChanged();
            }
        }
        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                NotifyPropertyChanged();
            }
        }
        public DateTime LastLogin
        {
            get
            {
                return _lastLogin;
            }
            set
            {
                _lastLogin = value;
                NotifyPropertyChanged();
            }
        }

        public User(string username, string status, DateTime lastLogin)
        {
            Username = username;
            Status = status;
            LastLogin = lastLogin;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
