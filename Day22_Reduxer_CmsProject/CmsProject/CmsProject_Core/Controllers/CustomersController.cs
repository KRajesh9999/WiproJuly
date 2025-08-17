using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CmsProject_Core_.Middleware;
using CmsProject_Core_.Models;

namespace CmsProject_Core_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly CmsDbContext _ctx;
        public CustomersController(CmsDbContext ctx) => _ctx = ctx;

        // 1. List all customers
        [HttpGet]
        public async Task<IEnumerable<Customer>> GetAll() =>
            await _ctx.Customers.ToListAsync();

        // 2. Search by Id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Customer>> Get(int id) =>
            await _ctx.Customers.FindAsync(id) is { } c ? c : NotFound();

        // 3. Search by UserName 
        [HttpGet("byusername/{uname}")]
        public async Task<ActionResult<Customer>> GetByUser(string uname)
        {
            var cust = await _ctx.Customers
                .FirstOrDefaultAsync(c => c.CustUserName != null &&
                                          EF.Functions.Like(c.CustUserName, $"%{uname}%"));

            return cust is null ? NotFound() : cust;
        }

        // 4. Add customer 
        [HttpPost]
        public async Task<string> Post(Customer c)
        {
            c.CustId = (_ctx.Customers.Max(x => (int?)x.CustId) ?? 0) + 1;
            c.CustPassword = EncryptionHelper.Encrypt(c.CustPassword!);
            _ctx.Customers.Add(c);
            await _ctx.SaveChangesAsync();
            return "Customer Added Successfully...";
        }

        // 5. Authenticate 
        [HttpGet("auth/{uname}/{pwd}")]
        public async Task<int> Auth(string uname, string pwd)
        {
            var rec = await _ctx.Customers
                .FirstOrDefaultAsync(c => c.CustUserName != null &&
                                          c.CustUserName.ToLower() == uname.ToLower());

            return rec != null && EncryptionHelper.Decrypt(rec.CustPassword!) == pwd ? 1 : 0;
        }
    }
}
