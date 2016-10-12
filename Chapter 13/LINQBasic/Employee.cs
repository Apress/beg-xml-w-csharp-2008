using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LINQBasic
{
    public class Employee
    {
        private int intEmployeeID;

        public int EmployeeID
        {
            get { return intEmployeeID; }
            set { intEmployeeID = value; }
        }
        private string strFirstName;

        public string FirstName
        {
            get { return strFirstName; }
            set { strFirstName = value; }
        }
        private string strLastName;

        public string LastName
        {
            get { return strLastName; }
            set { strLastName = value; }
        }
        private DateTime dtBirthDate;

        public DateTime BirthDate
        {
            get { return dtBirthDate; }
            set { dtBirthDate = value; }
        }
        private string strCountry;

        public string Country
        {
            get { return strCountry; }
            set { strCountry = value; }
        }

        public static List<Employee> GetEmployees()
        {
            SqlConnection cnn = new SqlConnection(@"data source=.\sqlexpress;initial catalog=northwind;integrated security=true");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("select employeeid,firstname,lastname,birthdate,country from employees");
            cmd.Connection = cnn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<Employee> items = new List<Employee>();
            while (reader.Read())
            {
                Employee item = new Employee();
                item.EmployeeID = reader.GetInt32(0);
                item.FirstName = reader.GetString(1);
                item.LastName = reader.GetString(2);
                item.BirthDate = reader.GetDateTime(3);
                item.Country = reader.GetString(4);
                items.Add(item);
            }

            reader.Close();
            cnn.Close();
            return items;
        }

    }
}
