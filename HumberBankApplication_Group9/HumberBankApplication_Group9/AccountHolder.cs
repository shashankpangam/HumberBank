using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumberBankApplication_Group9
{
    class AccountHolder
    {
        //properties
        private int accountNumber;
        private string accHolderName;
        private string motherName;
        private char gender;
        private int mobile;
        private string emailID;
        private string address;
        private string zipcode;
        private DateTime dateCreated;
        private string uniqueID;
        //Accessors
        public int AccNumber { get { return this.accountNumber; }  set { this.accountNumber = value; } }
        public string AccHolderName { get { return this.accHolderName;} set { this.accHolderName=value;} }
        public string MothersName { get { return this.motherName;} set { this.motherName=value;} }
        public char Gender { get { return this.gender;} set { this.gender=value;} }
        public int Mobile { get { return this.mobile;} set { this.mobile=value;} }
        public string EmailID { get { return this.emailID;} set { this.emailID=value;} }
        public string Address { get { return this.emailID;} set { this.emailID=value;} }
        public string ZipCode { get { return this.zipcode;} set { this.zipcode=value;} }
        public DateTime DateCreated { get { return this.dateCreated;} set { this.dateCreated=value;} }
        public string UniqueID { get { return this.uniqueID; } set { this.uniqueID=value;} }
        //Constructor
        public AccountHolder(int accno, string name, string mname, char gender, int mobile, string email, string address, string zip, DateTime dc, string uniqueID)
        {
            this.AccNumber = accno;
            this.AccHolderName = name;
            this.MothersName = mname;
            this.Gender = gender;
            this.Mobile = mobile;
            this.EmailID = email;
            this.Address = address;
            this.ZipCode = zip;
            this.DateCreated = dc;
            this.UniqueID = uniqueID;
        }

    }
}
