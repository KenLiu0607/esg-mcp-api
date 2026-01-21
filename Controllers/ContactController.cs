using esg_mcp_server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace esg_mcp_server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;
        private readonly DbHcisContext _db;

        public ContactController(ILogger<ContactController> logger, DbHcisContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
           string cYear = "2022";
            string OrgCode = "";
            string UserID = "irenehuang";
            string LanguageID = "zh-tw";
            string ChkAuth = "N";
            //var sp = _db.Database.ExecuteSqlInterpolated(
            //   $@"
            //        EXEC [HC].[usp_EsgCheckR1_getList]
            //            @cYear={cYear},
            //            @orgCode={OrgCode},
            //            @userID={UserID},
            //            @languageID={LanguageID},
            //            @chkAuth={ChkAuth
            //    ");

            var sp = await _db.Database.SqlQuery<usp_EsgCheckR1_getList>($"EXEC [HC].[usp_EsgCheckR1_getList] {cYear}, {OrgCode}, {UserID}, {LanguageID}, {ChkAuth}").ToListAsync();
            var users = await _db.Bausers.ToListAsync();
            var contacts = await _db.MaiAgentContacts.ToListAsync();

            var data = users
                .GroupJoin(contacts, u => u.UserId, c => c.UserId, (u, c) => new
                {
                    User = new { Name = u.UserName, ID = u.UserId },
                    Contacts = c.Select(s => s.ContactId).ToList()
                })
                .Where(w => w.Contacts.Count > 0)
                .ToList();

            if (data == null)
                return NotFound();

            return Ok(new { MaiAgent = data });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var users = await _db.Bausers.Where(u => u.UserId == id).ToListAsync();
            var contacts = await _db.MaiAgentContacts.Where(u => u.UserId == id).ToListAsync();

            var data = users
                .GroupJoin(contacts, u => u.UserId, c => c.UserId, (u, c) => new
                {
                    User = new { Name = u.UserName, ID = u.UserId },
                    Contacts = c.Select(s => s.ContactId).ToList()
                })
                .FirstOrDefault();

            if (data == null)
                return NotFound();

            return Ok(new { QueryMetadata = data });
        }
    }
}
