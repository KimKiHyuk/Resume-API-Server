using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIServer.Model
{

    [Table("Project")]
    public class ProjectModelDto
    {

        public ProjectModelDto()
        {

        }
        public ProjectModelDto(string Title, string Description, string DemoUrl, string Github)
        {
            this.Title = Title;
            this.Description = Description;
            this.DemoUrl = DemoUrl;
            this.Github = Github;
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLengthAttribute]
        public string Description { get; set; }

        [MaxLength(500)]
        public string DemoUrl { get; set; }

        [MaxLength(500)]
        public string Github { get; set; }
    }
}
