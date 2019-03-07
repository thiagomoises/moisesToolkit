using Facebook.SDK.Arguments.Responses;
using Facebook.SDK.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Facebook;

namespace Facebook.SDK.Services
{
    public class GroupService : BaseService
    {
        public GroupService(FacebookOptions facebookOptions) : base(facebookOptions)
        {
        }

        public UserGroupsResponse GetUserGroups(FBUserAuthorizationKey authorizationKey)
        {
            var result = this.Get<UserGroupsResponse>($"{authorizationKey.UserId}/groups/?access_token={authorizationKey.UserToken}");

            if (this.IsValid())
                return result;

            return null;

        }
               
    }
}
