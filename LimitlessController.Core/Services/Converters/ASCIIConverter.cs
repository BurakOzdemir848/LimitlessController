using LimitlessController.Core.Models;
using LimitlessController.Core.Services;
using System.Text;

public class ASCIIStringConverter : IDataConverter
{
    public DataFormat Format => DataFormat.ASCIIString;

    public byte[] ConvertRequest(string data, bool isBigEndian, bool clrf) =>
        AddCrlf(Encoding.ASCII.GetBytes(data), clrf);

    public string ConvertResponse(byte[] data, bool isBigEndian)
    {
        int zero = Array.IndexOf(data, (byte)0);
        return zero >= 0 ? Encoding.ASCII.GetString(data, 0, zero) : Encoding.ASCII.GetString(data);
    }

    private static byte[] AddCrlf(byte[] bytes, bool clrf) =>
        clrf ? bytes.Concat(Encoding.ASCII.GetBytes("\r\n")).ToArray() : bytes;
}
