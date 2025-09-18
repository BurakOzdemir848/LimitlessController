using System.Text;

namespace LimitlessController
{
    public class DataConverter
    {
        public enum EndianMode
        {
            BigEndian,
            LittleEndian,

        }
        public static byte[] ConvertRequest(string data, DataFormat format, EndianMode endian = EndianMode.LittleEndian)
        {
            var parts = data.Split(new[] { ' ', ',', ':', ';', '.', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                switch (format)
                {
                    case DataFormat.Hex:
                        var hexValues = data.Split(new[] { ' ', ',', ':', ';', '.', '-', '_',  }, StringSplitOptions.RemoveEmptyEntries);
                        return hexValues.Select(h => byte.Parse(h, System.Globalization.NumberStyles.HexNumber)).ToArray();
                    case DataFormat.Binary:
                        var binaryValues = data.Split(new[] { ' ', ',', ':', ';', '.', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
                        return binaryValues.Select(b => Convert.ToByte(b, 2)).ToArray();

                    case DataFormat.ASCIIString:
                        return Encoding.ASCII.GetBytes(data);
                    case DataFormat.Utf8String:
                        return Encoding.UTF8.GetBytes(data);


                    case DataFormat.Double:
                        if (double.TryParse(data, out double doubleValue))
                            return BitConverter.GetBytes(doubleValue);
                        else
                            throw new FormatException("Invalid Double format");
                    case DataFormat.Float:
                        if (float.TryParse(data, out float floatValue))
                            return BitConverter.GetBytes(floatValue);
                        else
                            throw new Exception("Invalid Float format");
                    case DataFormat.Decimal:
                        if (decimal.TryParse(data, out decimal decimalValue))
                        {
                            int[] bits = decimal.GetBits(decimalValue);
                            return bits.SelectMany(BitConverter.GetBytes).ToArray();
                        }
                        else
                            throw new Exception("Invalid Decimal FO");
                    case DataFormat.Int64:
                        if (long.TryParse(data, out long int64Value))
                            return BitConverter.GetBytes(int64Value);
                        else
                            throw new Exception("Invalid Int64 format");
                    case DataFormat.UInt64:
                        if (ulong.TryParse(data, out ulong uint64Value))
                            return BitConverter.GetBytes(uint64Value);
                        else
                            throw new Exception("Invalid UInt64 format");
                    case DataFormat.Int32:
                        if (int.TryParse(data, out int int32Value))
                            return BitConverter.GetBytes(int32Value);
                        else
                            throw new Exception("Invalid Int32 format");
                    case DataFormat.UInt32:
                        if (uint.TryParse(data, out uint uint32Value))
                            return BitConverter.GetBytes(uint32Value);
                        else
                            throw new Exception("Invalid UInt32 format");

                    default: throw new Exception("Error: Unsupported format forequest conversion");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error converting request: {ex.Message}");
            }
        }

        public static string ConvertResponse(byte[] data, DataFormat format)
        {
            try
            {
                switch (format)
                {
                    case DataFormat.Decimal:
                        int[] bits = new int[4];
                        if (data.Length >= 16)
                        {
                            for (int i = 0; i < 4; i++)
                                bits[i] = BitConverter.ToInt32(data, i * 4);
                            return new decimal(bits).ToString();
                        }
                        else
                            return "Error: Insufficient data for Decimal";
                    case DataFormat.Hex:
                        return string.Join(" ", data.Select(b => b.ToString("X2")));


                    case DataFormat.Binary:
                        return string.Join(" ", data.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));


                    case DataFormat.Utf8String:
                        return Encoding.UTF8.GetString(data);
                    case DataFormat.ASCIIString:
                        return Encoding.ASCII.GetString(data);

                    case DataFormat.Double:
                        if (data.Length >= 8)
                            return BitConverter.ToDouble(data, 0).ToString();
                        else
                            return "Error: Insufficient data for Double";

                    case DataFormat.Float:
                        if (data.Length >= 4)
                            return BitConverter.ToSingle(data, 0).ToString();
                        else
                            return "Error: Insufficient data for Float";


                    case DataFormat.Int64:
                        if (data.Length >= 8)
                            return BitConverter.ToInt64(data, 0).ToString();
                        else
                            return "Error: Insufficient data for Int64";
                    case DataFormat.UInt64:
                        if (data.Length >= 8)
                            return BitConverter.ToUInt64(data, 0).ToString();
                        else
                            return "Error: Insufficient data for UInt64";
                    case DataFormat.Int32:
                        if (data.Length >= 4)
                            return BitConverter.ToInt32(data, 0).ToString();
                        else
                            return "Error: Insufficient data for Int32";
                    case DataFormat.UInt32:
                        if (data.Length >= 4)
                            return BitConverter.ToUInt32(data, 0).ToString();
                        else
                            return "Error: Insufficient data for UInt32";
                    case DataFormat.UInt16:
                        if (data.Length >= 2)
                            return BitConverter.ToUInt16(data, 0).ToString();
                        else
                            return "Error: Insufficient data for UInt16";
                    case DataFormat.Int16:
                        if (data.Length >= 2)
                            return BitConverter.ToInt16(data, 0).ToString();
                        else
                            return "Error: Insufficient data for Int16";
                    default:
                        return BitConverter.ToString(data);
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
