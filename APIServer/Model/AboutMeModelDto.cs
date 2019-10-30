using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIServer.Model
{

    [Table("AboutMe")]
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

        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }


        [MaxLength(50)]
        public string Job { get; set; }


        [MaxLength(50)]
        public string Nationality { get; set; }


        [MaxLengthAttribute]
        public string Introduce { get; set; }
    }
}