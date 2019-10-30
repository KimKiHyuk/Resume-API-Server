using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using APIServer.Helper;
using System.Text.Json;
namespace APIServer.Model
{

    [Table("Skill")]
    public class SkillModelDto
    {

        public SkillModelDto()
        {

        }
        public SkillModelDto(string Name, string ImageUrl, int Proficiency, List<HashTag> HashTags)
        {
            this.Name = Name;
            this.ImageUrl = ImageUrl;
            this.Proficiency = Proficiency;
            this.HashTags = HashTags;
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string ImageUrl { get; set; }

        public int Proficiency { get; set; }

        public List<HashTag> HashTags { get; set; }

        [MaxLengthAttribute]
        public string SerializedHashTag { get; set; }
    }

    [NotMapped]
    public class HashTag
    {
        public string Tag { get; set; }
    }
}
