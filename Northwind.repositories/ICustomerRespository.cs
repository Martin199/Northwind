using Dapper;
using Northwind.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Northwind.repositories
{
    public interface ICustomerRespository: IRepository<Customer>
    {
      IEnumerable <Customer> CustomerPagedList(int page, int rows);
    }
}
