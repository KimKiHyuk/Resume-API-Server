using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIServer.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class ResumeController : ControllerBase
    {
        public ResumeController()
        {
        }


        [HttpGet]
        [Route("{id}")]
        public AboutMeModelDto AboutMe(int id)
        {
            return new AboutMeModelDto();
        }

        [HttpGet]
        public IEnumerable<AboutMeModelDto> AboutMe()
        {
            return new List<AboutMeModelDto>() {new AboutMeModelDto(), new AboutMeModelDto()};
        }


        [HttpPost]
        public ActionResult<AboutMeModelDto> AboutMe([FromBody] AboutMeModelDto dto)
        {
            var jsonString = JsonSerializer.Serialize<AboutMeModelDto>(dto);

            dto.HashCode = jsonString.GetHashCode();

            return CreatedAtAction("AboutMe", dto);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult AboutMe(long id) 
        {
            // Delete from db by hash
            if (true) {
                return Ok();
            }
            else {
                return NotFound();
            }
        }
    }
}
