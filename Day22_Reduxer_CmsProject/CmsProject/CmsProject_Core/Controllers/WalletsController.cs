using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CmsProject_Core_.Models;

namespace CmsProject_Core_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class WalletsController : ControllerBase
    {
        private readonly CmsDbContext _ctx;
        public WalletsController(CmsDbContext ctx) => _ctx = ctx;

        // api/Wallets/bycustomer/101  →  list of wallets for custId 101
        [HttpGet("bycustomer/{custId:int}")]
        public async Task<IEnumerable<Wallet>> GetByCustomer(int custId) =>
            await _ctx.Wallets.Where(w => w.CustId == custId).ToListAsync();
    }
}
