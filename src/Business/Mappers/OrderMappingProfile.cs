using AutoMapper;
using Suzim.Business.Models;
using Suzim.Store.Common.Entities;

namespace Suzim.Business.Mappers;

public sealed class OrderMappingProfile : Profile
{
    public OrderMappingProfile()
    {
        CreateMap<OrderRecord, OrderModel>();
        CreateMap<CreateOrderModel, OrderRecord>();
        CreateMap<UpdateOrderModel, OrderRecord>();
    }
}