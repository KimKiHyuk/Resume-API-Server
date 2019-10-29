using System.Text.Json;
using APIServer.Model;

namespace APIServer.Helper
{
    public static class DtoJsonHelper {
        public static BaseJsonModel Dto2JsonModel<T>(T dto) 
        {
            var jsonString = JsonSerializer.Serialize<T>(dto);

            return new BaseJsonModel(jsonString);
        }
    }
}