using Microsoft.AspNetCore.Authentication.Facebook;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.SDK.Test
{
    public class BaseTests
    {
        protected readonly FacebookOptions FacebookOptions;

        public BaseTests()
        {
            FacebookOptions = new FacebookOptions()
            {
                AppId = "2590889607604607",
                AppSecret = "b271dddf4651d632a4ebedae138c721c",
                SaveTokens = true,
            };

            FacebookOptions.Scope.Add("email");
            FacebookOptions.Scope.Add("user_birthday");
            FacebookOptions.Scope.Add("user_gender");
            FacebookOptions.Scope.Add("user_posts");
            FacebookOptions.Scope.Add("manage_pages");
            FacebookOptions.Scope.Add("user_photos ");
            FacebookOptions.Scope.Add("publish_pages");
        }
    }
}
