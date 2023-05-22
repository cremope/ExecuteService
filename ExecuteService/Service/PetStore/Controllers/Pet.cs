using ExecuteService.Models.PetStore.Controllers;
using Newtonsoft.Json;
using RestSharp;

namespace ExecuteService.Service.PetStore.Controllers
{
    public class Pet
    {
        private RestClient client;
        private RestRequest endpoint;
        private RestResponse response;

        public Pet()
        {
            Client("https://petstore.swagger.io/v2");
        }

        private RestClient Client(string urlBase)
        {
            client = new RestClient(urlBase);
            return client;
        }

        private RestRequest Endpoint(string path)
        {
            endpoint = new RestRequest(path);
            return endpoint;
        }

        private void Method(Method method)
        {
            endpoint.Method = method;
        }

        private void Request(object body)
        {
            endpoint.AddParameter("application/json", JsonConvert.SerializeObject(body), ParameterType.RequestBody);
        }

        private RestResponse Execute()
        {
            response = client.Execute(endpoint);
            return response;
        }

        public RestResponse Post_Pet(PetRequest request)
        {
            Endpoint("/pet");
            Method(RestSharp.Method.Post);
            Request(request);
            return Execute();
        }
    }
}
