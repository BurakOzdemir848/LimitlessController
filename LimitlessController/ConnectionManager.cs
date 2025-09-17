using System.Net.Sockets;
using System.Text;

namespace LimitlessController
{
    public class ConnectionManager : IDisposable
    {
        private TcpClient _client;
        private NetworkStream _stream;
        private bool IsConnected => _client?.Connected ?? false;

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
        public async Task<byte[]> SendAsync(bool clrf, string message, CancellationToken token = default)
        {

            if (!IsConnected)
                throw new InvalidOperationException("Connec to the server before ");

            if (clrf) message += "\r\n";

            byte[] data = Encoding.ASCII.GetBytes(message);
            await _stream.WriteAsync(data, 0, data.Length, token);

            byte[] responseData = new byte[256];
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
