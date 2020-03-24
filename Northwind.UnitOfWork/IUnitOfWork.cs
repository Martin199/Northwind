using Northwind.repositories;

namespace Northwind.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICustomerRespository Customer { get; }
    }
}
