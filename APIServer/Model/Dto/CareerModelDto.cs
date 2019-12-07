using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIServer.Model
{

    [Table("Career")]
    public class CareerModelDto
    {
        public CareerModelDto(string Company, string Experience, string Period, string Position)
        {
            this.Company = Company;
            this.Experience = Experience;
            this.Period = Period;
            this.Position = Position;
        }

        public string Company { get; set; }

        public string Experience { get; set; }

        public string Period { get; set; }

        public string Position { get; set; }

    }
}