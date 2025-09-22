using System.Buffers.Binary;
using System.Globalization;
using System.Text;
using LimitlessController.Core.Models;

namespace LimitlessController.Core.Services
{
    public class Int32Converter : IDataConverter
    {
        public DataFormat Format => DataFormat.Int32;

        public byte[] ConvertRequest(string data, bool isBigEndian, bool clrf)
        {
            var parts = data.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var bytes = new byte[parts.Length * 4];
            for (int i = 0; i < parts.Length; i++)
            {
                int v = int.Parse(parts[i], CultureInfo.InvariantCulture);
                if (isBigEndian) BinaryPrimitives.WriteInt32BigEndian(bytes.AsSpan(i * 4, 4), v);
                else BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(i * 4, 4), v);
            }
            return AddCrlf(bytes, clrf);
        }

        public string ConvertResponse(byte[] data, bool isBigEndian)
        {
            if (data.Length % 4 != 0) throw new Exception($"Expected multiples of 4 bytes, got {data.Length}");
            var sb = new StringBuilder();
            for (int i = 0; i < data.Length / 4; i++)
            {
                var span = new ReadOnlySpan<byte>(data, i * 4, 4);
                int v = isBigEndian ? BinaryPrimitives.ReadInt32BigEndian(span) : BinaryPrimitives.ReadInt32LittleEndian(span);
                if (i > 0) sb.Append(' ');
                sb.Append(v.ToString(CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }

        private static byte[] AddCrlf(byte[] bytes, bool clrf) =>
            clrf ? bytes.Concat(Encoding.ASCII.GetBytes("\r\n")).ToArray() : bytes;
    }
}
