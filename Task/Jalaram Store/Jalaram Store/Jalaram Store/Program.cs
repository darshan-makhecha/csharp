using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Jalaram_Store
{
    class Program
    {
        static void Main(string[] args)
        {

            var datasource = @"LAPTOP-LKATHT5O\SQLEXPRESS";//your server
            var database = "JalaramStore"; //your database name
            var username = "sa"; //username of server to connect
            var password = "abc@123"; //password

            //your connection string 
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            //create instanace of database connection
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                Console.WriteLine("Openning Connection ...");

                //open connection
                conn.Open();
                Console.WriteLine("Connection successful!");

                Console.WriteLine("\n\n\n\t\t\t\t\t\t JALARAM STORE");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("\n\t\t 1). State");
                Console.WriteLine("\t\t 2). City");
                Console.WriteLine("\t\t 3). Customers");
                Console.WriteLine("\t\t 4). Category");
                Console.WriteLine("\t\t 5). Product");


                string a;
                Console.Write("\n\n Enter a Number - ");
                int number = Convert.ToInt32(Console.ReadLine());
            

                if (number == 1)
                {
                    do
                    {
                        Console.Write("Enter State Name : ");
                        string snm = Console.ReadLine();
                        Console.Write("Enter Country Name : ");
                        string cnm = Console.ReadLine();

                        StringBuilder strBuilder = new StringBuilder();
                        strBuilder.Append("INSERT INTO States  VALUES ( '" + snm + "','" + cnm + "')");
                        string sqlQuery = strBuilder.ToString();
                        using (SqlCommand command = new SqlCommand(sqlQuery, conn)) //pass SQL query created above and connection
                        {
                            command.ExecuteNonQuery(); //execute the Query
                            Console.WriteLine("Query Executed.");
                        }
                        Console.Write("Do you like add moer ? (Y/N)");
                        a = Console.ReadLine();
                    } while (a == "y");
                }

                else if (number == 2)
                {
                    do
                    {
                        Console.Write("Enter City Name : ");
                        string cnm = Console.ReadLine();
                        Console.Write("Enter State Name : ");
                        //int Sid = Convert.ToInt32(Console.ReadLine());
                        StringBuilder strBuilder = new StringBuilder();
                        strBuilder.Append("INSERT INTO Cities  VALUES ( '" + cnm + "','" + Sid + "')");
                        string sqlQuery = strBuilder.ToString();
                        using (SqlCommand command = new SqlCommand(sqlQuery, conn)) //pass SQL query created above and connection
                        {
                            command.ExecuteNonQuery(); //execute the Query
                            Console.WriteLine("Query Executed.");
                        }
                        Console.Write("Do you like add moer ? (Y/N)");
                        a = Console.ReadLine();
                    } while (a == "y");
                }

                else if (number == 3)
                {
                    do
                    {
                        Console.Write("Enter Customer Name : ");
                        string cnm = Console.ReadLine();
                        Console.Write("City Id : ");
                        int cid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("State Id : ");
                        int sid = Convert.ToInt32(Console.ReadLine());
                       
                        StringBuilder strBuilder = new StringBuilder();
                        strBuilder.Append("INSERT INTO Customers VALUES ( '" + cnm + "','" + cid + "','" + sid +"')");
                        string sqlQuery = strBuilder.ToString();
                        using (SqlCommand command = new SqlCommand(sqlQuery, conn)) //pass SQL query created above and connection
                        {
                            command.ExecuteNonQuery(); //execute the Query
                            Console.WriteLine("Query Executed.");
                        }

                        Console.Write("Do you like add moer ? (Y/N)");
                        a = Console.ReadLine();
                    } while (a == "y");
                }

                else if (number == 4)
                {
                    do
                    {
                        Console.Write("Enter Category Name : ");
                        string category = Console.ReadLine();

                        StringBuilder strBuilder = new StringBuilder();
                        strBuilder.Append("INSERT INTO Categories VALUES ( '" + category + "')");
                        string sqlQuery = strBuilder.ToString();
                        using (SqlCommand command = new SqlCommand(sqlQuery, conn)) //pass SQL query created above and connection
                        {
                            command.ExecuteNonQuery(); //execute the Query
                            Console.WriteLine("Query Executed.");
                        }

                        Console.Write("Do you like add moer ? (Y/N)");
                        a = Console.ReadLine();
                    } while (a == "y");

                }

                else if (number == 5)
                {
                    do
                    {
                        Console.Write("Enter Category Id : ");
                        int cid = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Product Name : ");
                        string productName = Console.ReadLine();

                        StringBuilder strBuilder = new StringBuilder();
                        strBuilder.Append("INSERT INTO Products VALUES ( '" + cid + "','" + productName +"')");
                        string sqlQuery = strBuilder.ToString();
                        using (SqlCommand command = new SqlCommand(sqlQuery, conn)) //pass SQL query created above and connection
                        {
                            command.ExecuteNonQuery(); //execute the Query
                            Console.WriteLine("Query Executed.");
                        }

                        Console.Write("Do you like add moer ? (Y/N)");
                        a = Console.ReadLine();
                    } while (a == "y");
                }
                else
                {
                    Console.WriteLine("invalide Number");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
