using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Quotation_Tool
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Initialization

        public MainWindowViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }

        #endregion

        private string customerName;
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                if (value != customerName)
                {
                    customerName = value;
                    OnPropertyChange(nameof(CustomerName));
                }
            }
        }

        private string customerCell;
        public string CustomerCell
        {
            get { return customerCell; }
            set
            {
                if (value != customerCell)
                {
                    customerCell = value;
                    OnPropertyChange(nameof(CustomerCell));
                }
            }
        }

        private string customerEmail;
        public string CustomerEmail
        {
            get { return customerEmail; }
            set
            {
                if (value != customerEmail)
                {
                    customerEmail = value;
                    OnPropertyChange(nameof(CustomerEmail));
                }
            }
        }

        private string customerEmail;
        public string CustomerEmail
        {
            get { return customerEmail; }
            set
            {
                if (value != customerEmail)
                {
                    customerEmail = value;
                    OnPropertyChange(nameof(CustomerEmail));
                }
            }
        }
    }
}
