using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneygement
{
    public class Transaction
    {
        // instance variables
        private int _transactionId;
        private string _name;
        private DateTime _date;
        private string _category;

        // properties
        public int TransactionId
        {
            get { return _transactionId; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        // methods
        public void edit_transaction()
        {
            // code here
        }
    }
}
