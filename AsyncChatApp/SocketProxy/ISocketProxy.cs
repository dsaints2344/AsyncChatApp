using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketProxy
{
    public interface ISocketProxy
    {
        void Bind(EndPoint localEP);
        void Listen(int backlog);
        IAsyncResult BeginAccept(AsyncCallback callback, object state);
        Socket EndAccept(out byte[] buffer, IAsyncResult asyncResult);
    }
}
