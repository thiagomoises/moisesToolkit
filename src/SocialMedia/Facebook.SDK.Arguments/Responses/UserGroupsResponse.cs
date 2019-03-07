using Facebook.SDK.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.SDK.Arguments.Responses
{
    public class UserGroupsResponse
    {
        public List<FBGroup> Data { get; set; }
        public FBPaging Paging { get; set; }
        public string Id { get; set; }
    }
}
