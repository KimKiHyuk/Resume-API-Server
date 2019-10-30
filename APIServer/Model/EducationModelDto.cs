using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIServer.Model
{

    [Table("Education")]
    public class EducationModelDto
    {
        public EducationModelDto()
        {

        }
        public EducationModelDto(string Insititute, string Type, string Period, string Description)
        {
            this.Insititute = Insititute;
            this.Type = Type;
            this.Period = Period;
            this.Description = Description;
        }
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Insititute { get; set; }

        [MaxLength(50)]
        public string Type { get; set; }

        [MaxLength(50)]
        public string Period { get; set; }

        [MaxLengthAttribute]
        public string Description { get; set; }
    }
}
