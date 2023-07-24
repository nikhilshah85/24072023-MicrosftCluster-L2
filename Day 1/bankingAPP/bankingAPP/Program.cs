


using System.Threading.Channels;

Console.WriteLine("                                  !!~~~~~~~~~~~~~~~~~~~~ Welcome to MyBank ~~~~~~~~~~~~~~~~~~!!");
Console.WriteLine("1. View Account");
Console.WriteLine("2. Account List");
Console.WriteLine("3. Add Account");
Console.WriteLine("4. Update Account");
Console.WriteLine("5. Close Account");
Console.WriteLine("6. Transfer Funds");
Console.WriteLine("7. Exit");

int choice = Convert.ToInt32(Console.ReadLine());
bool continueBanking = true;

switch (choice)
{
   
	case 1:
        Console.WriteLine(" Feature 1 coming soon");
        break;
    case 2:
        Console.WriteLine(" Feature 2 coming soon");
        break;
    case 3:
        Console.WriteLine(" Feature 3 coming soon");
        break;
    case 4:
        Console.WriteLine(" Feature 4 coming soon");
        break;
    case 5:
        Console.WriteLine(" Feature 5 coming soon");
        break;
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




