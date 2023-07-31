using ADO_net_demo;
using System.Threading.Channels;

Console.WriteLine("!!! Welcome to Banking !!!");
Console.WriteLine("1. Add New Account");
Console.WriteLine("2. Delete Account");
Console.WriteLine("3. Update Account");
Console.WriteLine("4. View Account");


AccountDetails accCRUD = new AccountDetails();

AccountDetails accObj = new AccountDetails();
int choice = Convert.ToInt32(Console.ReadLine());

switch(choice)
{
	case 1:
			#region Add New Account



Console.WriteLine("Enter Account Number");
accObj.AccountNo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Account Name");
accObj.AccountName = Console.ReadLine();
Console.WriteLine("Enter Account Type");
accObj.AccountType = Console.ReadLine();

Console.WriteLine("Enter Account Balance");
accObj.AccountBalance = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Account Status");
accObj.AccountisActive = Convert.ToBoolean(Console.ReadLine());

string result = accCRUD.AddNewAccount(accObj);
Console.WriteLine(result);
		#endregion
		break;
	case 2:
			#region Delete Account

Console.WriteLine("Please Enter Account No");
int accNo = Convert.ToInt32(Console.ReadLine());

try
{
	string deleteResult = accCRUD.DeleteAccount(accNo);
	Console.WriteLine(deleteResult);
}
catch (Exception es)
{
	Console.WriteLine(es.Message);
}

#endregion
		break;
	case 3:
			#region EditAccount


Console.WriteLine("Enter Account Number to be updated");
accObj.AccountNo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter New Account Name");
accObj.AccountName = Console.ReadLine();
Console.WriteLine("Enter New Account Type");
accObj.AccountType = Console.ReadLine();

Console.WriteLine("Enter New Account Balance");
accObj.AccountBalance = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter New Account Status");
accObj.AccountisActive = Convert.ToBoolean(Console.ReadLine());

string updateResult = accCRUD.AddNewAccount(accObj);
Console.WriteLine(updateResult);

try
{
	string updateresult = accCRUD.updateAccount(accObj);
	Console.WriteLine(updateResult);
}
catch (Exception es)
{
	Console.WriteLine(es.Message);
	throw;
}


#endregion
		break;
	case 4:
			#region View Account Details
        Console.WriteLine("Please Enter Account No to View account Details");
        int accViewDetails = Convert.ToInt32(Console.ReadLine());
		try
		{
			accObj = accCRUD.ViewAccount(accViewDetails);

			Console.WriteLine("Account Number : " + accObj.AccountNo);
			Console.WriteLine("Account Name : " + accObj.AccountName);
			Console.WriteLine("Account Balance : " + accObj.AccountBalance);
			Console.WriteLine("Account Type : " + accObj.AccountType);
			Console.WriteLine("Account Is Active : " + accObj.AccountisActive);
		}
		catch(Exception es)
		{
			Console.WriteLine(es.Message);
		}
		break;
    #endregion

  //  default:
		//Console.WriteLine("Invalid Option");
}



