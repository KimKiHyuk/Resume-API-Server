using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIServer.Model {

    public class AboutMeModelDto : BaseModelDto
    {
        [MaxLength(20)]
        public string Name { get; set; }
    }
}