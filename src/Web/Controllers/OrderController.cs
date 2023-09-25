using System.ComponentModel;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Suzim.Web.Contracts.Models;

namespace Suzim.Web.Controllers;

[ApiController]
[Route("api/v1/orders/")]
public class OrderController : ControllerBase
{
    private readonly IMapper _mapper;

    private static readonly DefaultFaker<OrderResponse> OrderFaker = new();
    public OrderController(
        IMapper mapper)
    {
        _mapper = mapper;
    }

    /// <summary>
    /// Получить все заказы
    /// </summary>
    /// <param name="isOnlyActive">Только активные записи</param>
    /// <response code="200">Данные получены</response>
    /// <response code="400">Ошибка валидации входных данных</response>
    [HttpGet(Name = "GetOrderes")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public Task<IActionResult> GetAll(
        [FromQuery, DefaultValue(true)] bool isOnlyActive,
        CancellationToken token)
    {
        return Task.FromResult<IActionResult>(Ok(OrderFaker.Generate(10)));
    }

    /// <summary>
    /// Получить заказ по ИД
    /// </summary>
    /// <response code="200">Данные получены</response>
    /// <response code="400">Ошибка валидации входных данных</response>
    /// <response code="404">Запись не найдена в БД</response>
    [HttpGet("{id:guid}", Name = "GetOrderById")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OrderResponse))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public Task<IActionResult> Get(
        [FromRoute] Guid id,
        CancellationToken token)
    {
       

        return Task.FromResult<IActionResult>(Ok(OrderFaker.Generate()));
    }
    /// <summary>
    /// Cоздать заказ
    /// </summary>
    /// <response code="201">Запись создана в БД</response>
    /// <response code="400">Ошибка валидации входных данных</response>
    [HttpPost(Name = "CreateOrder")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create(
        [FromQuery] Guid? id,
        [FromBody] CreateOrderRequest model,
        CancellationToken token)
    {
        return await Task.FromResult<IActionResult>(Ok(OrderFaker.Generate()));
    }

    /// <summary>
    /// Обновить заказ
    /// </summary>
    /// <response code="200">Данные обновлены</response>
    /// <response code="400">Ошибка валидации входных данных</response>
    /// <response code="404">Запись не найдена в БД</response>
    [HttpPut("{id:guid}", Name = "UpdateOrder")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(OrderResponse))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(
        [FromRoute] Guid id,
        [FromBody] UpdateOrderRequest model,
        CancellationToken token)
    {
      
        return await Task.FromResult<IActionResult>(Ok(OrderFaker.Generate()));
    }

    /// <summary>
    /// Пометить заказ как удаленный
    /// </summary>
    /// <response code="200">Запись удалена</response>
    /// <response code="400">Ошибка валидации входных данных</response>
    /// <response code="404">Запись не найдена в БД</response>
    [HttpDelete("{id:guid}", Name = "DeleteOrder")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(
        [FromRoute] Guid id,
        CancellationToken token)
    {
        return await Task.FromResult<IActionResult>(Ok());
    }
}
