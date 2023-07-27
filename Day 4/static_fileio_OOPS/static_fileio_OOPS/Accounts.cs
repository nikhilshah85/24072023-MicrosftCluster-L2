using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_fileio_OOPS
{
    enum AccountTypes
    {
        Savings, Current, PF
    }

    internal class Accounts
    {

       // static int v_autoAccountNumber = 100; //default value is 0 even if you do not instantiate it
        #region Properties
        public int AccNo { get; set; }
        public string AccName { get; set; }
        public string AccType { get; set; }
        public double AccBalance { get; set; }
        public bool AccIsActive { get; set; }

        #endregion

        #region Constructor
        public Accounts(string p_accName, AccountTypes p_accType, double p_accBalance, bool p_accIsActive)
        {
            //you can do validations here , eg. check name length or accbalance to be minimum while opening account
            //throw exception if not valid
            AccName = p_accName;
            AccType = p_accType.ToString();
            AccBalance = p_accBalance;
            AccIsActive = p_accIsActive;

            #region read the number
            FileStream file_accountNo = new FileStream("autoaccNo.txt", FileMode.Open, FileAccess.Read);
            StreamReader readNo = new StreamReader(file_accountNo);
            
            int number =Convert.ToInt32(readNo.ReadLine());
            number = number + 1;
            AccNo = number;
            readNo.Close();
            file_accountNo.Close();
            #endregion

            #region Save the number back to file

            FileStream write_accountNo = new FileStream("autoaccNo.txt", FileMode.Create, FileAccess.Write);
            StreamWriter write = new StreamWriter(write_accountNo);
            write.WriteLine(number);

            write.Close();
            write_accountNo.Close();

            #endregion            // v_autoAccountNumber = v_autoAccountNumber + 1;
            //   AccNo = v_autoAccountNumber;


        }
        #endregion
    }
}
