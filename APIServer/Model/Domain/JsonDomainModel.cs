using System.ComponentModel.DataAnnotations;

namespace APIServer.Model
{
    public class JsonDomainModel
    {
        public JsonDomainModel() {
            
        }
        public JsonDomainModel(string Json) {
            this.Json = Json;
            this.HashCode = this.Json.GetHashCode();
        }
        
        [Key]
        public int Id { get; set; }

        [MaxLengthAttribute]
        public string Json { get; set; }

        public int HashCode {get; set; }

    }
}