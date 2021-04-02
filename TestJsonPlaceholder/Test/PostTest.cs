using Newtonsoft.Json;
using NUnit.Framework;
using TestJsonPlaceholder.Dto;

namespace TestJsonPlaceholder.Test
{
    public class PostTest : BaseTest
    {
        [Test]
        public void CheckPostUserID()
        {
            PostDto postDto = JsonConvert.DeserializeObject<PostDto>(postResponse.GetPostResponse(69));
            Assert.AreEqual(7, postDto.userId, "UserID must be: 7");
        }

        [Test]
        public void CheckPostTitle()
        {
            PostDto postDto = JsonConvert.DeserializeObject<PostDto>(postResponse.GetPostResponse(69));
            Assert.AreEqual("fugiat quod pariatur odit minima", postDto.title, "Title must be: fugiat quod pariatur odit minima");
        }

        [Test]
        public void CheckPostBody()
        {
            PostDto postDto = JsonConvert.DeserializeObject<PostDto>(postResponse.GetPostResponse(69));
            Assert.AreEqual("officiis error culpa consequatur modi asperiores et\ndolorum assumenda voluptas et vel qui aut vel rerum\nvoluptatum quisquam perspiciatis quia rerum consequatur totam quas\nsequi commodi repudiandae asperiores et saepe a", 
                postDto.body,
                "Body must be: officiis error culpa consequatur modi asperiores et\ndolorum assumenda voluptas et vel qui aut vel rerum\nvoluptatum quisquam perspiciatis quia rerum consequatur totam quas\nsequi commodi repudiandae asperiores et saepe a");
        }
    }
}
