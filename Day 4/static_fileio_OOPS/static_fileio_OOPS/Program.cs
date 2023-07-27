

using static_fileio_OOPS;
using System.Threading.Channels;
using System.IO;


#region Static
//Accounts accObj = new Accounts("Nikhil", AccountTypes.Savings, 5000, true); // this has successfully created a new object

//List<Accounts> accList = new List<Accounts>();

//for (int i = 0; i < 10; i++)
//{
//    Accounts accObj = new Accounts("Name " + i, AccountTypes.Savings, 5000,true);
//    accList.Add(accObj);
//}

//foreach (var item in accList)
//{
//    Console.WriteLine("Account No : " + item.AccNo);
//    Console.WriteLine("Account Name : " + item.AccName);
//}
#endregion

#region File IO - Demo 1 

//FileStream myFile = new FileStream("myintro.txt",FileMode.Create,FileAccess.Write); //book
//StreamWriter pen = new StreamWriter(myFile); //pen

//pen.WriteLine("Hello and welcome to my Demo on FileIO");
//pen.WriteLine("my Name is Nikhil");
//pen.WriteLine("I am a trainer");
//pen.WriteLine("I am from Mumbai");
//pen.WriteLine("Its raining heavy here");
//pen.WriteLine("I love programming");

//pen.Close();
//myFile.Close();

//Console.WriteLine("Details written to file");

#endregion

#region File IO - Demo 2

//Console.WriteLine("Please Type your name and press enter");
//string user = Console.ReadLine();

//FileStream myFile = new FileStream(user + ".txt", FileMode.Create, FileAccess.Write);
//StreamWriter pen = new StreamWriter(myFile);

//Console.WriteLine("Provide all the information you wish to, and say Bye once done");

//string lastword = "Not Bye";

//while (lastword != "Bye")
//{

//    string content = Console.ReadLine();
//    pen.WriteLine(content);

//    if (content == "Bye")
//    {
//        lastword = "Bye";
//    }
//}

//pen.Close();
//myFile.Close();


#endregion

#region FileIO - Demo 3 - Read the file

//Console.WriteLine("Please Enter Name to know the details");
//string name = Console.ReadLine();

//FileStream myFile = new FileStream(name + ".txt",FileMode.Open,FileAccess.Read);
//StreamReader read = new StreamReader(myFile);

//Console.WriteLine(read.ReadToEnd());

//read.Close();
//myFile.Close();

#endregion


#region FileIO - Demo 4 - Auto Account No generation

Accounts accObj = new Accounts("Guest",AccountTypes.Savings,8000,true);

Console.WriteLine("Account Created Successfully, New Account No is as below");
Console.WriteLine("Account No : " + accObj.AccNo);



#endregion