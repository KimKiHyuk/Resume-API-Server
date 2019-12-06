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
        public SkillModelDto(string Name, string ImageSource, int Proficiency, List<HashTag> HashTags)
        {
            this.Name = Name;
            this.ImageSource = ImageSource;
            this.Proficiency = Proficiency;
            this.HashTags = HashTags;
        }

        public string Name { get; set; }
        public string ImageSource { get; set; }

        public int Proficiency { get; set; }

        public List<HashTag> HashTags { get; set; }
    }

    public class HashTag
    {
        public string Tag { get; set; }
    }
}
