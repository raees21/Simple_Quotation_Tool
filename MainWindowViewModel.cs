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

        #region Variables

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

        private string customerAddress1;
        public string CustomerAddress1
        {
            get { return customerAddress1; }
            set
            {
                if (value != customerAddress1)
                {
                    customerAddress1 = value;
                    OnPropertyChange(nameof(CustomerAddress1));
                }
            }
        }

        private string customerAddress2;
        public string CustomerAddress2
        {
            get { return customerAddress2; }
            set
            {
                if (value != customerAddress2)
                {
                    customerAddress2 = value;
                    OnPropertyChange(nameof(CustomerAddress2));
                }
            }
        }

        private string customerAddress3;
        public string CustomerAddress3
        {
            get { return customerAddress3; }
            set
            {
                if (value != customerAddress3)
                {
                    customerAddress3 = value;
                    OnPropertyChange(nameof(CustomerAddress3));
                }
            }
        }

        private string postalCode;
        public string PostalCode
        {
            get { return postalCode; }
            set
            {
                if (value != postalCode)
                {
                    postalCode = value;
                    OnPropertyChange(nameof(PostalCode));
                }
            }
        }

        private string city;
        public string City
        {
            get { return city; }
            set
            {
                if (value != city)
                {
                    city = value;
                    OnPropertyChange(nameof(City));
                }
            }
        }

        private string notes;
        public string Notes
        {
            get { return notes; }
            set
            {
                if (value != notes)
                {
                    notes = value;
                    OnPropertyChange(nameof(Notes));
                }
            }
        }

        private string quoteNo;
        public string QuoteNo
        {
            get { return quoteNo; }
            set
            {
                if (value != quoteNo)
                {
                    quoteNo = value;
                    OnPropertyChange(nameof(QuoteNo));
                }
            }
        }

        private bool type;
        public bool Type
        {
            get { return type; }
            set
            {
                if (value != type)
                {
                    type = value;
                    OnPropertyChange(nameof(Type));
                }
            }
        }

        #endregion
    }
}
