using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VMA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_login());
            //SqlConnection con = new SqlConnection("Server=.\\MSSQLLocalDB;Database=Baza_projekt");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[RentSet]", con);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine("{1}, {0}", reader.GetString(0), reader.GetString(1));

            //}
            //reader.Close();
            //con.Close();
            //Console.ReadLine();

        }
    }
}
