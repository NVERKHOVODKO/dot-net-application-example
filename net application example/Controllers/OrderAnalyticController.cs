using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderAnalyticController : ControllerBase
    {
        private readonly IOrderAnalyticService _orderStatisticService;

        public OrderAnalyticController(IOrderAnalyticService orderStatisticService)
        {
            _orderStatisticService = orderStatisticService;
        }

        [HttpGet("getAmountPrice")]
        public async Task<ActionResult<int>> GetAmountPriceByCompany(Guid companyId)
        {
            var result = await _orderStatisticService.GetAmountByCompany(companyId);

            return Ok(result);
        }
    }
}