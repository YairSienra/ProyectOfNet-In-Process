using Auto.Ecommerce.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Ecommerce.Infrastucture.Interface
{
    public interface IUserRepository
    {
       public Users Authenticate(string UserName, string Password);
    }
}
