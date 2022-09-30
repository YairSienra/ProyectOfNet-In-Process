using Auto.Ecommerce.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Ecommerce.Domain.Interface
{
    public interface ICustomerDomain
    {
        #region Metodos Sincronos
        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(string customer);

        Customer GetById(string id);
        IEnumerable<Customer> GetAll();
        #endregion

        #region Metodos Asincronos
        Task<bool> InsertAsync(Customer customer);
        Task<bool> UpdateAsync(Customer customer);
        Task<bool> DeleteAsync(string customer);

        Task<Customer> GetByIdAsync(string id);
        Task<IEnumerable<Customer>> GetAllAsync();
        #endregion
    }
}
