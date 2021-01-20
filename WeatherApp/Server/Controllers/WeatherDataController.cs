using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.Server.Data;

namespace WeatherApp.Server.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
        public class WeatherDataController : ControllerBase
        {
            private readonly ApplicationDBContext _context;
            public WeatherDataController(ApplicationDBContext context)
            {
                this._context = context;
                
            }

        public IQueryable<Shared.Models.WeatherData> FetchTop3()
        {
            var hWeather = _context.WeatherData.AsQueryable().OrderByDescending(data => data).Take(3);
            return hWeather;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            FetchTop3();
            var wData = await _context.WeatherData.ToListAsync();
            return Ok(wData);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var wData = await _context.WeatherData.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(wData);
        }
    }
    
}
