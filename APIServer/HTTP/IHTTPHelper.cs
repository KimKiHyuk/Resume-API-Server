using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIServer.HTTP {
    public interface IHTTPHelper {
       Task<HttpResponseMessage> GetDataFromDjango(string url);
    }
}