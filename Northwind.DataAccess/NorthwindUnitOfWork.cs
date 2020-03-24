using Northwind.repositories;
using Northwind.UnitOfWork;

namespace Northwind.DataAccess
{
    public class NorthwindUnitOfWork: IUnitOfWork
    {
        public NorthwindUnitOfWork(string connectionstring)
        {
            Customer = new CustomerRepository(connectionstring);
        }

        public ICustomerRespository Customer { get; private set; }
       
    }
}
