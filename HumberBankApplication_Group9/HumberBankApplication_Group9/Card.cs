using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumberBankApplication_Group9
{
    class Card
    {
        private int cardNumber;
        private int cardHolderID;
        private double limit;
        private double spent;
        private DateTime issueDate;
        private DateTime expiryDate;
        private int cvv;

        public int CardNumber { get { return this.cardNumber; } set { this.cardNumber = value; } }
        public int CardHolderID { get { return this.cardHolderID; } set { this.cardHolderID = value; } }
        public double Limit { get { return this.limit; } set { this.limit = value; } }
        public double Spent { get { return this.spent; } set { this.spent = value; } }
        public DateTime IssueDate { get { return this.issueDate; } set { this.issueDate = value; } }
        public DateTime ExpiryDate { get { return this.expiryDate; } set { this.expiryDate = value; } }
        public int CVV { get { return this.cvv; } set { this.cvv = value; } }

        public Card(int no, int id, double limit, double spent, DateTime issdt, DateTime exp, int cvv)
        {
            this.CardNumber=no;
            this.CardHolderID=id;
            this.Limit=limit;
            this.Spent=spent;
            this.IssueDate=issdt;
            this.ExpiryDate=exp;
            this.CVV=cvv;
        }
    }
}
