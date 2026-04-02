using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public delegate void SendMSG(string msg);
    public class MessagePublisher
    {
        public event SendMSG OnSend;

        public void Send(string msg)
        {
            OnSend?.Invoke(msg);
        }
    }
}
