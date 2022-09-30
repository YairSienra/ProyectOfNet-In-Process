using Auto.Ecommerce.Domain.Entity;
using Auto.Ecommerce.Infrastucture.Interface;
using Auto.Ecommerce.Transversal.Common;
using Dapper;
using System.Data;

namespace Auto.Ecommerce.Infrastucture.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public CustomerRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        #region Metodos Sincronos
        public bool Delete(string customer)
        {
            using (var connection = _connectionFactory.GetDbConnection)
            {
                var query = "CustomerDelete";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", customer);
               
                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;

            }
        }
        public IEnumerable<Customer> GetAll()
        {
            using (var connection = _connectionFactory.GetDbConnection)
            {
                var query = "CustomerList";
              
                var customers = connection.Query<Customer>(query, commandType: CommandType.StoredProcedure);

                return customers;

            }
        }
        public Customer GetById(string id)
        {
            using (var connection = _connectionFactory.GetDbConnection)
            {
                var query = "CustomersGetByID";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", id);

                var customer = connection.QuerySingle<Customer>(query,param: parameters, commandType: CommandType.StoredProcedure);

                return customer;

            }
        }
        public bool Insert(Customer customer)
        {
            using (var connection = _connectionFactory.GetDbConnection)
            {
                var query = "CustomersInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = connection.Execute(query, param: parameters,commandType: CommandType.StoredProcedure);

                return result > 0; 
            }
        }
        public bool Update(Customer customer)
        {
            using (var connection = _connectionFactory.GetDbConnection)
            {
                var query = "CustomerUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }
        #endregion

        #region Metodos Asincronos
        public async Task<bool> DeleteAsync(string customer)
        {
            using (var connection = _connectionFactory.GetDbConnection)
            {
                var query = "CustomerDelete";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", customer);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;

            }
        }
        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetDbConnection)
            {
                var query = "CustomerList";

                var customers = await connection.QueryAsync<Customer>(query, commandType: CommandType.StoredProcedure);

                return customers;

            }
        }
        public async Task<Customer> GetByIdAsync(string id)
        {
            using (var connection = _connectionFactory.GetDbConnection)
            {
                var query = "CustomerGetById";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", id);

                var customer = await connection.QuerySingleAsync<Customer>(query, param: parameters, commandType: CommandType.StoredProcedure);

                return customer;

            }
        }
        public async Task<bool> InsertAsync(Customer customer)
        {
            using (var connection = _connectionFactory.GetDbConnection)
            {
                var query = "CustomerInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }
        public async Task<bool> UpdateAsync(Customer customer)
        {
            using (var connection = _connectionFactory.GetDbConnection)
            {
                var query = "CustomerUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerId", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("Region", customer.Region);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }
    }
    #endregion
}