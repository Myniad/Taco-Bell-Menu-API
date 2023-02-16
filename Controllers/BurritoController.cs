using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taco_Bell_API.Models;

namespace Taco_Bell_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BurritoController : ControllerBase
    {
        private TacoBellDbContext dbContext = new TacoBellDbContext();

        [HttpGet]
        public List<Burrito> GetAllBurritos()
        {
            return dbContext.Burritos.ToList();
        }
        [HttpGet("cost")]
        public Burrito GetByCost(float cost)
        {
            return dbContext.Burritos.FirstOrDefault(b => b.Cost == cost);
        }
        //[HttpPost]
        //public Burrito AddBurrito(string name, float cost, bool bean)
        //{
        //    Burrito newBurrito = new Burrito(name, cost, bean);
        //    dbContext.Add(newBurrito);
        //    dbContext.SaveChanges();
        //    return newBurrito;
        //}
        [HttpDelete]
        public Burrito DeleteBurrito(string name)
        {
            Burrito b = dbContext.Burritos.FirstOrDefault(b => b.Name == name);
            dbContext.Burritos.Remove(b);
            dbContext.SaveChanges();
            return b;
        }
    }
}
