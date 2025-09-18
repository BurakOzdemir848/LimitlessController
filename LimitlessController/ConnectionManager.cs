using System.Net.Sockets;
using System.Text;

namespace LimitlessController
{
    public class ConnectionManager : IDisposable
    {
        private TcpClient _client;
        private NetworkStream _stream;

        public bool IsConnected
        {
            get
            {
                try
                {

                    if (_client.Client == null || _client == null) return false;
                    var socket = _client.Client;
                    if (!socket.Connected) return false;

                    return true;
                }
                catch { return false; }
            }
        }
        public async Task<bool> ConnectAsync(string ip, int port, CancellationToken token = default)
        {
            try
            {
                _client = new TcpClient();
                await _client.ConnectAsync(ip, port);
                _stream = _client.GetStream();


                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }
        public async Task<byte[]> SendAsync(bool clrf, bool bigEndian, byte[] message, CancellationToken token = default)
        {

            if (!IsConnected)
                throw new InvalidOperationException("Connec to the server before ");
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

            byte[] responseData = new byte[1028];
            int bytes = await _stream.ReadAsync(responseData, 0, responseData.Length, token);

            return responseData.Take(bytes).ToArray();
        }





        public void Disconnect()
        {
            _stream?.Close();
            _client?.Close();
            _stream = null;
            _client = null;
        }




        public void Dispose() { Disconnect(); }

    }
}
