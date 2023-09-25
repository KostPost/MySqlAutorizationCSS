using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlAutorizationCSS
{
    public class MainContoller
    {
        
        public void CreateAccount(Account AccountToCreate)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.acc_authorization.Add(AccountToCreate);
                db.SaveChanges();
            }
        }

        public void PrintAll()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var accounts = db.acc_authorization.ToList();
                Console.WriteLine("Список объектов:");
                foreach (var account in accounts)
                {
                    MainContoller contoller = new MainContoller();
                    contoller.Print(account);
                }
            }
        }
        public void Print(Account AccountToPrint)
        {
            Console.WriteLine($"\nid = {AccountToPrint.user_id} \nname = {AccountToPrint.user_name}\npassword = {AccountToPrint.user_password}\n");
        }

        public Account FindByName(String nameToFind)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Account account = null;
                var acc = db.acc_authorization.FirstOrDefault(u => u.user_name == nameToFind);

                if (acc != null)
                {
                    account = acc;
                }

                return account;
            }
        }

        public Account FindByID(int idToFind)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Account account = null;
                var acc = db.acc_authorization.FirstOrDefault(u => u.user_id == idToFind);

                if (acc != null)
                {
                    account = acc;
                }

                return account;

            }
        }

    }
}
