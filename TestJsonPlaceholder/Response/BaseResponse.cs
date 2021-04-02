using RestSharp;

namespace TestJsonPlaceholder.Response
{
    public class BaseResponse
    {

        public RestClient restClient = new RestClient("https://jsonplaceholder.typicode.com");


    }
}
