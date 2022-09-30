using Auto.Ecommerce.Aplication.DTO;
using Auto.Ecommerce.Domain.Entity;
using Auto.Ecommerce.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Ecommer.Aplication.Interface
{
    public interface ICustomerAplication
    {
       
            #region Metodos Sincronos
            Response<bool> Insert(CustomerDTO customer);
            Response<bool> Update(CustomerDTO customer);
            Response<bool> Delete(string customer);

            Response<CustomerDTO> GetById(string id);
            Response<IEnumerable<CustomerDTO>> GetAll();
            #endregion

            #region Metodos Asincronos
            Task<Response<bool>> InsertAsync(CustomerDTO customer);
            Task<Response<bool>> UpdateAsync(CustomerDTO customer);
            Task<Response<bool>> DeleteAsync(string customer);

            Task<Response<CustomerDTO>> GetByIdAsync(string id);
            Task<Response<IEnumerable<CustomerDTO>>> GetAllAsync();
            #endregion
        
    }
}
