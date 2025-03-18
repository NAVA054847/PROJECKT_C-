using Microsoft.AspNetCore.Mvc;
using NAVA_CHAYA.Entities;


namespace NAVA_CHAYA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersoneController : ControllerBase
    {

        //static List<Persone> p = new List<Persone>() {
        //    new Persone(12,"nava", 19, "a"),
        //    new Persone(23,"chaya", 19, "a"),
        //    new Persone(65,"sara", 19, "a"),
        //    new Persone(232,"tsivya", 20, "s"),
        //};


        private readonly MY_DBContext _context;

        public PersoneController()
        {
            _context = new MY_DBContext();
        }




        // GET: api/<PersoneController>
        [HttpGet]
        public List<Persone> Get()
        {
            return _context.Users.ToList();
        }

        // GET api/<PersoneController>/5
        [HttpGet("{id}")]
        public Persone Get(int id)
        {

            Persone p1 = _context.Users.First(s => s.id == id);

            return p1;

        }


        //// GET api/<PersoneController>/find
        //[HttpGet("find")]
        //public List<Persone> Find(String quary)
        //{
        //    Console.WriteLine(quary);
        //    return null;
        //}



        // POST api/<PersoneController>
        [HttpPost]
        public void Post([FromBody] Persone p1)
        {
            _context.Users.Add(p1);
            _context.SaveChanges();
        }


        //[HttpPost("createDataSave/{path}")]
        //public IActionResult Post(string path)
        //{

        //    if (!path.Contains(".txt"))
        //    {
        //        return BadRequest("empty destination path");
        //    }
        //    using (StreamWriter writer = new StreamWriter(path))
        //    {
        //        foreach (Persone pers in p)
        //        {
        //            writer.WriteLine(pers.name + pers.id + pers.age + pers.type);

        //        }
        //    }

        //    return Ok("sucsess");

        //}


        // PUT api/<PersoneController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Persone p1)
        {
            Persone u = _context.Users.FirstOrDefault(s => s.id == id);
            u.name = p1.name;
            u.age = p1.age;
            u.type = p1.type;
            _context.SaveChanges();

        }

        // DELETE api/<PersoneController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Persone pe = _context.Users.FirstOrDefault(s => s.id == id);
            _context.Remove(pe);
            _context.SaveChanges();
        }
    }
}
