using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X.Common
{
    class Config
    {

        public static int XWebclientTimeoutSeconds { get { return XConfigureHelper.GetConfigureIntValue("XWebclientTimeoutSeconds", 10); } }
    }
}
