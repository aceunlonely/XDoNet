using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace X.Common
{
     public class WebClientWithTimeout : WebClient
    {
        public int Timeout { get; set; }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = base.GetWebRequest(address);
            if (Timeout > 0)
                request.Timeout = Timeout;
            return request;
        }
    }
}
