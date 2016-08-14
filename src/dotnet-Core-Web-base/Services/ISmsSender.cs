using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_Core_Web_base.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
