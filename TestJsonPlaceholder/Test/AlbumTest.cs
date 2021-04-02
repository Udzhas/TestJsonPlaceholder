using Newtonsoft.Json;
using NUnit.Framework;
using TestJsonPlaceholder.Dto;


namespace TestJsonPlaceholder.Test
{
    public class AlbumTest : BaseTest
    {

        [Test]
        public void CheckAlbumTitle()
        {
            AlbumDto albumDto = JsonConvert.DeserializeObject<AlbumDto>(albumResponse.GetAlbumResponse(2));
            Assert.AreEqual("sunt qui excepturi placeat culpa", albumDto.title, "Title must be: sunt qui excepturi placeat culpa");
        }

        [Test]
        public void CheckAlbumUserId()
        {
            AlbumDto albumDto = JsonConvert.DeserializeObject<AlbumDto>(albumResponse.GetAlbumResponse(2));
            Assert.AreEqual(1, albumDto.userId, "UserID must be: 1");
        }

        [Test]
        public void CheckAlbumResponceCode()
        {
            Assert.AreEqual(200, albumResponse.GetAlbumResponseCode(2), "Status Code must be: 200");
            Assert.AreEqual(404, albumResponse.GetAlbumResponseCode(-2), "Status code must be: 404");
        }

    }
}
