using System.Buffers.Binary;
using System.Globalization;
using System.Text;
using LimitlessController.Core.Models;

namespace LimitlessController.Core.Services
{
    public class UInt16Converter : IDataConverter
    {
        public DataFormat Format => DataFormat.UInt16;

        public byte[] ConvertRequest(string data, bool isBigEndian, bool clrf)
        {
            var parts = data.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var bytes = new byte[parts.Length * 2];
            for (int i = 0; i < parts.Length; i++)
            {
                ushort v = ushort.Parse(parts[i], CultureInfo.InvariantCulture);
                if (isBigEndian) BinaryPrimitives.WriteUInt16BigEndian(bytes.AsSpan(i * 2, 2), v);
                else BinaryPrimitives.WriteUInt16LittleEndian(bytes.AsSpan(i * 2, 2), v);
            }
            return AddCrlf(bytes, clrf);
        }

        public string ConvertResponse(byte[] data, bool isBigEndian)
        {
            if (data.Length % 2 != 0) throw new Exception($"Expected multiples of 2 bytes, got {data.Length}");
            var sb = new StringBuilder();
            for (int i = 0; i < data.Length / 2; i++)
            {
                var span = new ReadOnlySpan<byte>(data, i * 2, 2);
                ushort v = isBigEndian ? BinaryPrimitives.ReadUInt16BigEndian(span) : BinaryPrimitives.ReadUInt16LittleEndian(span);
                if (i > 0) sb.Append(' ');
                sb.Append(v.ToString(CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }

        private static byte[] AddCrlf(byte[] bytes, bool clrf) =>
            clrf ? bytes.Concat(Encoding.ASCII.GetBytes("\r\n")).ToArray() : bytes;
    }
}
