using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp
{
    class SQLConnection
    {
        public SQLConnection(string connection_string =null)
        {
            if (connection_string == null)
                connection_string = @"Server=localhost\SQLEXPRESS;Database=abcd;Trusted_Connection=True;";
            Console.WriteLine("Starting connection..\n");
            con = new SqlConnection(connection_string);
            try
            {
                con.Open();
                Console.WriteLine("Connection open\n");

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }


        SqlConnection con;

        public void InsertEmployee()
        {
            Console.WriteLine("Enter name");
            String name = Console.ReadLine();
            Console.WriteLine("{0}", name);
            int i = 0;
            string query = "INSERT INTO employee VALUES ('i','{0}');";
            i += 1;
            query = String.Format(query, name);

            SqlCommand cmd = new SqlCommand(query, this.con);

            try
            {
                int num = cmd.ExecuteNonQuery();
                // executenonquery() tells me the number of rows affected.
                Console.WriteLine("{0} Rows Affected", num);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void get_employeeDetails()
        {
            throw new NotImplementedException();
        }
    }
}
