using BicycleTestTask.BicycleDbContext;
using BicycleTestTask.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleTestTask.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BicyclesController : ControllerBase
    {
        private readonly BicycleContext _context;

        public BicyclesController(BicycleContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bicycle>>> GetFreeBicycles()
        {
            return await _context.Bicycles.Where(x => x.IsRented == false).ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bicycle>>> GetRentedBicycles()
        {
            return await _context.Bicycles.Where(x => x.IsRented == true).ToListAsync();
        }

        [HttpGet]
        public async Task<ActionResult<float>> GetTotalBicyclesPrice()
        {
            return await _context.Bicycles.Where(x => x.IsRented == true).SumAsync(x => x.Price);
        }

        [HttpGet]
        public async Task<ActionResult<int>> GetTotalBicyclesAmount()
        {
            return await _context.Bicycles.Where(x => x.IsRented == false).CountAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Bicycle>> GetBicycle(int id)
        {
            var bicycle = await _context.Bicycles.FindAsync(id);

            if (bicycle == null)
            {
                return NotFound();
            }

            return bicycle;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> RentBicycle(int id)
        {
            var bicycleList = await _context.Bicycles.ToListAsync();

            var res = bicycleList.Find(x => x.Id == id);
            res.IsRented = true;
            _context.Entry(res).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!BicycleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> CancelRentBicycle(int id)
        {
            var bicycleList = await _context.Bicycles.ToListAsync();

            var res = bicycleList.Find(x => x.Id == id);
            res.IsRented = false;
            _context.Entry(res).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!BicycleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Bicycle>> PostBicycle(Bicycle bicycle)
        {
            _context.Bicycles.Add(bicycle);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBicycle", new { id = bicycle.Id }, bicycle);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Bicycle>> DeleteBicycle(int id)
        {
            var bicycle = await _context.Bicycles.FindAsync(id);
            if (bicycle == null)
            {
                return NotFound();
            }

            _context.Bicycles.Remove(bicycle);
            await _context.SaveChangesAsync();

            return bicycle;
        }

        private bool BicycleExists(int id)
        {
            return _context.Bicycles.Any(e => e.Id == id);
        }
    }
}
