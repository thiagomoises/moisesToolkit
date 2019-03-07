using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.SDK.Model
{
    public class FBError
    {
        public string Message { get; set; }
        public string Type { get; set; }
        public int Code { get; set; }

        [JsonProperty(PropertyName = "fbtrace_id")]
        public string FBTraceId { get; set; }
    }
}
