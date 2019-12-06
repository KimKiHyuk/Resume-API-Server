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
        public ProjectModelDto(string Category, string Title, string Subtitle, string Github, string Color)
        {
            this.Category = Category;
            this.Title = Title;
            this.Subtitle = Subtitle;
            this.Github = Github;
            this.Color = Color;
        }

        public string Category { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Color { get; set; }
        public string Github { get; set; }
    }
}
