using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            propertytrial pp = new propertytrial();
            pp.Name = "Eshank";
            Console.WriteLine(pp.Name);
            //SQLProgram();
                    }
        public static void SQLProgram()
        {
            string intro = @"Welcome!
1.Insert
2.Read all records
3. Exit";
            Console.WriteLine(intro);
            string choice = Console.ReadLine();
            int ch;
            try
            {
                ch = Int32.Parse(choice);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }
            SQLConnection c = new SQLConnection();
            switch(ch)
            {
                case 1:
                    c.InsertEmployee();
                    break;
                case 2:
                    c.get_employeeDetails();
                    break;
            }



        }
    }
}
