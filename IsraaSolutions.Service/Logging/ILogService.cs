using System;

namespace IsraaApp.Service
{
    public interface ILogService
    {
        bool Error(string url, string urlReferrer, string ipAddress, string message, Exception exception = null);
    }
}
