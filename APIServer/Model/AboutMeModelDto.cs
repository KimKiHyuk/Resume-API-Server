using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIServer.Model {

    [Table("AboutMe")]
    public class AboutMeModelDto : BaseModelDto
    {
        public AboutMeModelDto() {
            
        }
        public AboutMeModelDto(string Name, string Job, string Nationality, string Introduce) {
            this.Name = Name;
            this.Job = Job;
            this.Nationality = Nationality;
            this.Introduce = Introduce;
        }

        [MaxLength(10)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string Job { get; set; }

        [MaxLength(20)]
        public string Nationality { get; set; }

        [MaxLengthAttribute]
        public string Introduce { get; set; }
    }
}