using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP.Entities
{
    internal class Accounts
    {
        #region Abstracted variables
        static int v_auto_accNo;
        int v_accNo;
        string v_accName;
        string v_accType;
        double v_accBalance;
        bool v_accIsActive;
        #endregion

        #region Encapsulated Propties
        public int AccountNo
        {
            get { return v_accNo; }
            set { v_accNo = value; }
        }

        public string AccountName
        {
            get { return v_accName; }
            set { v_accName = value; }
        }

        public string AccountType
        {
            get { return v_accType; }
            set { v_accType = value; }
        }

        public double AccountBalance
        {
            get { return v_accBalance; }
            set { v_accBalance = value; }
        }

        public bool AccountIsActive
        {
            get { return v_accIsActive; }
            set { v_accIsActive = value; }
        }

        #endregion

        #region Abstracted and Encapsulated Methods

        public double Widraw(int p_amount)
        {
            AccountBalance = AccountBalance - p_amount;
            return AccountBalance;
        }

        public double Deposit(int p_amount)
        {
            AccountBalance = AccountBalance + p_amount;
            return AccountBalance;
        }
        #endregion

    }
}
