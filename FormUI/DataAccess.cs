using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //var output = connection.Query<Person>($"select * from People where LastName = '{lastName}'").ToList();
                var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName }).ToList();
                return output;
            }
        }

        public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                List<Person> people = new List<Person>();
                people.Add(new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber });
                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people);
            }
        }

        public string HelloMsg()
        {
            return "Hello Using Reflection";
        }

        public void TestSQL()
        {
            string connectionString = Helper.CnnVal("SampleDB");
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using(SqlCommand command = new SqlCommand("SELECT TOP 2 * FROM People",con))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Console.WriteLine("{0} {1} {2}", reader.GetValue(0).ToString(), reader.GetString(1), reader.GetString(2));
                        }
                    }
                }
            }

        }

        public void TestSQL_IN_Clause()
        {
            string[] ids = new string[] { "1", "2", "3" };
            string commandText = "SELECT * FROM People WHERE id in ({0})";
            string[] paramNames = ids.Select(
                (s,i)=>"@id"+i.ToString()).ToArray();
            string inClause = string.Join(", ",paramNames);

            string connectionString = Helper.CnnVal("SampleDB");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(string.Format(commandText, inClause)))
               
                {
                   for(int i = 0; i < paramNames.Length; i++)
                    {
                        command.Parameters.AddWithValue(paramNames[i], ids[i]);
                    }
                   command.Connection = con;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0} {1} {2}", reader.GetValue(0).ToString(), reader.GetString(1), reader.GetString(2));
                        }
                    }
                }
            }

        }
    }
}
