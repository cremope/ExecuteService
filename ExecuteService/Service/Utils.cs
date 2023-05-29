using Newtonsoft.Json;
using RestSharp;

namespace ExecuteService.Service
{
    public static class Utils
    {
        private static RestClient client;
        private static RestRequest endpoint;
        private static RestResponse response;
        public static RestClient Client(string urlBase)
        {
            client = new RestClient(urlBase);
            return client;
        }

        public static RestRequest Endpoint(string path)
        {
            endpoint = new RestRequest(path);
            return endpoint;
        }

        public static void Header_ApiKey()
        {
            endpoint.AddParameter("api_key", "special-key", ParameterType.HttpHeader);
        }

        public static void Method(Method method)
        {
            endpoint.Method = method;
        }

        public static void Request(object body)
        {
            endpoint.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
        }

        public static RestResponse Execute()
        {
            response = client.Execute(endpoint);
            return response;
        }
    }
}
