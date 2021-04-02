using RestSharp;

namespace TestJsonPlaceholder.Response
{
    public class CommentResponse : BaseResponse
    {
        private RestRequest RestCommentGetRequest(int n)
        {
            return new RestRequest($"/comments/{n}", Method.GET);
        }

        public string GetCommentResponse(int n)
        {
            IRestResponse restResponse = restClient.Execute(RestCommentGetRequest(n));
            return restResponse.Content;
        }
    }

}
