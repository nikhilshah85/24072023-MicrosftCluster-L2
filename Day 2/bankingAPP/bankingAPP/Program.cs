


using bankingAPP.Entities;
using System.Threading.Channels;


#region Local Variables

bool continueBanking = true;
Accounts accObj = new Accounts()
{
    AccountNo = 101,
    AccountName = "Rahul",
    AccountBalance = 12000,
    AccountIsActive = true,
    AccountType = "Savings"
};



#endregion

while (continueBanking)
{
    Console.Clear();

    #region Display Menu
    Console.WriteLine("                                  !!~~~~~~~~~~~~~~~~~~~~ Welcome to MyBank ~~~~~~~~~~~~~~~~~~!!");
    Console.WriteLine("1. View Account");
    Console.WriteLine("2. Widraw");
    Console.WriteLine("3. Deposit");
    Console.WriteLine("4. Update Account");
    Console.WriteLine("5. Close Account");
    Console.WriteLine("6. Transfer Funds");
    Console.WriteLine("7. Exit");

    int choice = Convert.ToInt32(Console.ReadLine());
    #endregion

    #region Switch Case
    switch (choice)
    {
        #region Case 1 : View Account Info
        case 1:
            Console.WriteLine("Account Number : " + accObj.AccountNo);
            Console.WriteLine("Account Name : " + accObj.AccountName);
            Console.WriteLine("Account Balance : " + accObj.AccountBalance);
            Console.WriteLine("Account Type : " + accObj.AccountType);
            Console.WriteLine("Account Number : " + accObj.AccountIsActive);      

            break;
        #endregion

        #region Case 2 : Widraw  Amount
        case 2:
            Console.WriteLine(" Please Enter Amount to Widraw");
            int w_amount = Convert.ToInt32(Console.ReadLine());
            accObj.Widraw(w_amount);
            Console.WriteLine("Widrawal Successful, Available balance : " + accObj.AccountBalance);
            break;
        #endregion

        #region Case 3 : Deposit  Amount
        case 3:
            Console.WriteLine(" Please Enter Amount to Widraw");
            int d_amount = Convert.ToInt32(Console.ReadLine());
            accObj.Deposit(d_amount);
            Console.WriteLine("Widrawal Successful, Available balance : " + accObj.AccountBalance);
            break;
        #endregion

        #region Case 4 : Update Account Details
        case 4:
            Console.WriteLine("Enter New Account Name");
            accObj.AccountName = Console.ReadLine();
            Console.WriteLine("Enter Account Type");
            accObj.AccountType = Console.ReadLine();

            Console.WriteLine("Account Updated Successfully");

            break;
        #endregion

        #region Case 5 : Close Account
        case 5:
            Console.WriteLine("Are you Sure you want to Discontinue the account ? ");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            int deactivateAccount = Convert.ToInt32(Console.ReadLine());
            if (deactivateAccount == 1)
            {
                accObj.AccountIsActive = false;
                Console.WriteLine("Account Is Closed");
            }
            break;
        #endregion


        case 6:
            Console.WriteLine(" Feature 6 coming soon");
            break;
        case 7:
            continueBanking = false;
            Console.WriteLine("Thank you for Banking with us, see you soon again");
            break;
        default:
            Console.WriteLine("Sorry Invalid Option");
            break;
    }
    #endregion

    #region Ask for Continuation
    Console.WriteLine(" Do You Wish to continue Banking ? ");
    Console.WriteLine("1. Yes");
    Console.WriteLine("2. No");

    int continuemore = Convert.ToInt32(Console.ReadLine());
    if (continuemore != 1)
    {
        continueBanking = false;
    }
    #endregion
}



