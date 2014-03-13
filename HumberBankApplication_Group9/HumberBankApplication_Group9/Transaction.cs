using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumberBankApplication_Group9
{
    class Transaction
    {
        //Properties
        private int transactionID;
        private int accNumber;
        private DateTime transactionTime;
        private string type;
        private double amount;
        private string chequeNo;
        private string remarks;
        //Accessors
        public int TransactionID { get { return this.transactionID; } set { this.transactionID=value;} }
        public int AccNumber { get { return this.accNumber; } set { this.accNumber=value;} }
        public DateTime TransactionTime { get { return this.transactionTime;} set { this.transactionTime=value;} }
        public string Type { get { return this.type;} set { this.type=value;} }
        public double Amount { get {return this.amount;} set { this.amount=value;} }
        public string ChequeNo { get { return this.chequeNo; } set { this.chequeNo = value ;} }
        public string Remarks { get { return this.remarks; } set { this.remarks=value;} }
        //For Cheques
        public Transaction(int id, int acc, DateTime tt, string type, double amount, string chequeno, string remarks)
        {
            this.TransactionID = id;
            this.AccNumber = acc;
            this.TransactionTime = tt;
            this.Type = type;
            this.Amount = amount;
            this.ChequeNo = chequeno;
            this.Remarks = remarks;
        }
        //For Regulars
        public Transaction(int id, int acc, DateTime tt, string type, double amount, string remarks)
        {
            this.TransactionID = id;
            this.AccNumber = acc;
            this.TransactionTime = tt;
            this.Type = type;
            this.Amount = amount;
            this.Remarks = remarks;
        }
    }
}
