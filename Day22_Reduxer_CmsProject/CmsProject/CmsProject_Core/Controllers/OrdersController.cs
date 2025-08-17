using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CmsProject_Core_.Models;

namespace CmsProject_Core_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly CmsDbContext _ctx;
        public OrdersController(CmsDbContext ctx) => _ctx = ctx;

        // GET  api/Orders/bycustomer/101
        [HttpGet("bycustomer/{custId:int}")]
        public async Task<IEnumerable<Order>> GetByCustomer(int custId) =>
            await _ctx.Orders.Where(o => o.CustId == custId).ToListAsync();
    }
}
