using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneygement
{
    public class Income
    {
        // instance variables
        private int _transactionId;
        private string _transactionName;
        private double _incomeAmount;
        private string _incomeType;

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
        public double IncomeAmount
        {
            get { return _incomeAmount; }
            set { _incomeAmount = value; }
        }
        public string IncomeType
        {
            get { return _incomeType; }
            set { _incomeType = value; }
        }

        // methods
        public void add_income()
        {
            // code here
        }
        public void delete_income()
        {
            // code here
        }
    }
}
