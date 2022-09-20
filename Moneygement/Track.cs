using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneygement
{
    public class Track
    {
        // instance variables
        private int _transactionId;
        private string _transactionName;
        private double _expenseAmount;
        private string _expenseType;

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
        public double ExpenseAmount
        {
            get { return _expenseAmount; }
            set { _expenseAmount = value; }
        }
        public string ExpenseType
        {
            get { return _expenseType; }
            set { _expenseType = value; }
        }

        // methods
        public void view_expense()
        {
            // code here
        }
        public void view_income()
        {
            // code here
        }
        public void view_report()
        {
            // code here
        }
    }
}
