using Facebook.SDK.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.SDK.Test
{
    public class UserServiceTests : BaseTests
    {
        [Test]
        public void GetUserGroupsSuccess()
        {
            UserService service = new UserService(base.FacebookOptions);
            service.GetUserInfo(new Model.FBUserAuthorizationKey("2419631558111312", "EAAk0ZAn62qX8BAEumiaUTEUyfQjb13Kdd0Uyu3XSpMor28HmeR8iwUgGIV7bFl1SXQwGzp3Fp6DNdokWqELWNbgZAFnsaq5fZAYZA8eObXCuUmTcabjdzkZAPP1sYIvhq9jaZCtwlA1ZACkzot4ZCHxoCfMC1APvgkeQZA7MZAAqXfdfTQzY8aloeX7zI6mNnhjGgZD"));
            Assert.IsTrue(service.IsValid());
        }

        [Test]
        public void GetUserGroupsFail()
        {
            UserService service = new UserService(base.FacebookOptions);
            service.GetUserInfo(new Model.FBUserAuthorizationKey("2419631558111313", "EAAk0ZAn62qX8BAEumiaUTEUyfQjb13Kdd0Uyu3XSpMor28HmeR8iwUgGIV7bFl1SXQwGzp3Fp6DNdokWqELWNbgZAFnsaq5fZAYZA8eObXCuUmTcabjdzkZAPP1sYIvhq9jaZCtwlA1ZACkzot4ZCHxoCfMC1APvgkeQZA7MZAAqXfdfTQzY8aloeX7zI6mNnhjGgZD"));
            Assert.IsFalse(service.IsValid());
        }
    }
}
