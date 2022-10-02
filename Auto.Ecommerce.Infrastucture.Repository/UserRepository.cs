using Auto.Ecommerce.Domain.Entity;
using Auto.Ecommerce.Infrastucture.Interface;
using Auto.Ecommerce.Transversal.Common;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Ecommerce.Infrastucture.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly IConnectionFactory _conectionFacotry;

        public UserRepository(IConnectionFactory connectionFactory)
        {
            _conectionFacotry = connectionFactory;
        }

        public Users Authenticate(string UserName, string Password)
        { 

            using(var connection = _conectionFacotry.GetDbConnection)
            {
                var query = "GetDataUserFromUsernamePassword";

                var parametters = new DynamicParameters();

                parametters.Add("UserName", UserName);
                parametters.Add("Password", Password);

                var result = connection.QuerySingle<Users>(query, param: parametters, commandType: CommandType.StoredProcedure);

                return result;
            }
        }
    }
}
