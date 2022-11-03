using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmbryoFrontToBack.Services.Interface
{
    public interface IEmailService
    {
        void Send(string to, string subject, string body, string from = null);
    }
}
