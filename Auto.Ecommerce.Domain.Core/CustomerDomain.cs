using Auto.Ecommerce.Domain.Entity;
using Auto.Ecommerce.Domain.Interface;
using Auto.Ecommerce.Infrastucture.Interface;

namespace Auto.Ecommerce.Domain.Core
{
    public class CustomerDomain : ICustomerDomain
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerDomain(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        #region Metodos Sincronos
        public bool Delete(string id)
        {
            return _customerRepository.Delete(id);
        }
        public IEnumerable<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }
        public Customer GetById(string id)
        {
            return _customerRepository.GetById(id);
        }
        public bool Insert(Customer customer)
        {
            return _customerRepository.Insert(customer);
        }
        public bool Update(Customer customer)
        {
            return _customerRepository.Update(customer);
        }
        #endregion

        #region Metodos Asincronos

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
           return await _customerRepository.GetAllAsync();
        }
        public async Task<Customer> GetByIdAsync(string id)
        {
            return await _customerRepository.GetByIdAsync(id);
        }
        public async Task<bool> InsertAsync(Customer customer)
        {
            return await _customerRepository.InsertAsync(customer);
        }
        public async Task<bool> UpdateAsync(Customer customer)
        {
            return await _customerRepository.UpdateAsync(customer);
        }
        public async Task<bool> DeleteAsync(string customer)
        {
            return await _customerRepository.DeleteAsync(customer);
        }
        #endregion
    }
}