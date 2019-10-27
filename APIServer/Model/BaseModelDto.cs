using System.ComponentModel.DataAnnotations;

namespace APIServer.Model
{
    public class BaseModelDto
    {
        [Key]
        public int Id { get; set; }

    }
}