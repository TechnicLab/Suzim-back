namespace Suzim.Store.Common.Enums;

public enum OrderStatus
{
    AwaitingPayment = 100,
    Created = 101,
    InAssembly = 102,
    
    TransferredToDelivery = 200,
    OnTheWay = 201,
    AtTheCourier = 202,
    AwaitingReceipt = 203,
    
    Delivered = 300,
    Received = 301,
    
    Canceled = 400
}