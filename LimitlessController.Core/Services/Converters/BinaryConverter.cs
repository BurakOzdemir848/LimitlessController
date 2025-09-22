using LimitlessController.Core.Models;
using LimitlessController.Core.Services;
using System.Text;

public class BinaryConverter : IDataConverter
{
    public DataFormat Format => DataFormat.Binary;

    public byte[] ConvertRequest(string data, bool isBigEndian, bool clrf)
    {
        var cleaned = data.Replace(" ", "").Replace(",", "").Replace(":", "").Replace(";", "")
                          .Replace("-", "").Replace("_", "")
                          .Replace("0b", "", StringComparison.OrdinalIgnoreCase);

        if (cleaned.Length == 0) return AddCrlf(Array.Empty<byte>(), clrf);
        if (cleaned.Length % 8 != 0) throw new FormatException("Binary length must be multiple of 8!");

        var bytes = new byte[cleaned.Length / 8];
        for (int i = 0; i < bytes.Length; i++)
        {
            string octet = cleaned.Substring(i * 8, 8);
            bytes[i] = Convert.ToByte(octet, 2);
        }

        return AddCrlf(bytes, clrf);
    }

    public string ConvertResponse(byte[] data, bool isBigEndian) =>
        string.Join(" ", data.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));

    private static byte[] AddCrlf(byte[] bytes, bool clrf) =>
        clrf ? bytes.Concat(Encoding.ASCII.GetBytes("\r\n")).ToArray() : bytes;
}
