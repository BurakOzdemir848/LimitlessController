namespace LimitlessController.Core.Interfaces
{
    public interface IConnection : IDisposable
    {
        bool IsConnected { get; }
        Task<bool> ConnectAsync(string ip, int port, CancellationToken token = default);
        Task<bool> SendAsync(bool clrf, byte[] message, CancellationToken token = default);
        Task<byte[]> ReceiveAsync(int timeoutMs, CancellationToken token = default);
        void Disconnect();
    }
}
