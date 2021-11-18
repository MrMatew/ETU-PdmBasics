using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PdmBasics.Models.Shared
{
    public class StatusCode
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string ErrorStatusCode { get; set; }

        public string OriginalUrl { get; set; }
        public bool ShowOriginalUrl => !string.IsNullOrEmpty(OriginalUrl);
    }
}
