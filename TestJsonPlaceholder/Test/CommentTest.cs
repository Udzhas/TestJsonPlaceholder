using Newtonsoft.Json;
using NUnit.Framework;
using TestJsonPlaceholder.Dto;

namespace TestJsonPlaceholder.Test
{
    public class CommentTest : BaseTest
    {
        [Test]
        public void CheckCommentPostId()
        {
            CommentDto commentDto = JsonConvert.DeserializeObject<CommentDto>(commentResponse.GetCommentResponse(14));
            Assert.AreEqual(3, commentDto.postId, "PostID must be: 3");
        }

        [Test]
        public void CheckCommentName()
        {
            CommentDto commentDto = JsonConvert.DeserializeObject<CommentDto>(commentResponse.GetCommentResponse(14));
            Assert.AreEqual("et officiis id praesentium hic aut ipsa dolorem repudiandae", commentDto.name, "Name must be: et officiis id praesentium hic aut ipsa dolorem repudiandae");
        }

        [Test]
        public void CheckCommentEmail()
        {
            CommentDto commentDto = JsonConvert.DeserializeObject<CommentDto>(commentResponse.GetCommentResponse(14));
            Assert.AreEqual("Nathan@solon.io", commentDto.email, "Email must be: Nathan@solon.io");
            Assert.AreNotEqual("Nathan@solon", commentDto.email, "Email must be incorrect: Nathan@solon");
        }
    }
}
