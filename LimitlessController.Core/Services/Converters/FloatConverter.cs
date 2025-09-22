using System.Buffers.Binary;
using System.Globalization;
using System.Text;
using LimitlessController.Core.Models;

namespace LimitlessController.Core.Services
{
    public class FloatConverter : IDataConverter
    {
        public DataFormat Format => DataFormat.Float;

        public byte[] ConvertRequest(string data, bool isBigEndian, bool clrf)
        {
            var parts = data.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var bytes = new byte[parts.Length * 4];
            for (int i = 0; i < parts.Length; i++)
            {
                float v = float.Parse(parts[i], NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture);
                int bits = BitConverter.SingleToInt32Bits(v);
                if (isBigEndian) BinaryPrimitives.WriteInt32BigEndian(bytes.AsSpan(i * 4, 4), bits);
                else BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(i * 4, 4), bits);
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
                int bits = isBigEndian ? BinaryPrimitives.ReadInt32BigEndian(span) : BinaryPrimitives.ReadInt32LittleEndian(span);
                float v = BitConverter.Int32BitsToSingle(bits);
                if (i > 0) sb.Append(' ');
                sb.Append(v.ToString("R", CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }

        private static byte[] AddCrlf(byte[] bytes, bool clrf) =>
            clrf ? bytes.Concat(Encoding.ASCII.GetBytes("\r\n")).ToArray() : bytes;
    }
}
