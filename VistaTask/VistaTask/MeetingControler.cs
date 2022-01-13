using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaTask
{
    public static class MeetingControler
    {
        
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
            DB.SaveChanges();
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
