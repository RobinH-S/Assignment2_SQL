namespace SQLCoding
{
    public interface ICustomer
    {
        public List<Customer> GetAllCustomers();
        public bool AddCustomer(Customer customer);

        public bool DeleteCustomer(Customer customer);
        public bool UpdateCustomer(Customer customer);

    }
}
