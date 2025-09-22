using System.Buffers.Binary;
using System.Globalization;
using System.Text;
using LimitlessController.Core.Models;

namespace LimitlessController.Core.Services
{
    public class DecimalConverter : IDataConverter
    {
        public DataFormat Format => DataFormat.Decimal;

        public byte[] ConvertRequest(string data, bool isBigEndian, bool clrf)
        {
            decimal v = decimal.Parse(data, CultureInfo.InvariantCulture);
            int[] bits = decimal.GetBits(v);
            var bytes = new byte[16];

            if (isBigEndian)
            {
                BinaryPrimitives.WriteInt32BigEndian(bytes.AsSpan(0, 4), bits[0]);
                BinaryPrimitives.WriteInt32BigEndian(bytes.AsSpan(4, 4), bits[1]);
                BinaryPrimitives.WriteInt32BigEndian(bytes.AsSpan(8, 4), bits[2]);
                BinaryPrimitives.WriteInt32BigEndian(bytes.AsSpan(12, 4), bits[3]);
            }
            else
            {
                BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(0, 4), bits[0]);
                BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(4, 4), bits[1]);
                BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(8, 4), bits[2]);
                BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(12, 4), bits[3]);
            }

            return AddCrlf(bytes, clrf);
        }

        public string ConvertResponse(byte[] data, bool isBigEndian)
        {
            if (data.Length != 16) throw new Exception("Expected 16 bytes for decimal");

            int lo = isBigEndian ? BinaryPrimitives.ReadInt32BigEndian(data.AsSpan(0, 4)) : BinaryPrimitives.ReadInt32LittleEndian(data.AsSpan(0, 4));
            int mid = isBigEndian ? BinaryPrimitives.ReadInt32BigEndian(data.AsSpan(4, 4)) : BinaryPrimitives.ReadInt32LittleEndian(data.AsSpan(4, 4));
            int hi = isBigEndian ? BinaryPrimitives.ReadInt32BigEndian(data.AsSpan(8, 4)) : BinaryPrimitives.ReadInt32LittleEndian(data.AsSpan(8, 4));
            int flags = isBigEndian ? BinaryPrimitives.ReadInt32BigEndian(data.AsSpan(12, 4)) : BinaryPrimitives.ReadInt32LittleEndian(data.AsSpan(12, 4));

            return new decimal(new int[] { lo, mid, hi, flags }).ToString(CultureInfo.InvariantCulture);
        }

        private static byte[] AddCrlf(byte[] bytes, bool clrf) =>
            clrf ? bytes.Concat(Encoding.ASCII.GetBytes("\r\n")).ToArray() : bytes;
    }
}
