using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Wevote.Application
{
    public class LogStructure
    {
        public HttpMethod HttpMethod { get; set; }
        public string Route { get; set; }
        public HttpStatusCode Result { get; set; }
        public string Message { get; set; }
    }
}
