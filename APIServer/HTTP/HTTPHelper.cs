using System;
using System.Net.Http;
using APIServer.API;
using System.Threading.Tasks;

namespace APIServer.HTTP {
    public class HTTPHelper : IHTTPHelper {

        HttpClient client;
        private readonly IHttpClientFactory clientFactory;

        public HTTPHelper(IHttpClientFactory clientFactory) {
            this.client = clientFactory.CreateClient();
            this.clientFactory = clientFactory;
        }
        public async Task<HttpResponseMessage> GetDataFromDjango(string url) {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("Accept", "application/json");

            return await client.SendAsync(request);
        }
    }
}