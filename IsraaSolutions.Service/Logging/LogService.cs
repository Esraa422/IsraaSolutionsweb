using IsraaApp.Core.Entities;
using IsraaApp.Data;
using System;

namespace IsraaApp.Service
{
    public class LogService : ILogService
    {
        #region Fields
        private readonly IRepository<SystemError> errorRepository;
        #endregion

        #region Ctor
        public LogService(IRepository<SystemError> _errorRepository)
        {
            errorRepository = _errorRepository;
        }
        #endregion

        #region Methods
        public bool Error(string url, string urlReferrer, string ipAddress, string message, Exception exception = null)
        {
            if (!(exception is System.Threading.ThreadAbortException))
            {
                string fullMessage = exception == null ? string.Empty : exception.ToString();
                var error = new SystemError
                {
                    ErrorDate = DateTime.Now,
                    PageUrl = url,
                    ReferrerUrl = urlReferrer,
                    IpAddress = ipAddress,
                    ShortMessage = message,
                    FullMessage = fullMessage
                };
                return errorRepository.Insert(error);
            }

            return false;
        }
        #endregion
    }
}