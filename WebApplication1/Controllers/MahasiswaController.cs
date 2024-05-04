using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> mhsList = new List<Mahasiswa>()
        {
            new Mahasiswa("Nizar", "1302220037",new List<string>()
    {
        "PBO"
    },2024 ),
    new Mahasiswa("Marjauzah Naswansyah", "1302220009", new List < string >() { "Alpro" }, 2),
    new Mahasiswa("Hasan Nurrahman Pane", "1302220031", new List < string >() { "KPL" }, 2),
    new Mahasiswa("Matthew Theodore Lempas", "1302223116", new List < string >() { "DB" }, 2),
        };
        // GET: api/<MahasiswaController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mhsList;
        }

        // GET api/<MahasiswaController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mhsList[id];
        }

        // POST api/<MahasiswaController>
        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa )
        {
            mhsList.Add(mahasiswa);
        }

        // PUT api/<MahasiswaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa mahasiswa)
        {
            mhsList[id] = mahasiswa;
        }

        // DELETE api/<MahasiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mhsList.RemoveAt(id);
        }
    }
}
