using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebapiClient
{
    [Serializable]
     public class User
    {
        public string name { get; set; }

        public int age { get; set; }

        public DateTime? date { get; set; }
    }
}
