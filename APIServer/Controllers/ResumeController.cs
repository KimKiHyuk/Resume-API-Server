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
            // var request = this.databaseContext.AboutMe.FirstOrDefault(element => element.Id == this.databaseContext.AboutMe.Max(element => element.Id));
            var request = new AboutMeModelDto("kim", "hi", "student", "https://avatars1.githubusercontent.com/u/32787543?s=460&v=4", "hello"));
            if (request == null)
            {
                return NotFound();
            }

            var mockDb = JsonSerializer.Serialize<AboutMeModelDto>(request);
            var dto = JsonSerializer.Deserialize<AboutMeModelDto>(mockDb);


            return Ok(dto);
        }

        [HttpPost]
        [Route("AboutMe")]
        public ActionResult<AboutMeModelDto> PostAboutMe([FromBody] AboutMeModelDto dto)
        {
            var json = JsonSerializer.Serialize<AboutMeModelDto>(dto);
            var domain = new AboutMeDomainModel(json);
            var request = this.databaseContext.AboutMe.Add(domain);
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
            var dto = JsonSerializer.Deserialize<List<CareerModelDto>>(request.Json);


            return Ok(dto);
        }

        [HttpPost]
        [Route("Career")]
        public ActionResult<List<CareerModelDto>> PostCareer([FromBody] List<CareerModelDto> dto)
        {
            var json = JsonSerializer.Serialize<List<CareerModelDto>>(dto);
            var domain = new CareerDomainModel(json);

            var request = this.databaseContext.Career.Add(domain);
            this.databaseContext.SaveChanges();

            return CreatedAtAction("PostCareer", request.Entity);
        }

        [HttpGet]
        [Route("Education/last")]
        public ActionResult<List<EducationModelDto>> GetLastEducation()
        {
            var request = this.databaseContext.Education.FirstOrDefault(element => element.Id == this.databaseContext.Education.Max(element => element.Id));

            if (request == null)
            {
                return NotFound();
            }


            var dto = JsonSerializer.Deserialize<List<EducationModelDto>>(request.Json);

            return Ok(dto);
        }

        [HttpPost]
        [Route("Education")]
        public ActionResult<List<EducationModelDto>> PostEducation([FromBody] List<EducationModelDto> dto)
        {
            var json = JsonSerializer.Serialize<List<EducationModelDto>>(dto);
            var domain = new EducationDomainModel(json);

            var request = this.databaseContext.Education.Add(domain);
            this.databaseContext.SaveChanges();

            return CreatedAtAction("PostEducation", request.Entity);
        }

        [HttpGet]
        [Route("Project/last")]
        public ActionResult<List<ProjectModelDto>> GetLastProject()
        {
            var request = this.databaseContext.Project.FirstOrDefault(element => element.Id == this.databaseContext.Project.Max(element => element.Id));

            if (request == null)
            {
                return NotFound();
            }

            var dto = JsonSerializer.Deserialize<List<ProjectModelDto>>(request.Json);


            return Ok(dto);
        }

        [HttpPost]
        [Route("Project")]
        public ActionResult<List<ProjectModelDto>> PostProject([FromBody] List<ProjectModelDto> dto)
        {
            var json = JsonSerializer.Serialize<List<ProjectModelDto>>(dto);
            var domain = new ProjectDomainModel(json);
            var request = this.databaseContext.Project.Add(domain);
            this.databaseContext.SaveChanges();

            return CreatedAtAction("PostProject", request.Entity);
        }

        [HttpGet]
        [Route("Skill/last")]
        public ActionResult<List<SkillModelDto>> GetLastSkill()
        {
            var request = this.databaseContext.Skill.FirstOrDefault(element => element.Id == this.databaseContext.Skill.Max(element => element.Id));

            if (request == null)
            {
                return NotFound();
            }

            var dto = JsonSerializer.Deserialize<List<SkillModelDto>>(request.Json);


            return Ok(dto);
        }

        [HttpPost]
        [Route("Skill")]
        public ActionResult<List<SkillModelDto>> PostSkill([FromBody] List<SkillModelDto> dto)
        {

            var json = JsonSerializer.Serialize<List<SkillModelDto>>(dto);
            var domain = new SkillDomainModel(json);

            var request = this.databaseContext.Skill.Add(domain);
            this.databaseContext.SaveChanges();

            return CreatedAtAction("PostSkill", request.Entity);
        }
    }
}