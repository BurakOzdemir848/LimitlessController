using LimitlessController.Core.Models;
using LimitlessController.Core.Services;
using System.Globalization;
using System.Text;

public class HexConverter : IDataConverter
{
    public DataFormat Format => DataFormat.Hex;

    public byte[] ConvertRequest(string data, bool isBigEndian, bool clrf)
    {
        var cleaned = data.Replace(" ", "").Replace(",", "").Replace(":", "").Replace(";", "")
                          .Replace("-", "").Replace("_", "")
                          .Replace("0x", "", StringComparison.OrdinalIgnoreCase);

        if (cleaned.Length == 0) return AddCrlf(Array.Empty<byte>(), clrf);
        if (cleaned.Length % 2 != 0) throw new FormatException("Hex length must be even!");

        var bytes = new byte[cleaned.Length / 2];
        for (int i = 0; i < bytes.Length; i++)
            bytes[i] = byte.Parse(cleaned.AsSpan(i * 2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);

        return AddCrlf(bytes, clrf);
    }

    public string ConvertResponse(byte[] data, bool isBigEndian) =>
        string.Join(" ", data.Select(b => b.ToString("X2", CultureInfo.InvariantCulture)));

    private static byte[] AddCrlf(byte[] bytes, bool clrf) =>
        clrf ? bytes.Concat(Encoding.ASCII.GetBytes("\r\n")).ToArray() : bytes;
}
