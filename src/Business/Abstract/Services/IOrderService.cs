using Suzim.Business.Models;

namespace Suzim.Business.Abstract.Services;

public interface IOrderService : IBusinessService
{
    Task<OrderModel> GetAll(int offset, int limit, bool isOnlyActive, CancellationToken token = default);

    /// <summary>
    /// Получить коробку по ИД
    /// </summary>
    Task<OrderModel?> Get(Guid id, CancellationToken token = default);

    /// <summary>
    /// Создать заказы
    /// </summary>
    Task<Guid> Create(Guid? id, CreateOrderModel model, CancellationToken token = default);

    /// <summary>
    /// Обновить коробку
    /// </summary>
    Task<OrderModel> Update(Guid id, UpdateOrderModel model, CancellationToken token = default);

    /// <summary>
    /// Удалить коробку с паллеты
    /// </summary>
    Task Delete(Guid id, CancellationToken token = default);
}