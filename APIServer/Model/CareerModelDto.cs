using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIServer.Model {

    [Table("Career")]
    public class CareerModelDto
    {
        public CareerModelDto() {
            
        }
        public CareerModelDto(string Company, string Experience, string Period, string Position) {
            this.Position = Position;
            this.Period = Period;
            this.Experience = Experience;
            this.Company = Company;
        }

        public string Company { get; set; }

        public string Experience { get; set; }

        public string Period { get; set; }

        public string Position { get; set; }
    }
}