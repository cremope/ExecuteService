using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteService.Service.PetStore.Controllers
{
    public class Pet
    {
        private RestClient client;
        private RestRequest endpoint;
        private RestResponse response;

        public Pet()
        {
            Client("https://petstore.swagger.io/#/");
        }

        public RestClient Client(string urlBase)
        {
            client = new RestClient(urlBase);
            return client;
        }

        public RestRequest Endpoint(string path)
        {
            endpoint = new RestRequest(path);
            return endpoint;
        }

        public void Method(Method method)
        {
            endpoint.Method = method;
        }

        public RestResponse Execute()
        {
            response = client.Execute(endpoint);
            return response;
        }

        public RestResponse Post_Pet()
        {
            Endpoint("/pet");
            Method(RestSharp.Method.Post);
            return Execute();
        }
    }
}
