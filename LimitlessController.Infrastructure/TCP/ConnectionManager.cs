using LimitlessController.Core.Interfaces;
using System.Net.Sockets;
using System.Text;

namespace LimitlessController.Infrastructure.Tcp
{
    public class ConnectionManager : IConnection
    {
        private TcpClient _client;
        private NetworkStream _stream;

        public bool IsConnected
        {
            get
            {
                try
                {
                    if (_client == null || _client.Client == null) return false;
                    var socket = _client.Client;
                    return socket.Connected;
                }
                catch { return false; }
            }
            set { }
        }

        public async Task<bool> ConnectAsync(string ip, int port, CancellationToken token = default)
        {
            try
            {
                _client = new TcpClient();

                _client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
                await _client.ConnectAsync(ip, port);
                _stream = _client.GetStream();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> SendAsync(bool clrf, byte[] message, CancellationToken token = default)
        {
            if (!IsConnected)
                throw new InvalidOperationException("Connect to the server first");

            if (clrf)
            {
                byte[] crlf = Encoding.ASCII.GetBytes("\r\n");
                byte[] combined = message.Concat(crlf).ToArray();
                await _stream.WriteAsync(combined, 0, combined.Length, token);
            }
            else
            {
                await _stream.WriteAsync(message, 0, message.Length, token);
            }
            return true;
        }

        public async Task<byte[]> ReceiveAsync(int timeoutMs, CancellationToken token = default)
        {
            if (!IsConnected)
                throw new InvalidOperationException("Connect to the server first");

            var buffer = new byte[150];
            using var ms = new MemoryStream();

            while (true)
            {
                var readTask = _stream.ReadAsync(buffer, 0, buffer.Length, token);
                var completed = await Task.WhenAny(readTask, Task.Delay(timeoutMs, token));

                if (completed != readTask)
                {
                    if (ms.Length > 0)
                    {
                        return ms.ToArray();
                    }
                    throw new TimeoutException($"No response received within {timeoutMs}ms, change your timeout or ensure your message");
                }
                var bytesRead = await readTask;
                if (bytesRead == 0)
                {
                    if (ms.Length > 0) return ms.ToArray();
                    throw new IOException("Remote host closed connection");
                }
                ms.Write(buffer,0, bytesRead);
                if (!_stream.DataAvailable) break;

            }
            return ms.ToArray();
        }
        public void Disconnect()
        {
            _stream?.Close();
            _client?.Close();
            _stream = null;
            _client = null;
            IsConnected = false;
        }

        public void Dispose() => Disconnect();
    }
}
