using RestSharp;

namespace TestJsonPlaceholder.Response
{
    public class PostResponse : BaseResponse
    {
        private RestRequest RestPostGetRequest(int n)
        {
            return new RestRequest($"/posts/{n}", Method.GET);

        }
        public string GetPostResponse(int n)
        {
            IRestResponse restResponse = restClient.Execute(RestPostGetRequest(n));
            return restResponse.Content;
        }

    }
}
