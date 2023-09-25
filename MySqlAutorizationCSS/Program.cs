using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlAutorizationCSS
{
    class Program
    {
        static void Main(string[] args)
        {

            MainContoller contoller = new MainContoller();
            string choice;
            bool working = true;
            do
            {
                Console.WriteLine("Choice action:\n1 - See all accounts\n2 - Create account\n" +
                    "3 - Find by Name\n4 - Find by ID\n 5 - Exit");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        contoller.PrintAll();
                        break;


                    case "2":

                        string NameForNewAccount = null;
                        string PasswordtForNewAccount = null;

                        do
                        {
                            Console.WriteLine("Enter a name for new account");
                            NameForNewAccount = Console.ReadLine();

                            Account checkName = contoller.FindByName(NameForNewAccount);

                            if (checkName != null)
                            {
                                NameForNewAccount = null;
                                Console.WriteLine("\nThis name is already exist\n");
                            }
                        } while (NameForNewAccount == null);

                        do
                        {
                            Console.WriteLine("Enter a password for new account");
                            PasswordtForNewAccount = Console.ReadLine();

                        } while (PasswordtForNewAccount == null);

                        Console.WriteLine(NameForNewAccount + " " + PasswordtForNewAccount);

                        Account AccountToCreate = new Account(NameForNewAccount, PasswordtForNewAccount);
                        contoller.CreateAccount(AccountToCreate);
                        break;


                    case "3":
                        string nameToFind;
                        Console.WriteLine("Enter a account name");
                        nameToFind = Console.ReadLine();

                        Account FindedAccountByName = contoller.FindByName(nameToFind);
                        
                        if(FindedAccountByName != null)
                        {
                            contoller.Print(FindedAccountByName);
                        }
                        else
                        {
                            Console.WriteLine($"Account with name - {nameToFind} doesn't exist");
                        }
                        break;


                    case "4":
                        string idToFind;
                        Console.WriteLine("Enter a ccount ID");
                        idToFind = Console.ReadLine();
                        Account FindedAccountByID = contoller.FindByID(int.Parse(idToFind));

                        if (FindedAccountByID != null)
                        {
                            contoller.Print(FindedAccountByID);
                        }
                        else
                        {
                            Console.WriteLine($"Account with name - {idToFind} doesn't exist");
                        }
                        break;


                    case "5":
                        Console.WriteLine("Exit");
                        working = false;
                        break;


                }
                



            } while (working);

        }

    }
}
