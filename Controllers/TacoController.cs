using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taco_Bell_API.Models;

namespace Taco_Bell_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacoController : ControllerBase
    {
        private TacoBellDbContext dbContext = new TacoBellDbContext();

        [HttpGet]
        public List<Taco> GetAllTacos()
        {
            return dbContext.Tacos.ToList();
        }
        [HttpGet("dorito")]
        public Taco GetByCost(bool dorito)
        {
            return dbContext.Tacos.FirstOrDefault(t => t.Dorito == dorito);
        }
        //[HttpPost]
        //public Taco AddTaco(string name, float cost, bool softshell, bool dorito)
        //{
        //    Taco newTaco = new Taco(name, cost, softshell, dorito);
        //    dbContext.Add(newTaco);
        //    dbContext.SaveChanges();
        //    return newTaco;
        //}

        //[HttpDelete]
        //public Taco DeleteTaco(string name)
        //{
        //    Taco t = dbContext.Tacos.FirstOrDefault(t=>t.Name == name);
        //    dbContext.Tacos.Remove(t);
        //    dbContext.SaveChanges();
        //    return t;
        //}

        //any changes to DB(adding or updating) dont forget to dbContext.SaveChanges();
    }
}
