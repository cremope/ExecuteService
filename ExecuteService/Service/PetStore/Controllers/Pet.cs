using ExecuteService.Models.PetStore.Controllers;
using RestSharp;

namespace ExecuteService.Service.PetStore.Controllers
{
    public class Pet
    {
        private string BASEURL = "https://petstore.swagger.io/v2";
        public Pet()
        {
        }

        public RestResponse Post_Pet(PetRequest request, Method metodo)
        {
            Utils.Client(BASEURL);
            Utils.Endpoint("/pet");
            Utils.Method(metodo);
            Utils.Request(request);
            return Utils.Execute();
        }

        public RestResponse Get_Pet(object id, Method metodo)
        {
            Utils.Client(BASEURL);
            Utils.Endpoint($"/pet/{id}");
            Utils.Method(metodo);
            return Utils.Execute();
        }

        public RestResponse Delete_Pet(object id, Method metodo)
        {
            Utils.Client(BASEURL);
            Utils.Endpoint($"/pet/{id}");
            Utils.Header_ApiKey();
            Utils.Method(metodo);
            return Utils.Execute();
        }
    }
}
