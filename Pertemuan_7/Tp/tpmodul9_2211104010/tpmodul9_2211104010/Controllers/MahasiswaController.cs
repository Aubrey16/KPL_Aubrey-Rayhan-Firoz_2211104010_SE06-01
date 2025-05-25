using Microsoft.AspNetCore.Mvc;
using tpmodul9_2211104010.Models;

namespace tpmodul9_2211104010.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa("Stephen Curry", "1302000002"),
            new Mahasiswa("LeBron James", "1302000003")
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> GetAll()
        {
            return Ok(mahasiswaList);
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound("Index tidak ditemukan");

            return Ok(mahasiswaList[index]);
        }

        [HttpPost]
        public ActionResult AddMahasiswa([FromBody] Mahasiswa mhs)
        {
            mahasiswaList.Add(mhs);
            return Ok("Mahasiswa ditambahkan");
        }

        [HttpDelete("{index}")]
        public ActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= mahasiswaList.Count)
                return NotFound("Index tidak ditemukan");

            mahasiswaList.RemoveAt(index);
            return Ok("Mahasiswa dihapus");
        }
    }
}
