using Auto.Ecommer.Aplication.Interface;
using Auto.Ecommerce.Aplication.DTO;
using Auto.Ecommerce.Domain.Entity;
using Auto.Ecommerce.Domain.Interface;
using Auto.Ecommerce.Transversal.Common;
using AutoMapper;

namespace Auto.Ecommerce.Aplication.Main
{
    public class CustomerAplicattion : ICustomerAplication
    {
        private readonly ICustomerDomain _customerDomain;
        private readonly IMapper _mapper;

        public CustomerAplicattion(ICustomerDomain customerAplication, IMapper mapper)
        {
            _customerDomain = customerAplication;
            _mapper = mapper;

        }
        #region Metodos Sincronos
        public Response<IEnumerable<CustomerDTO>> GetAll()
        {
            var response = new Response<IEnumerable<CustomerDTO>>();
            try
            {
                var customers = _customerDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<CustomerDTO>>(customers);
                if (response.Data != null)
                {
                    response.isSuccess = true;
                    response.Message = "Consulta Exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                throw;
            }

            return response;
        }
        public Response<bool> Delete(string customer)
        {
            var response = new Response<bool>();
            try
            {
               
                response.Data = _customerDomain.Delete(customer);
                if (response.Data)
                {
                    response.isSuccess = true;
                    response.Message = "Borrado Exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                throw;
            }

            return response;
        }
        public Response<bool> Insert(CustomerDTO customer)
                {
                    var response = new Response<bool>();
                    try
                    {
                        var custo = _mapper.Map<Customer>(customer);
                        response.Data = _customerDomain.Insert(custo);
                        if (response.Data)
                        {
                            response.isSuccess = true;
                            response.Message = "Registro Exitoso";
                        }
                    } 
                    catch(Exception ex)
                    {
                        response.Message = ex.Message;
                        throw;
                    }

                    return response;
                }
        public Response<CustomerDTO> GetById(string id)
        {
            var response = new Response<CustomerDTO>();
            try
            {
                var customer = _customerDomain.GetById(id);
                response.Data = _mapper.Map<CustomerDTO>(customer);
                if (response.Data != null)
                {
                    response.isSuccess = true;
                    response.Message = "Consulta Exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                throw;
            }

            return response;
        } 
        public Response<bool> Update(CustomerDTO customer)
        {
            var response = new Response<bool>();
            try
            {
                var custo = _mapper.Map<Customer>(customer);
                response.Data = _customerDomain.Update(custo);
                if (response.Data)
                {
                    response.isSuccess = true;
                    response.Message = "Registro Exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                throw;
            }

            return response;
        }
        #endregion

        #region Metodos Asincronos
        public async Task<Response<bool>> DeleteAsync(string customer)
        {
            var response = new Response<bool>();
            try
            {

                response.Data = await _customerDomain.DeleteAsync(customer);
                if (response.Data)
                {
                    response.isSuccess = true;
                    response.Message = "Borrado Exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                throw;
            }

            return response;
        }
        public async Task<Response<IEnumerable<CustomerDTO>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<CustomerDTO>>();
            try
            {
                var customers = await _customerDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<CustomerDTO>>(customers);
                if (response.Data != null)
                {
                    response.isSuccess = true;
                    response.Message = "Consulta Exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                throw;
            }

            return response;
        }
        public async Task<Response<CustomerDTO>> GetByIdAsync(string id)
        {
            var response = new Response<CustomerDTO>();
            try
            {
                var customer = await _customerDomain.GetByIdAsync(id);
                response.Data = _mapper.Map<CustomerDTO>(customer);
                if (response.Data != null)
                {
                    response.isSuccess = true;
                    response.Message = "Consulta Exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                throw;
            }

            return response;
        }
        public async  Task<Response<bool>> InsertAsync(CustomerDTO customer)
         {
            var response = new Response<bool>();
            try
            {
                var custo = _mapper.Map<Customer>(customer);
                response.Data = await _customerDomain.InsertAsync(custo);
                if (response.Data)
                {
                    response.isSuccess = true;
                    response.Message = "Registro Exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                throw;
            }

            return response;
         }
        public async Task<Response<bool>> UpdateAsync(CustomerDTO customer)
        {
            var response = new Response<bool>();
            try
            {
                var custo = _mapper.Map<Customer>(customer);
                response.Data = await _customerDomain.UpdateAsync(custo);
                if (response.Data)
                {
                    response.isSuccess = true;
                    response.Message = "Registro Exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                throw;
            }

            return response;
        }
        #endregion
    }
}