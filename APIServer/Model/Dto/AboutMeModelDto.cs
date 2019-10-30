using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIServer.Model
{
    public class AboutMeModelDto
    {
        public AboutMeModelDto()
        {

        }
        public AboutMeModelDto(string Name, string Job, string Nationality, string Introduce)
        {
            this.Name = Name;
            this.Job = Job;
            this.Nationality = Nationality;
            this.Introduce = Introduce;
        }

        public string Name { get; set; }

        public string Job { get; set; }

        public string Nationality { get; set; }

        public string Introduce { get; set; }
    }
}