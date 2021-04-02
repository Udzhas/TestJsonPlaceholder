using RestSharp;

namespace TestJsonPlaceholder.Response
{
    public class PhotoResponse : BaseResponse
    {
        private RestRequest RestPhotoGetRequest(int n)
        {
            return new RestRequest($"/photos/{n}", Method.GET);
        }
         public string GetPhotoResponse(int n)
        {
            IRestResponse restResponse = restClient.Execute(RestPhotoGetRequest(n));
            return restResponse.Content;
        }
    }
}
