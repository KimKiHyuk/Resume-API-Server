using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIServer.Model
{

    [Table("Career")]
    public class CareerModelDto
    {
        public CareerModelDto()
        {

        }
        public CareerModelDto(string Company, string Experience, string Period, string Position)
        {
            this.Position = Position;
            this.Period = Period;
            this.Experience = Experience;
            this.Company = Company;
        }
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Company { get; set; }

        [MaxLength(300)]
        public string Experience { get; set; }

        [MaxLength(50)]
        public string Period { get; set; }

        [MaxLength(50)]
        public string Position { get; set; }
    }
}