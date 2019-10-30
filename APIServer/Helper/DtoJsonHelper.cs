using System.Collections.Generic;
using System.Text.Json;
using APIServer.Model;

namespace APIServer.Helper
{
    public static class DtoJsonHelper
    {
        public static BaseJsonModel Dto2JsonModel<T>(T dto)
        {
            var jsonString = JsonSerializer.Serialize<T>(dto);

            return new BaseJsonModel(jsonString);
        }

        public static T BaseJsonModel2Dto<T>(BaseJsonModel model)
        {
            return JsonSerializer.Deserialize<T>(model.Json);
        }
        public static List<T> BaseJsonModel2Dto<T>(List<BaseJsonModel> models)
        {
            List<T> dto = new List<T>();
            foreach(var model in models) {
                dto.Add(BaseJsonModel2Dto<T>(model));
            }
            return dto;
        }
    }
}