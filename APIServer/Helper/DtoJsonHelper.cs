using System.Collections.Generic;
using System.Text.Json;
using APIServer.Model;

namespace APIServer.Helper
{
    public static class DtoJsonHelper
    {
        public static JsonDomainModel Dto2JsonModel<T>(T dto)
        {
            var jsonString = JsonSerializer.Serialize<T>(dto);

            return new JsonDomainModel(jsonString);
        }

        public static T JsonDomainModel2Dto<T>(JsonDomainModel model)
        {
            return JsonSerializer.Deserialize<T>(model.Json);
        }
        
        public static List<T> JsonDomainModel2Dto<T>(List<JsonDomainModel> models)
        {
            List<T> dto = new List<T>();
            foreach(var model in models) {
                dto.Add(JsonDomainModel2Dto<T>(model));
            }
            return dto;
        }
    }
}