using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneygement
{
    public class Expense
    {
        // instance variables
        protected int _transactionId;
        protected string _transactionName;
        protected double _amount;
        protected string _type;

        // properties
        public int TransactionId
        {
            get { return _transactionId; }
        }
        public string TransactionName
        {
            get { return _transactionName; }
            set { _transactionName = value; }
        }
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        // methods
        public virtual void add_item()
        {
            // code here
        }
        public virtual void delete_item()
        {
            // code here
        }
    }
}
