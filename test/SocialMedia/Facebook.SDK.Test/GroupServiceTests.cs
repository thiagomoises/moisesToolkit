using Facebook.SDK.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.SDK.Test
{
    public class GroupServiceTests : BaseTests
    {
        [Test]
        public void GetUserGroupsSuccess()
        {
            GroupService service = new GroupService(base.FacebookOptions);
            service.GetUserGroups(new Model.FBUserAuthorizationKey("2419631558111312", "EAAk0ZAn62qX8BAEumiaUTEUyfQjb13Kdd0Uyu3XSpMor28HmeR8iwUgGIV7bFl1SXQwGzp3Fp6DNdokWqELWNbgZAFnsaq5fZAYZA8eObXCuUmTcabjdzkZAPP1sYIvhq9jaZCtwlA1ZACkzot4ZCHxoCfMC1APvgkeQZA7MZAAqXfdfTQzY8aloeX7zI6mNnhjGgZD"));
            Assert.IsTrue(service.IsValid());
        }

        [Test]
        public void GetUserGroupsFail()
        {
            GroupService service = new GroupService(base.FacebookOptions);
            service.GetUserGroups(new Model.FBUserAuthorizationKey("2419631558111312", "bXCuUmTcabjdzkZAPP1sYIvhq9jaZCtwlA1ZACkzot4ZCHxoCfMC1APvgkeQZA7MZAAqXfdfTQzY8aloeX7zI6mNnhjGgZD"));
            Assert.IsFalse(service.IsValid());
        }
    }
}
