using System.ComponentModel.DataAnnotations;

namespace APIServer.Model {
    public class ProjectDomainModel : JsonDomainModel {
        public ProjectDomainModel(string json) : base(json) {

        }
    }
}