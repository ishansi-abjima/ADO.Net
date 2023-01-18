﻿using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Data;

using System.Data.SqlClient;

namespace ConsoleApp1

{
    class Program

    {
        static void Main(string[] args)

        {

            Program.Connection();

            Console.ReadLine();
        }
        static void Connection()

        {
            string cs = "Data Source=ABJIMA-ISHANSI; Initial Catalog=ado_db;Integrated Security=true;";

            SqlConnection con = null;

            try

            {
                using (con = new SqlConnection(cs))

                {
                    //Console.WriteLine("Person ID:");

                    //string PersonId = Console.ReadLine();

                    //Console.WriteLine("First Name :");

                    //string FirstName = Console.ReadLine();

                    //Console.WriteLine("Last Name : ");

                    //string LastName = Console.ReadLine();

                    //Console.WriteLine("City :");

                    //string City = Console.ReadLine();

                    //string query = "insert into dbo.Persons values(@PersonID, @FirstName, @LastName, @City)";



                    string query = "select * from dbo.Persons";


                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = query;

                    cmd.Connection = con;

                    //cmd.Parameters.AddWithValue("@PersonID", PersonID);

                    //cmd.Parameters.AddWithValue("@FirstName", FirstName);

                    //cmd.Parameters.AddWithValue("@LastName", LastName);

                    //cmd.Parameters.AddWithValue("@City", City);

                    con.Open();

                   SqlDataReader dr =  cmd.ExecuteReader();

                    while(dr.Read())

                    {

                        Console.WriteLine("PersonId =" + dr["PersonId"] +
                            
                            "FirstName = " + dr["FirstName"] +
                           
                            "LastName = " + dr["LastName"] + 
                            
                            "City =" + dr["City"] );

                    }

                }

            }
                   

              

            catch (SqlException ex)

            {

                Console.WriteLine(ex.Message);

            }

            finally

            {

                con.Close();

            }

        }

    }

}