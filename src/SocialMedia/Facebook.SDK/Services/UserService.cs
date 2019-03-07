using Facebook.SDK.Arguments.Responses;
using Facebook.SDK.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Facebook;

namespace Facebook.SDK.Services
{
    public class UserService : BaseService
    {
        public UserService(FacebookOptions facebookOptions) : base(facebookOptions)
        {
        }

        public FBUser GetUserInfo(FBUserAuthorizationKey authorizationKey, string idUser = "")
        {
            var result = this.Get<FBUser>($"{(string.IsNullOrEmpty(idUser) ? authorizationKey.UserId : idUser) }/?access_token={authorizationKey.UserToken}");

            if (this.IsValid())
                return result;

            return null;

        }

    }
}
