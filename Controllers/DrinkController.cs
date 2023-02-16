using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taco_Bell_API.Models;

namespace Taco_Bell_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinkController : ControllerBase
    {
        private TacoBellDbContext dbContext = new TacoBellDbContext();

        [HttpGet]
        public List<Drink> GetAllDrinks()
        {
            return dbContext.Drinks.ToList();
        }
        [HttpGet("slushie")]
        public Drink GetByCost(bool slushie)
        {
            return dbContext.Drinks.FirstOrDefault(d => d.Slushie == slushie);
        }
        //[HttpPost]
        //public Drink AddDrink(string name, float cost, bool slushie)
        //{
        //    Drink newDrink = new Drink(name, cost, slushie);
        //    dbContext.Add(newDrink);
        //    dbContext.SaveChanges();
        //    return newDrink;
        //}
        //[HttpDelete]
        //public Drink DeleteDrink(string name)
        //{
        //    Drink d = dbContext.Drinks.FirstOrDefault(d => d.Name == name);
        //    dbContext.Drinks.Remove(d);
        //    dbContext.SaveChanges();
        //    return d;
        //}
    }
}
