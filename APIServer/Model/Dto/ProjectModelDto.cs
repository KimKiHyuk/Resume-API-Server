using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIServer.Model
{
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

        public string Title { get; set; }
        public string Description { get; set; }
        public string DemoUrl { get; set; }
        public string Github { get; set; }
    }
}
