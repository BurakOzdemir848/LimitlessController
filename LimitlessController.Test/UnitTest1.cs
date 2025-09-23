using LimitlessController.Infrastructure.Tcp;
using System.Net.Sockets;
using System.Text;

public class ConnectionManagerTests
{
    [Fact]
    public async Task SendAsync_ShouldAppendCRLF_WhenCrlfIsTrue()
    {
        using var ms = new MemoryStream();
        using var writer = new StreamWriter(ms, Encoding.ASCII, leaveOpen: true);
        using var reader = new StreamReader(ms, Encoding.ASCII, leaveOpen: true);

        var tcpClient = new TcpClient();
        var connection = new ConnectionManager(tcpClient, ms); // ctor’da Stream alacak þekilde uyarlaman lazým

        byte[] message = Encoding.ASCII.GetBytes("HELLO");
        await connection.SendAsync(true, message);

        ms.Position = 0;
        string sent = await reader.ReadToEndAsync();

        Assert.Equal("HELLO\r\n", sent);
    }
}
