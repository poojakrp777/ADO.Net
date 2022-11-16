using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace ADO.net
{
    internal class Employee
    {
        public void CreateDatabase()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=true");
                connection.Open();
                SqlCommand cmd = new SqlCommand("create database Employee",connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee database create succesufully");
                connection.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public SqlConnection connection = new SqlConnection(@"Data source=(localdb)\MSSQLLocalDB;Initial Catalog=Employee;Integrated Security=true");
        public void CreateTable()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("create table Employeedata(Empid int identity(1,1) primary key,Empname varchar(200),Salary varchar(200),Age int)", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee table create succesufully");
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void InsertRecord(string name,int salary,int age)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into Employeedata values('" + name+"','"+salary+"','"+age+"')",connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee data insert record successfull");
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void Delete(string name)
        {
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("delete from Employeedata where Empname='" + name + "'", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record Deleted successfully");
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void Retrievedata()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select * from Employeedata", connection);
                SqlDataReader sdr=cmd.ExecuteReader();
                while (sdr.Read())
                {
                    var id = Convert.ToInt64(sdr["Empid"]);
                    string name = (string)sdr["Empname"];
                    string salary = (string)sdr["Salary"];
                    var age = Convert.ToInt64(sdr["age"]);

                    Console.WriteLine("Empid=" + id + "|" + "Empname=" + name + "|" + "Salary=" + "|" + "Age=" + age);
                }
                connection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void Updatedata(string name, string salary)
        {
            try
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("update Employeedata set salary='" + salary + "'where Empname='" + name + "'", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record Updated Sucessfully");
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
