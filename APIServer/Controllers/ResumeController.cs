using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using APIServer.Database;
using APIServer.Helper;
using APIServer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIServer.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class ResumeController : ControllerBase
    {
        private readonly DatabaseContext databaseContext;

        public ResumeController(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<AboutMeModelDto> AboutMe(int id)
        {
            var request = this.databaseContext.AboutMe.Where(element => element.Id == id).SingleOrDefault();

            if (request == null)
            {
                return NotFound();
            }

            return Ok(request);
        }

        [HttpGet]
        public IEnumerable<BaseJsonModel> AboutMe()
        {
            return this.databaseContext.AboutMe.ToList();
        }


        [HttpPost]
        public ActionResult<AboutMeModelDto> AboutMe([FromBody] AboutMeModelDto dto)
        {
            var json = DtoJsonHelper.Dto2JsonModel<AboutMeModelDto>(dto);
            
            var ret = this.databaseContext.AboutMe.Add(json);
            this.databaseContext.SaveChanges();

            return CreatedAtAction("AboutMe", ret.Entity);
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult AboutMe(long id)
        {
            var request = this.databaseContext.AboutMe.Where(element => element.Id == id).SingleOrDefault();

            if (request == null) {
                return NotFound();
            }

            this.databaseContext.AboutMe.Remove((request));
            this.databaseContext.SaveChanges();

            return Ok();
        }
    }
}