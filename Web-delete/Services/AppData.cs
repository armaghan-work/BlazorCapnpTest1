using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Web.Services
{
    public class AppData
    {

        // creating variables which we can access in all components (The configuration data)
        // ZMQ pull and push addresses and ports
        public string ServerPushAddress { get; set; } = "tcp://localhost";
        public int ServerPushPort { get; set; } = 6666;
        public string ServerPullAddress { get; set; } = "tcp://localhost";
        public int ServerPullPort { get; set; } = 7777;
        public bool ChartIsRun { get; set; } = false;
    }
}
