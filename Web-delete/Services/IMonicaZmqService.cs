﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Services
{
    public interface IMonicaZmqService
    {
        bool Send(string message);

        Task Recieve();
    }
}
