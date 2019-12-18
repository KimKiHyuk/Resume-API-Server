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
using System.Net.Http;
using APIServer.API;
using APIServer.HTTP;

namespace APIServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResumeController : ControllerBase
    {
        private readonly IHTTPHelper httpHelper;
        private readonly DatabaseContext databaseContext;

        public ResumeController(DatabaseContext databaseContext, IHTTPHelper httpHelper)
        { 
            this.databaseContext = databaseContext;
            this.httpHelper = httpHelper;
        }

        [HttpGet]
        [Route("AboutMe")]
        public async Task<ActionResult> GetAboutMe()
        {
            var response = await httpHelper.GetDataFromDjango(APISet.BACKEND_API_ABOUTME);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return Ok(content);
            }

           return NotFound();
        }

        [HttpPost]
        [Route("AboutMe")]
        public ActionResult<AboutMeModelDto> PostAboutMe([FromBody] AboutMeModelDto dto)
        {
            return BadRequest();
        }

        [HttpGet]
        [Route("Career")]
        public async Task<ActionResult> GetCareer()
        {
            Console.WriteLine("trigg");
            var response = await httpHelper.GetDataFromDjango(APISet.BACKEND_API_CAREER);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return Ok(content);
            }

            return NotFound();
        }

        [HttpPost]
        [Route("Career")]
        public ActionResult<List<CareerModelDto>> PostCareer([FromBody] List<CareerModelDto> dto)
        {
            return BadRequest();
        }

        [HttpGet]
        [Route("Education")]
        public async Task<ActionResult> GetEducation()
        {
            var response = await httpHelper.GetDataFromDjango(APISet.BACKEND_API_EDUCATION);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return Ok(content);
            }

            return NotFound();
        }

        [HttpPost]
        [Route("Education")]
        public ActionResult<List<EducationModelDto>> PostEducation([FromBody] List<EducationModelDto> dto)
        {
            return BadRequest();
        }

        [HttpGet]
        [Route("Project")]
        public async Task<ActionResult> GetProject()
        {
            var response = await httpHelper.GetDataFromDjango(APISet.BACKEND_API_PROJECT);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return Ok(content);
            }

            return NotFound();
        }

        [HttpPost]
        [Route("Project")]
        public ActionResult<List<ProjectModelDto>> PostProject([FromBody] List<ProjectModelDto> dto)
        {
            return BadRequest();
        }

        [HttpGet]
        [Route("Skill")]
        public async Task<ActionResult> GetSkill()
        {
            var response = await httpHelper.GetDataFromDjango(APISet.BACKEND_API_SKILL);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return Ok(content);
            }

            return NotFound();
        }

        [HttpPost]
        [Route("Skill")]
        public ActionResult<List<SkillModelDto>> PostSkill([FromBody] List<SkillModelDto> dto)
        {
            return BadRequest();
        }
    }
}