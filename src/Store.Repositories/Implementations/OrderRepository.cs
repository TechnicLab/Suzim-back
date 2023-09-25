using Microsoft.EntityFrameworkCore;
using Suzim.Store.Common.Entities;
using Suzim.Store.Repositories.Abstract;
using Suzim.Store.Repositories.Abstract.Shared;

namespace Suzim.Store.Repositories.Implementations;

public sealed class OrderRepository : Repository<OrderRecord>, IOrderRepository
{
    public OrderRepository(DbContext dbContext) : base(dbContext) { }
}