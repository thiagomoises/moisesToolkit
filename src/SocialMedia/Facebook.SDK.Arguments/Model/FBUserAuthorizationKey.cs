using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.SDK.Model
{
    public class FBUserAuthorizationKey
    {
        public string UserId { get; private set; }
        public string UserToken { get; private set; }

        public FBUserAuthorizationKey(string userId, string userToken)
        {
            UserId = userId;
            UserToken = userToken;
        }
    }
}
