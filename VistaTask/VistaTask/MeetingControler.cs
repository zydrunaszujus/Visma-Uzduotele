using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaTask
{
    public static class MeetingControler
    {
       
        public static void Login()//prisijungimas
        {
            bool exit = false;
            while (!exit)
            {
                string username = UI_Helper.AskForString("Prasome ivesti vartotojo varda : ");
                string password = UI_Helper.AskForString("Prasome ivesti slaptazodi : "); var user = DB.Users.Where(x => x.Name == username).FirstOrDefault(); if (user == null)
                {
                    Console.Clear();
                    Console.WriteLine("Tokio vartotojo nera.");
                    continue;
                }
                if (BCrypt.Net.BCrypt.Verify(password, user.Password))
                {
                    DB.CurrentUser = user;
                    exit = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Neteisingas slaptazodis.");
                    continue;
                }
            }
        }
        public static void Register()
        {
            string username = UI_Helper.AskForString("Prasome ivesti vartotojo varda : ");
            string password = UI_Helper.AskForString("Prasome ivesti slaptazodi : ");
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password); DB.Users.Add(new User() { Name = username, Password = hashedPassword });
            //uzkoduoja slaptazodi
            DB.SaveUsers();
        }


        public static void Create()
        {
            Console.Clear();
            Console.WriteLine("Creating meeting ...");
            var testas = new Meeting()
            {
                Name = "TestName",
                ResponsiblePerson = "TestPerson",
                Description = "TestDescription",
                Category = Category.Short,
                Type = Type.InPerson,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now
            };
            DB.Meetings.Add(testas);
            DB.SaveChanges();//issaugo DB klaseje duomenis
        }
        public static void Delete()
        {
            Console.Clear();
            Console.WriteLine("Deleting meeting ...");
        }
        public static void AddPerson()
        {
            Console.Clear();
            Console.WriteLine("Adding person to meeting ...");
        }
        public static void RemovePerson()
        {
            Console.Clear();
            Console.WriteLine("Removing person from meeting ...");
        }
        public static void GetAll()
        {
            Console.Clear();
            Console.WriteLine("Showing all meetings ...");
        }


    }
}
