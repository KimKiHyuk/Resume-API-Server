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
        [Route("AboutMe/last")]
        public ActionResult<AboutMeModelDto> GetLastAboutMe()
        {
            var request = this.databaseContext.AboutMe.FirstOrDefault(element => element.Id == this.databaseContext.AboutMe.Max(element => element.Id));

            if (request == null)
            {
                return NotFound();
            }

            return Ok(request);
        }

        [HttpPost]
        [Route("AboutMe")]
        public ActionResult<AboutMeModelDto> PostAboutMe([FromBody] AboutMeModelDto dto)
        {
            var request = this.databaseContext.AboutMe.Add(dto);
            this.databaseContext.SaveChanges();

            return CreatedAtAction("PostAboutMe", request.Entity);
        }


        [HttpGet]
        [Route("Career/last")]
        public ActionResult<CareerModelDto> GetLastCareer()
        {
            var request = this.databaseContext.Career.FirstOrDefault(element => element.Id == this.databaseContext.Career.Max(element => element.Id));

            if (request == null)
            {
                return NotFound();
            }

            return Ok(request);
        }

        [HttpPost]
        [Route("Career")]
        public ActionResult<CareerModelDto> PostCareer([FromBody] CareerModelDto dto)
        {
            var request = this.databaseContext.Career.Add(dto);
            this.databaseContext.SaveChanges();

            return CreatedAtAction("PostCareer", request.Entity);
        }

        [HttpGet]
        [Route("Education/last")]
        public ActionResult<EducationModelDto> GetLastEducation()
        {
            var request = this.databaseContext.Education.FirstOrDefault(element => element.Id == this.databaseContext.Education.Max(element => element.Id));

            if (request == null)
            {
                return NotFound();
            }

            return Ok(request);
        }

        [HttpPost]
        [Route("Education")]
        public ActionResult<EducationModelDto> PostEducation([FromBody] EducationModelDto dto)
        {
            var request = this.databaseContext.Education.Add(dto);
            this.databaseContext.SaveChanges();

            return CreatedAtAction("PostEducation", request.Entity);
        }

        [HttpGet]
        [Route("Project/last")]
        public ActionResult<ProjectModelDto> GetLastProject()
        {
            var request = this.databaseContext.Project.FirstOrDefault(element => element.Id == this.databaseContext.Project.Max(element => element.Id));

            if (request == null)
            {
                return NotFound();
            }

            return Ok(request);
        }

        [HttpPost]
        [Route("Project")]
        public ActionResult<ProjectModelDto> PostProject([FromBody] ProjectModelDto dto)
        {
            var request = this.databaseContext.Project.Add(dto);
            this.databaseContext.SaveChanges();

            return CreatedAtAction("PostProject", request.Entity);
        }

        [HttpGet]
        [Route("Skill/last")]
        public ActionResult<BaseJsonModel> GetLastSkill()
        {
            var request = this.databaseContext.Skill.FirstOrDefault(element => element.Id == this.databaseContext.Skill.Max(element => element.Id));

            request.HashTags = JsonSerializer.Deserialize<List<HashTag>>(request.SerializedHashTag);
            if (request == null)
            {
                return NotFound();
            }

            return Ok(request);
        }

        [HttpPost]
        [Route("Skill")]
        public ActionResult<BaseJsonModel> PostSkill([FromBody] SkillModelDto dto)
        {

            dto.SerializedHashTag = JsonSerializer.Serialize<List<HashTag>>(dto.HashTags);

            var request = this.databaseContext.Skill.Add(dto);
            this.databaseContext.SaveChanges();

            return CreatedAtAction("PostSkill", request.Entity);
        }
    }
}