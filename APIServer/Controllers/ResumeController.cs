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
            var fromDb = new AboutMeModelDto("김기혁", "Welcome to Key's Resume!",
                                              "소프트웨어 엔지니어",
                                              "https://avatars1.githubusercontent.com/u/32787543?s=460&v=4",
                                              @"새로운 기술을 배우는것을 좋아합니다.
                                              데이터 파이프라이닝, 분산처리시스템, 인메모리 시스템에 관심이 많습니다.
                                              크로스플랫폼에서의 개발과 배포를 좋아합니다. Microsoft의 .Net core와 Azure, Google의 flutter에 관심이 많습니다.
                                              공부하고 배운 내용을 나누는것을 좋아합니다. 개발 관련 내용들을 누구나 볼 수 있게 Medium에 정리하고 있습니다.
                                              ");
            if (fromDb == null)
            {
                return NotFound();
            }

            // when after attached db, this line should be removed
            var dbprocessing = JsonSerializer.Serialize<AboutMeModelDto>(fromDb);

            var dto = JsonSerializer.Deserialize<AboutMeModelDto>(dbprocessing);


            return Ok(dto);
        }

        [HttpPost]
        [Route("AboutMe")]
        public ActionResult<AboutMeModelDto> PostAboutMe([FromBody] AboutMeModelDto dto)
        {

            return BadRequest();
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
            var fromDb = new List<CareerModelDto>()
            {
                new CareerModelDto(
                    Company: "한림대학교 운영체제 연구실"
                    ,Experience: @"Apache hadoop, spark cluster 구축
                                Linux 커널데이터를 암호화하는 캐릭터 디바이스 드라이버 개발
                                안드로이드 파일 관리 어플리케이션 개발"
                    ,Period:"2016-02 ~ 2017-06"
                    ,Position: "학부연구생"),
                new CareerModelDto(
                    Company: "Software Maestro"
                    ,Experience: @"안드로이드 의료처방전 관리 어플리케이션 개발
                                 - opencv, ocr를 활용해 처방전 글자인식 모듈 개발"
                    ,Period:"2017-06 ~ 2017-12"
                    ,Position: "8기"),
                new CareerModelDto(
                    Company: "국군사이버사령부"
                    ,Experience: @"Windows PC 클라이언트 개발
                                - C#, WPF를 활용한 Windows application 개발
                                - C/C++, WDM를 활용한 Windows minifilter driver 유지보수"
                    ,Period:"2018-02 ~ 2019-10"
                    ,Position: "소프트웨어 개발병 (육군 병장)"),
            };

            if (fromDb == null)
            {
                return NotFound();
            }

            return Ok(fromDb);
        }

        [HttpPost]
        [Route("Career")]
        public ActionResult<List<CareerModelDto>> PostCareer([FromBody] List<CareerModelDto> dto)
        {

            return BadRequest();
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
            var fromDb = new List<EducationModelDto>() {
                new EducationModelDto(
                    Insititute: "한림대학교 컴퓨터공학과",
                    Type:"학사과정",
                    Period: "2015-03 ~ 현재",
                    Description: @"전공학점 4.2/4.5
            운영체제 연구실 학부연구생으로 활동함
            학술동아리 C.愛.랑에서 임베디드팀 팀장을 엮임함.
            프로그래밍 강의 경험"),
               new EducationModelDto(
                    Insititute: "Griffith univeristy",
                    Type:"교육 연수",
                    Period: "2016-12 ~ 2017-02",
                    Description: @"호주 골드코스트에 위치
            Unity programming, Game AI, 영어를 학습함."),
                new EducationModelDto(
                    Insititute: "강원창조경제혁신센터 BIGTORY 3기",
                    Type:"교육",
                    Period: "2017-02 ~ 2017-05",
                    Description: @"빅데이터 교육 프로그램에 참여
            Microsoft Azure, Hortonwork dataplatform, 데이터분석에 대해서 학습함.")

            };
            return Ok(fromDb);
        }

        [HttpPost]
        [Route("Education")]
        public ActionResult<List<EducationModelDto>> PostEducation([FromBody] List<EducationModelDto> dto)
        {

            return BadRequest();
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
            var dto = new List<ProjectModelDto>() {
               new ProjectModelDto(
                   Category: "Web-Frontend",
                   Title:"Vue.js기반 이력서 웹앱",
                   Subtitle: "개인 맞춤화된 이력서 SPA 웹앱 프로젝트. Nuxt, vuex등 vue 생태계를 활용해 개발 javascript ES6 채용",
                   Github: "https://github.com/KimKiHyuk/Vuetiful-Resume",
                   Color: "green lighten-3"),
                new ProjectModelDto(
                   Category: "Web-Backend",
                   Title: ".NET core 이력서 API 서버",
                   Subtitle: @"Vue.js기반 이력서 웹앱의 API Server. REST API를 준수하며 개발함. 
                   Xunit으로 테스트를 하고 MS-SQL을 데이터베이스로 사용, C#을 사용함.",
                   Github: "https://github.com/KimKiHyuk/Resume-API-Server",
                   Color: "light-blue darken-4"),
                new ProjectModelDto(
                   Category: "Web-Backend",
                   Title:"CQRS 패턴을 적용한 API 서버",
                   Subtitle: "쿼리와 커맨드 로직을 분리한 REST API 서버",
                   Github: "https://github.com/KimKiHyuk/.NET-Core-CQRS-API-server",
                   Color: "light-blue darken-4"),
                new ProjectModelDto(
                   Category: "data-Backend",
                   Title:"Go를 사용한 로그 생성 서버",
                   Subtitle: "데이터 파이프라인에 흘려보낼 로그 생성을 위한 프로젝트. Go언어를 사용함",
                   Github: "https://github.com/KimKiHyuk/LogGenerator",
                   Color: "indigo darken-1"),
                new ProjectModelDto(
                   Category: "Mobile Application",
                   Title:"flutter를 사용한 넷플릭스 계정 공유 안드로이드/IOS 어플리케이션",
                   Subtitle: @"넷플릭스 서비스를 저렴하게 이용할 수 있도록 도와주는 유저끼리 채팅방을 만들어주는 프로젝트. 
                   Flutter를 이용해 Android, IOS에서 동작하도록 만들었고, baas로 firebase를 사용. 플레이스토어에 정식 배포함. ",
                   Github: "https://github.com/KimKiHyuk/Netflix-Chat",
                   Color: "cyan "),
                new ProjectModelDto(
                   Category: "design pattern",
                   Title:"디자인패턴 구현 프로젝트",
                   Subtitle: @"다양한 디자인패턴을 C#를 이용해 실제로 구현해보고 쓰임을 알아보는 프로젝트",
                   Github: "https://github.com/KimKiHyuk/DesignPattern",
                   Color: "teal darken-3"),
                new ProjectModelDto(
                   Category: "algorithm",
                   Title:"알고리즘 구현 프로젝트",
                   Subtitle: @"다양한 알고리즘을 C++를 이용해 실제로 구현해보고 쓰임을 알아보는 프로젝트",
                   Github: "https://github.com/KimKiHyuk/DataStructure-Algorithm",
                   Color: "teal darken-3"),
                new ProjectModelDto(
                   Category: "Windows client",
                   Title:"PC 보안 체계 (軍)",
                   Subtitle: @"軍 PC를 보호하는 체계. C#, WPF를 활용해 개발, C++ WDM를 활용해 윈도우즈 미니필터 드라이버 유지보수",
                   Github: "_blank",
                   Color: "cyan lighten-3"),
           };


            return Ok(dto);
        }

        [HttpPost]
        [Route("Project")]
        public ActionResult<List<ProjectModelDto>> PostProject([FromBody] List<ProjectModelDto> dto)
        {

            return BadRequest();
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
            var dto = new List<SkillModelDto>()
            {
                new SkillModelDto(
                    Name: "Javascript",
                    ImageSource: "https://img1.daumcdn.net/thumb/R800x0/?scode=mtistory2&fname=https%3A%2F%2Ft1.daumcdn.net%2Fcfile%2Ftistory%2F2370C63B5694884912",
                    Proficiency: 3,
                    HashTags: new List<HashTag>() {
                        new HashTag("ES5"),
                        new HashTag("ES6")
                    }),
                new SkillModelDto(
                    Name: "C#",
                    ImageSource: "https://upload.wikimedia.org/wikipedia/commons/8/82/C_Sharp_logo.png",
                    Proficiency: 4,
                    HashTags: new List<HashTag>() {
                        new HashTag("C# 6.0"),
                    }),
                new SkillModelDto(
                    Name: "C++",
                    ImageSource: "https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/ISO_C%2B%2B_Logo.svg/1200px-ISO_C%2B%2B_Logo.svg.png",
                    Proficiency: 3,
                    HashTags: new List<HashTag>() {
                        new HashTag("C++11"),
                    }),
                new SkillModelDto(
                    Name: "Go",
                    ImageSource: "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Go_Logo_Aqua.svg/1200px-Go_Logo_Aqua.svg.png",
                    Proficiency: 2,
                    HashTags: new List<HashTag>() {
                        new HashTag("HTTP"),
                    }),
                new SkillModelDto(
                    Name: "Dart",
                    ImageSource: "https://pbs.twimg.com/profile_images/993555605078994945/Yr-pWI4G.jpg",
                    Proficiency: 3,
                    HashTags: new List<HashTag>() {
                        new HashTag("Flutter"),
                    }),
                new SkillModelDto(
                    Name: "SQL",
                    ImageSource: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSE8pz8Tagj_tW0gz7_ezmxJkB9i6gMF8Z6qLSQJ1W5iP_t-xTm&s",
                    Proficiency: 3,
                    HashTags: new List<HashTag>() {
                        new HashTag("RDBMS"),
                    }),
            };


            return Ok(dto);
        }

        [HttpPost]
        [Route("Skill")]
        public ActionResult<List<SkillModelDto>> PostSkill([FromBody] List<SkillModelDto> dto)
        {
            return BadRequest();
            var json = JsonSerializer.Serialize<List<SkillModelDto>>(dto);
            var domain = new SkillDomainModel(json);

            var request = this.databaseContext.Skill.Add(domain);
            this.databaseContext.SaveChanges();

            return CreatedAtAction("PostSkill", request.Entity);
        }
    }
}