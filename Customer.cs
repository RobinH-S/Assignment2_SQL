using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SQLCoding
{
    public class Customer :  ICustomer
    {
        public bool AddCustomer(Customer newCustomer)
        {
            try
            {
                
                //Connection address from CustomerDBConfig class.                Not working?
                using SqlConnection conn = new SqlConnection(CustomerDBConfig.GetConnectionString());
                conn.Open();
                
          

                string sql = "SELECT * From Customer ";
                //Running sql query on Table at conn address
                using (SqlCommand command = new SqlCommand(sql, conn))

                return command.ExecuteNonQuery() > 0;

            }

            //Catch exceptions from Warrens Example
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;

        }

        public bool DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> Customers = new ();
            return Customers;
        }

        public bool UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}

//CRUD
//Create connection
//Set up our SQL
//Excecute query on DB
//Handle results
