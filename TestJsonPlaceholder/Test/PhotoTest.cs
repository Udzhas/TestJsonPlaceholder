using Newtonsoft.Json;
using NUnit.Framework;
using TestJsonPlaceholder.Dto;

namespace TestJsonPlaceholder.Test
{
    public class PhotoTest : BaseTest
    {
        [Test]
        public void CheckPhotoAlbumId()
        {
            PhotoDto photoDto = JsonConvert.DeserializeObject<PhotoDto>(photoResponse.GetPhotoResponse(5));
            Assert.AreEqual(1, photoDto.albumId, "AlbumId must be: 1");
        }

        [Test]
        public void CheckPhotoTitle()
        {
            PhotoDto photoDto = JsonConvert.DeserializeObject<PhotoDto>(photoResponse.GetPhotoResponse(5));
            Assert.AreEqual("natus nisi omnis corporis facere molestiae rerum in", photoDto.title, "Title must be: natus nisi omnis corporis facere molestiae rerum in");
        }

        [Test]
        public void CheckPhotoUrl()
        {
            PhotoDto photoDto = JsonConvert.DeserializeObject<PhotoDto>(photoResponse.GetPhotoResponse(5));
            Assert.AreEqual("https://via.placeholder.com/600/f66b97", photoDto.url, "Url must be: https://via.placeholder.com/600/f66b97");
        }

        [Test]
        public void CheckPhotoThumbnailUrl()
        {
            PhotoDto photoDto = JsonConvert.DeserializeObject<PhotoDto>(photoResponse.GetPhotoResponse(5));
            Assert.AreEqual("https://via.placeholder.com/150/f66b97", photoDto.thumbnailUrl, "ThumbnailUrl must be: https://via.placeholder.com/150/f66b97");
        }
    }
}
