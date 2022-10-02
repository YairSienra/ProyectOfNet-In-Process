using Auto.Ecommer.Aplication.Interface;
using Auto.Ecommerce.Aplication.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Auto.Ecommerce.Services.Web_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerAplication _customerAplication;
        public CustomerController(ICustomerAplication customerAplication)
        {
            _customerAplication = customerAplication;
        }
        #region Metodos Sincronos

        [HttpPost]
        public IActionResult Insert([FromBody] CustomerDTO data)
        {
            if (data == null) return BadRequest();

            var response = _customerAplication.Insert(data);
            if (response.isSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);

        }
        [HttpPut]
        public IActionResult update([FromBody] CustomerDTO data)
        {
            if (data == null) return BadRequest();

            var response = _customerAplication.Update(data);
            if (response.isSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string Id)
        {
            if (string.IsNullOrEmpty(Id)) return BadRequest();

            var response = _customerAplication.Delete(Id);
            if (response.isSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);

        }

        [HttpGet("{id}")]
        public IActionResult Get(string Id)
        {
            if (string.IsNullOrEmpty(Id)) return BadRequest();

            var response = _customerAplication.GetById(Id);
            if (response.isSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _customerAplication.GetAll();
            if (response.isSuccess) return Ok(response);

            return BadRequest(response.Message);

        }
        #endregion


        #region Metodos Asyncronos
        [HttpPost]
        public async Task<IActionResult> insertAsync([FromBody] CustomerDTO data)
        {
            if (data == null) return BadRequest();

            var response = await _customerAplication.InsertAsync(data);
            if (response.isSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);

        } 
        [HttpPut]
        public async Task<IActionResult> updateAsync([FromBody] CustomerDTO data)
        {
            if (data == null) return BadRequest();

            var response = await _customerAplication.UpdateAsync(data);
            if (response.isSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(string Id)
        {
            if (string.IsNullOrEmpty(Id)) return BadRequest();

            var response = await _customerAplication.DeleteAsync(Id);
            if (response.isSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);

        }

    /*    [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string Id)
        {
            if (string.IsNullOrEmpty(Id)) return BadRequest();

            var response = await _customerAplication.GetByIdAsync(Id);
            if (response.isSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);

        } */
       /* [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _customerAplication.GetAllAsync();
            if (response.isSuccess) return Ok(response);

            return BadRequest(response.Message);

        } */
        #endregion
    }
}
