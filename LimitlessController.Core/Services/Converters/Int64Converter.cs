using System.Buffers.Binary;
using System.Globalization;
using System.Text;
using LimitlessController.Core.Models;

namespace LimitlessController.Core.Services
{
    public class Int64Converter : IDataConverter
    {
        public DataFormat Format => DataFormat.Int64;

        public byte[] ConvertRequest(string data, bool isBigEndian, bool clrf)
        {
            var parts = data.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var bytes = new byte[parts.Length * 8];
            for (int i = 0; i < parts.Length; i++)
            {
                long v = long.Parse(parts[i], CultureInfo.InvariantCulture);
                if (isBigEndian) BinaryPrimitives.WriteInt64BigEndian(bytes.AsSpan(i * 8, 8), v);
                else BinaryPrimitives.WriteInt64LittleEndian(bytes.AsSpan(i * 8, 8), v);
            }
            return AddCrlf(bytes, clrf);
        }

        public string ConvertResponse(byte[] data, bool isBigEndian)
        {
            if (data.Length % 8 != 0) throw new Exception($"Expected multiples of 8 bytes, got {data.Length}");
            var sb = new StringBuilder();
            for (int i = 0; i < data.Length / 8; i++)
            {
                var span = new ReadOnlySpan<byte>(data, i * 8, 8);
                long v = isBigEndian ? BinaryPrimitives.ReadInt64BigEndian(span) : BinaryPrimitives.ReadInt64LittleEndian(span);
                if (i > 0) sb.Append(' ');
                sb.Append(v.ToString(CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }

        private static byte[] AddCrlf(byte[] bytes, bool clrf) =>
            clrf ? bytes.Concat(Encoding.ASCII.GetBytes("\r\n")).ToArray() : bytes;
    }
}
