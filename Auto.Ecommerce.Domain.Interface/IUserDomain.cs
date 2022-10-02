using Auto.Ecommerce.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Ecommerce.Domain.Interface
{
    public interface IUserDomain
    {
       public Users Authenicate(string UserName, string Password);
    }
}
