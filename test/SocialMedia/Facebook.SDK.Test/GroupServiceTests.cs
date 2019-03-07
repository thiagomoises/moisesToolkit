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
            service.GetUserGroups(new Model.FBUserAuthorizationKey("", ""));
            Assert.IsTrue(service.IsValid());
        }

        [Test]
        public void GetUserGroupsFail()
        {
            GroupService service = new GroupService(base.FacebookOptions);
            service.GetUserGroups(new Model.FBUserAuthorizationKey("", ""));
            Assert.IsFalse(service.IsValid());
        }
    }
}
