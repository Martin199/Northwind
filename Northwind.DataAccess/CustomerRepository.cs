using Dapper;
using Northwind.Model;
using Northwind.repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Northwind.DataAccess
{
    public class CustomerRepository : Repository<Customer>, ICustomerRespository
    {
        public CustomerRepository(string connectionString) : base(connectionString) 
        { 

        }

        public IEnumerable<Customer> CustomerPagedList(int page, int rows)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@page", page);
            parameters.Add("@rows", rows);

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Customer>("dbo.CustomerPageList", parameters, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
