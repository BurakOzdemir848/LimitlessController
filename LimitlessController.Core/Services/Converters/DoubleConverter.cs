using System.Buffers.Binary;
using System.Globalization;
using System.Text;
using LimitlessController.Core.Models;

namespace LimitlessController.Core.Services
{
    public class DoubleConverter : IDataConverter
    {
        public DataFormat Format => DataFormat.Double;

        public byte[] ConvertRequest(string data, bool isBigEndian, bool clrf)
        {
            var parts = data.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var bytes = new byte[parts.Length * 8];
            for (int i = 0; i < parts.Length; i++)
            {
                double v = double.Parse(parts[i], NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture);
                long bits = BitConverter.DoubleToInt64Bits(v);
                if (isBigEndian) BinaryPrimitives.WriteInt64BigEndian(bytes.AsSpan(i * 8, 8), bits);
                else BinaryPrimitives.WriteInt64LittleEndian(bytes.AsSpan(i * 8, 8), bits);
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
                long bits = isBigEndian ? BinaryPrimitives.ReadInt64BigEndian(span) : BinaryPrimitives.ReadInt64LittleEndian(span);
                double v = BitConverter.Int64BitsToDouble(bits);
                if (i > 0) sb.Append(' ');
                sb.Append(v.ToString("R", CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }

        private static byte[] AddCrlf(byte[] bytes, bool clrf) =>
            clrf ? bytes.Concat(Encoding.ASCII.GetBytes("\r\n")).ToArray() : bytes;
    }
}
