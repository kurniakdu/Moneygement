using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneygement
{
    public class Income: Expense
    {
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
        public override void add_item()
        {
            // code here
        }
        public override void delete_item()
        {
            // code here
        }
    }
}
