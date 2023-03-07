using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApi1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using MediatR;
using MyApi1.MediatRModel;

namespace MyApi1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestApiController : ControllerBase
    {
        private readonly Mes3Context _context;

        private readonly IMediator _mediator;

        public TestApiController(Mes3Context context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        // [HttpGet]
        // public ContentResult Get()
        // {
        //     string utcNow = DateTime.UtcNow.ToString("o");
        //     string now = DateTime.Now.ToString("o");
        //     return base.Content(utcNow + "<br />" + now, "text/html");
        // }

        /// <summary>
        /// Test MES3 EF DB first
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetMes3Data()
        {
            //var box1 = _context.Boxes.FirstOrDefault();
            var boxNo = "B229090001";
            //var boxNo = new SqlParameter("boxNo", "'' OR modelcode = 'WC3374089002'");
            var box1 = _context.Boxes
                .FromSqlInterpolated($"SELECT * FROM dbo.box WHERE boxno = {boxNo}")
                .AsNoTracking()
                .SingleOrDefault();

            return Ok(box1);
        }

        [HttpGet]
        [Route("/api/box/")]
        public async Task<IActionResult> GetBox([FromQuery] GetBoxRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpPost]
        [Route("/api/box/")]
        public async Task<IActionResult> CreateBox([FromBody] AddBoxRequest request)
        {
            var result = await _mediator.Send<string>(request);
            return Ok(result);
        }

        [HttpDelete]
        [Route("/api/box/")]
        public async Task<IActionResult> RemoveBox([FromQuery] RemoveBoxRequest request)
        {
            var result = await _mediator.Send<string>(request);
            return Ok(result);
        }

        [HttpGet]
        [Route("/api/date")]
        public IActionResult ParseDate([FromQuery] string date)
        {
            DateTime dt = DateTime.Parse(date);
            var endDate = dt.AddDays(1).ToString("yyyy-MM-dd");
            var startDate = dt.ToString("yyyy-MM-dd");
            var retObj = new { StartDate = startDate, EndDate = endDate };

            var ar = new int[] { 1, 2, 2, 3, 2 };
            var tz = ar.GroupBy(p => p).Where(p => p.Count() > 1).FirstOrDefault().Key;
            //var indexs = Array.FindIndex(ar, val => val == tz);
            var indexs = FindAllIndexof(ar, tz).Take(2);
            return Ok(indexs);
        }

        private int[] FindAllIndexof<T>(IEnumerable<T> values, T val)
        {
            return values
                .Select((b, i) => object.Equals(b, val) ? i : -1)
                .Where(i => i != -1)
                .ToArray();
        }
    }
}
