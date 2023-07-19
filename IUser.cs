using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrincipleDemo
{
    internal interface IUser
    {
        bool Login(string username, string password);
        bool Register (string username, string password,string email);
        
        
    }
    interface ILogger
    {
        void Logging(string message);
    }

    interface IEmail
    {
        bool Sendemail(string emailcontent);
    }
}
