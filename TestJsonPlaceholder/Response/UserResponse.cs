using RestSharp;

namespace TestJsonPlaceholder.Response
{
    public class UserResponse : BaseResponse
    {
        private RestRequest RestUserGetRequest(int n)
        {
            return new RestRequest($"/users/{n}", Method.GET);
        }

        public string GetUserResponse(int n)
        {
            IRestResponse restResponse = restClient.Execute(RestUserGetRequest(n));
            return restResponse.Content;
        }

    }
}
