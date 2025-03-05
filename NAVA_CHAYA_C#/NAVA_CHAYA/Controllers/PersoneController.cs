using Microsoft.AspNetCore.Mvc;


namespace NAVA_CHAYA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersoneController : ControllerBase
    {

        static List<Persone> p = new List<Persone>() {
            new Persone(12,"nava", 19, "a"),
            new Persone(23,"chaya", 19, "a"),
            new Persone(65,"sara", 19, "a"),
            new Persone(232,"tsivya", 20, "s"),
        };



        // GET: api/<PersoneController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(p);
        }

        // GET api/<PersoneController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Persone p1 = p.First(s => s.id == id);
                return Ok(p1);
            }
            catch (Exception ex)
            {
                return NotFound("id is not value");
            }

        }


        // GET api/<PersoneController>/find
        [HttpGet("find")]
        public List<Persone> Find(String quary)
        {
            Console.WriteLine(quary);
            return null;
        }



        // POST api/<PersoneController>
        [HttpPost]
        public void Post([FromBody] Persone p1)
        {

            p.Add(p1);
        }


        [HttpPost("createDataSave/{path}")]
        public IActionResult Post(string path)
        {
          
            if (!path.Contains(".txt") )
            {
                return BadRequest("empty destination path");
            }
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (Persone pers in p)
                    {
                        writer.WriteLine(pers.name + pers.id + pers.age + pers.type);

                    }
                }

                return Ok( "sucsess");
         


           
        }

        // PUT api/<PersoneController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Persone p1)
        {
            int index = p.FindIndex(s => s.id == id);
            p[index].name = p1.name;
            p[index].age = p1.age;
            p[index].type = p1.type;

        }

        // DELETE api/<PersoneController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Persone pe = p.FirstOrDefault(s => s.id == id);
            int index = p.FindIndex(s => s.id == id);
            p.Remove(pe);
        }
    }
}
