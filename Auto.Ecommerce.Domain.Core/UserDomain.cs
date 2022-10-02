using Auto.Ecommerce.Domain.Entity;
using Auto.Ecommerce.Domain.Interface;
using Auto.Ecommerce.Infrastucture.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Ecommerce.Domain.Core
{
    public class UserDomain : IUserDomain
    {
        private readonly IUserRepository _userRepository;

        public UserDomain(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Users Authenicate(string UserName, string Password)
        {
            return _userRepository.Authenticate(UserName, Password);
        }
    }
}
