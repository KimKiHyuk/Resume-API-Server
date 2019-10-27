using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIServer.Model {

    [Table("AboutMe")]
    public class AboutMeModelDto : BaseModelDto
    {
        
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