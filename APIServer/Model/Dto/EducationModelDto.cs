using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIServer.Model
{
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

        public string Insititute { get; set; }
        public string Type { get; set; }
        public string Period { get; set; }
        public string Description { get; set; }
    }
}
