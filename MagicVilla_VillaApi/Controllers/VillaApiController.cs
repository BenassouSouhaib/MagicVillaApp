using MagicVilla_VillaApi.Data;
using MagicVilla_VillaApi.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaApi.Controllers
{
    [Route("api/VillApi")]
    [ApiController]
    public class VillaApiController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<VillaDto>> GetVillas() {

            return Ok(VillaStore.villaList);
        }

        [HttpGet("id")]
        //[ProducesResponseType(200)]
        //[ProducesResponseType(404)]
        //[ProducesResponseType(400)]
        public ActionResult<VillaDto> GetVillas(int id) {

            var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
            if (id == 0) return BadRequest();
            if (villa == null) return NotFound();

            return Ok(villa);
        }

    }
}
