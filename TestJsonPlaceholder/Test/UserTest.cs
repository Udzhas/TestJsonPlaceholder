using Newtonsoft.Json;
using NUnit.Framework;
using TestJsonPlaceholder.Dto;

namespace TestJsonPlaceholder.Test
{
    public class UserTest : BaseTest
    {
        [Test]
        public void CheckUserName()
        {
            UserDto userDto = JsonConvert.DeserializeObject<UserDto>(userResponse.GetUserResponse(10));
            Assert.AreEqual("Clementina DuBuque", userDto.name, "Name must be: Clementina DuBuque");
        }

        [Test]
        public void CheckUserEmail()
        {
            UserDto userDto = JsonConvert.DeserializeObject<UserDto>(userResponse.GetUserResponse(10));
            Assert.AreEqual("Rey.Padberg@karina.biz", userDto.email, "Email must be: Rey.Padberg@karina.biz");
        }
        [Test]
        public void CheckUserUsername()
        {
            UserDto userDto = JsonConvert.DeserializeObject<UserDto>(userResponse.GetUserResponse(10));
            Assert.AreEqual("Moriah.Stanton", userDto.username, "Username must be: Moriah.Stanton");
        }

        [Test]
        public void CheckUserPhone()
        {
            UserDto userDto = JsonConvert.DeserializeObject<UserDto>(userResponse.GetUserResponse(10));
            Assert.AreEqual("024-648-3804", userDto.phone, "Phone must be: 024-648-3804");
        }

        [Test]
        public void CheckUserWebsite()
        {
            UserDto userDto = JsonConvert.DeserializeObject<UserDto>(userResponse.GetUserResponse(10));
            Assert.AreEqual("ambrose.net", userDto.website, "Website must be: ambrose.net");
        }

        [Test]
        public void CheckUserCompany()
        {
            UserDto userDto = JsonConvert.DeserializeObject<UserDto>(userResponse.GetUserResponse(10));
            Assert.AreEqual("Hoeger LLC", userDto.company.name, "Company name must be: Hoeger LLC");
            Assert.AreEqual("Centralized empowering task-force", userDto.company.catchPhrase, "Company catch phrase must be: Centralized empowering task-force");
            Assert.AreEqual("target end-to-end models", userDto.company.bs, "Company bs must be: target end-to-end models");

        }

        [Test]
        public void CheckUserAddres()
        {
            UserDto userDto = JsonConvert.DeserializeObject<UserDto>(userResponse.GetUserResponse(10));
            Assert.AreEqual("Kattie Turnpike", userDto.address.street, "Street must be: Kattie Turnpike");
            Assert.AreEqual("Suite 198", userDto.address.suite, "Suit must be: Suite 198");
            Assert.AreEqual("Lebsackbury", userDto.address.city, "City must be: Lebsackbury");
            Assert.AreEqual("31428-2261", userDto.address.zipcode, "Zipcode must be: 31428-2261");
            Assert.AreEqual("-38.2386", userDto.address.geo.lat, "Latitude must be: -38.2386");
            Assert.AreEqual("57.2232", userDto.address.geo.lng, "Longtitude must be: 57.2232");
        }

        ////[Test]
        //public void CheckUserAddresSuite()
        //{
        //    UserDto userDto = JsonConvert.DeserializeObject<UserDto>(userResponse.GetUserResponse(10));
        //    Assert.AreEqual("Suite 198", userDto.address.suite, "Suit must be: Suite 198");
        //}

        ////[Test]
        //public void CheckUserAddresCity()
        //{
        //    UserDto userDto = JsonConvert.DeserializeObject<UserDto>(userResponse.GetUserResponse(10));
        //    Assert.AreEqual("Lebsackbury", userDto.address.city, "City must be: Lebsackbury");
        //}

        ////[Test]
        //public void CheckUserAddresZipcode()
        //{
        //    UserDto userDto = JsonConvert.DeserializeObject<UserDto>(userResponse.GetUserResponse(10));
        //    Assert.AreEqual("31428-2261", userDto.address.zipcode, "Zipcode must be: 31428-2261");
        //}

        ////[Test]
        //public void CheckUserAddresGeoLat()
        //{
        //    UserDto userDto = JsonConvert.DeserializeObject<UserDto>(userResponse.GetUserResponse(10));
        //    Assert.AreEqual("-38.2386", userDto.address.geo.lat, "Latitude must be: -38.2386");
        //}

        ////[Test]
        //public void CheckUserAddresGeoLng()
        //{
        //    UserDto userDto = JsonConvert.DeserializeObject<UserDto>(userResponse.GetUserResponse(10));
        //    Assert.AreEqual("57.2232", userDto.address.geo.lng, "Longtitude must be: 57.2232");
        //}


        ////[Test]
        //public void CheckUserCompanyCathPhrase()
        //{
        //    UserDto userDto = JsonConvert.DeserializeObject<UserDto>(userResponse.GetUserResponse(10));
        //    Assert.AreEqual("Centralized empowering task-force", userDto.company.catchPhrase, "Company catch phrase must be: Centralized empowering task-force");
        //}

        ////[Test]
        //public void CheckUserCompanyBs()
        //{
        //    UserDto userDto = JsonConvert.DeserializeObject<UserDto>(userResponse.GetUserResponse(10));
        //    Assert.AreEqual("target end-to-end models", userDto.company.bs, "Company bs must be: target end-to-end models");
        //}
    }
}
