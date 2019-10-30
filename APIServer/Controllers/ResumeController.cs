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
    [Route("[controller]")]
    public class ResumeController : ControllerBase
    {
        private readonly DatabaseContext databaseContext;

        public ResumeController(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        [HttpGet]
        [Route("AboutMe/{id}")]
        public ActionResult<AboutMeModelDto> GetAboutMeById(int id)
        {
            var request = this.databaseContext.AboutMe.Where(element => element.Id == id).SingleOrDefault();
                
            if (request == null)
            {
                return NotFound();
            }

            return Ok(request);
        }

        [HttpGet]
        [Route("AboutMe/last")]
        public ActionResult<AboutMeModelDto> GetAboutMeLast()
        {
            var request = this.databaseContext.AboutMe.FirstOrDefault(element => element.Id == this.databaseContext.AboutMe.Max(element => element.Id));
            
            if (request == null)
            {
                return NotFound();
            }

            var dto = DtoJsonHelper.BaseJsonModel2Dto<AboutMeModelDto>(request);

            return Ok(dto);
        }

        [HttpGet]
        [Route("AboutMe")]
        public IEnumerable<AboutMeModelDto> GetAboutMeAll()
        {
            var json = this.databaseContext.AboutMe.ToList();

            if (json.Count <= 0) {
                return new List<AboutMeModelDto>();
            }

            return DtoJsonHelper.BaseJsonModel2Dto<AboutMeModelDto>(json);
        }


        [HttpPost]
        [Route("AboutMe")]
        public ActionResult<AboutMeModelDto> PostAboutMe([FromBody] AboutMeModelDto dto)
        {
            var json = DtoJsonHelper.Dto2JsonModel<AboutMeModelDto>(dto);
            
            var ret = this.databaseContext.AboutMe.Add(json);
            this.databaseContext.SaveChanges();

            return CreatedAtAction("PostAboutMe", ret.Entity);
        }

        [HttpDelete]
        [Route("AboutMe/{id}")]
        public ActionResult DeleteAboutMeById(long id)
        {
            var request = this.databaseContext.AboutMe.Where(element => element.Id == id).SingleOrDefault();

            if (request == null) {
                return NotFound();
            }

            this.databaseContext.AboutMe.Remove((request));
            this.databaseContext.SaveChanges();

            return Ok();
        }



        [HttpGet]
        [Route("Career/last")]
        public ActionResult<CareerModelDto> GetCareerLast()
        {
            var request = this.databaseContext.Career.FirstOrDefault(element => element.Id == this.databaseContext.Career.Max(element => element.Id));
            
            if (request == null)
            {
                return NotFound();
            }

            var dto = DtoJsonHelper.BaseJsonModel2Dto<CareerModelDto>(request);

            return Ok(dto);
        }

        [HttpPost]
        [Route("Career")]
        public ActionResult<CareerModelDto> PostCareer([FromBody] CareerModelDto dto)
        {
            var json = DtoJsonHelper.Dto2JsonModel<CareerModelDto>(dto);
            
            var ret = this.databaseContext.Career.Add(json);
            this.databaseContext.SaveChanges();

            return CreatedAtAction("PostCareer", ret.Entity);
        }
    }
}