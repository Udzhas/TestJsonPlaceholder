using RestSharp;

namespace TestJsonPlaceholder.Response
{
    public class ToDoResponse : BaseResponse
    {
        private RestRequest RestToDoGetRequest(int n)
        {
            return new RestRequest($"/todos/{n}", Method.GET);
        }
         public string GetToDoResponse(int n)
        {
            IRestResponse restResponse = restClient.Execute(RestToDoGetRequest(n));
            return restResponse.Content;
        }
    }
}
