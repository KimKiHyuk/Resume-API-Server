using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIServer.Model
{
    public class AboutMeModelDto
    {
        public AboutMeModelDto()
        {

        }
        public AboutMeModelDto(string Name, string Greet, string Job, string ProfileSrc, string Introduce)
        {
            this.Name = Name;
            this.Greet = Greet;
            this.Job = Job;
            this.ProfileSrc = ProfileSrc;
            this.Introduce = Introduce;
        }

        public string Name { get; set; }

        public string Greet { get; set; }

        public string Job { get; set; }

        public string ProfileSrc { get; set; }

        public string Introduce { get; set; }
    }
}