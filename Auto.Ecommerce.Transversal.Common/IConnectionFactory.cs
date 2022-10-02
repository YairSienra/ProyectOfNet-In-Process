using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Ecommerce.Transversal.Common
{
    public interface IConnectionFactory
    {
     public IDbConnection GetDbConnection { get; }  
    }
}
