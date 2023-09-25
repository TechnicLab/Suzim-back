using AutoMapper;
using Suzim.Business.Abstract.Services;
using Suzim.Business.Models;
using Suzim.Store.Common.Entities;
using Suzim.Store.Repositories.Abstract;
using Suzim.Store.Repositories.Abstract.Shared;

namespace Suzim.Business.Services;

internal sealed class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper;
    
    public OrderService(IOrderRepository orderRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
    }

    public Task<OrderModel> GetAll(int offset, int limit, bool isOnlyActive, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public async Task<OrderModel?> Get(Guid id, CancellationToken token = default)
    {
        var entity = await _orderRepository.GetById(id,true, token);
        if (entity == null)
        {
            return null;
        }
        var result = _mapper.Map<OrderModel>(entity);

        return result;
    }

    public Task<Guid> Create(Guid? id, CreateOrderModel model, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<OrderModel> Update(Guid id, UpdateOrderModel model, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}