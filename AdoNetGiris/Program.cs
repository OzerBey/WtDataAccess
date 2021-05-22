using System;
using System.Data.SqlClient;

namespace AdoNetGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // 1. step: connect to database
            SqlConnection con = new SqlConnection(@"Server=(localdb)\MSSQLLocalDb;Database=WT1976Db;Integrated Security=True");
            con.Open(); // open the our connection

            //2. step: occur the instructor object
            SqlCommand cmd = new SqlCommand("SELECT id, CityName from Cities", con);

            //3. step : run the instructors
            SqlDataReader dr = cmd.ExecuteReader();

            //4. step read the line by line datas
            while (dr.Read())
            {
                Console.WriteLine("{0} {1}", dr[0], dr[1]);
                //Console.WriteLine("{0} {1}", dr["id"], dr["CityName"]);
            }
            dr.Close();

            //5. step close the connection
            con.Close();
        }
    }
}
