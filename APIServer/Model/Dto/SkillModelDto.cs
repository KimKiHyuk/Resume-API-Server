using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using APIServer.Helper;
using System.Text.Json;
namespace APIServer.Model
{
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

        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public int Proficiency { get; set; }

        public List<HashTag> HashTags { get; set; }
    }

    public class HashTag
    {
        public string Tag { get; set; }
    }
}
