using NetMQ;
using NetMQ.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace Web.Services
{
    public class MonicaParameters : IMonicaZmqService
    {
        private readonly AppData _appData;
        private readonly string ServerPushAddress;
        private readonly int ServerPushPort;

        public MonicaParameters(AppData appData)
        {
            _appData = appData;
            ServerPushAddress = _appData.ServerPushAddress;
            ServerPushPort = _appData.ServerPushPort;
        }

        public Task Recieve()
        {
            throw new NotImplementedException();
        }

        public bool Send(string message)
        {
            try
            {
                using (var producer = new PushSocket())
                {
                    producer.Connect(ServerPushAddress + ":" + ServerPushPort);
                    producer.SendFrame(message);
                    System.Threading.Thread.Sleep(2000);
                    producer.Disconnect(ServerPushAddress + ":" + ServerPushPort);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
