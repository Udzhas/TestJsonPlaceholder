using Newtonsoft.Json;
using NUnit.Framework;
using TestJsonPlaceholder.Dto;

namespace TestJsonPlaceholder.Test
{
    public class ToDoTest : BaseTest
    {
        [Test]
        public void CheckToDoUserId()
        {
            ToDoDto toDoDto = JsonConvert.DeserializeObject<ToDoDto>(toDoResponse.GetToDoResponse(13));
            Assert.AreEqual(1, toDoDto.userId, "UserID must be: 1");
        }

        [Test]
        public void CheckToDoTitle()
        {
            ToDoDto toDoDto = JsonConvert.DeserializeObject<ToDoDto>(toDoResponse.GetToDoResponse(13));
            Assert.AreEqual("et doloremque nulla", toDoDto.title, "Title must be: et doloremque nulla");
        }

        [Test]
        public void CheckToDoCompleted()
        {
            ToDoDto toDoDto = JsonConvert.DeserializeObject<ToDoDto>(toDoResponse.GetToDoResponse(13));
            Assert.IsFalse(toDoDto.completed, "Musn`t be completed");
        }
    }
}
