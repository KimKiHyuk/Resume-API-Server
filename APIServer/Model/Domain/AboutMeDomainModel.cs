using System.ComponentModel.DataAnnotations;

namespace APIServer.Model {
    public class AboutMeDomainModel : JsonDomainModel {
        public AboutMeDomainModel(string json) : base(json) {}
    }
}