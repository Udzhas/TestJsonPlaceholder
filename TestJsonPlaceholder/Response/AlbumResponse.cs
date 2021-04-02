using RestSharp;
using System.Net;

namespace TestJsonPlaceholder.Response
{
    public class AlbumResponse : BaseResponse
    {
        private RestRequest RestAlbumGeetRequest(int n)
        {
            return new RestRequest($"/albums/{n}", Method.GET);
        }
        public string GetAlbumResponse(int n)
        {
            IRestResponse restResponse = restClient.Execute(RestAlbumGeetRequest(n));
            return restResponse.Content;
        }

        public int GetAlbumResponseCode(int n)
        {
            IRestResponse restResponse = restClient.Execute(RestAlbumGeetRequest(n));
            HttpStatusCode statusCode = restResponse.StatusCode;
            int numericStatusCode = (int)statusCode;
            return numericStatusCode;

        }
    }
}
