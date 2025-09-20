using System.Buffers.Binary;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LimitlessController
{
    public class DataConverter
    {
        public static byte[] ConvertRequest(string data, DataFormat format, bool isBigEndian, bool clrf)
        {
            var parts = data.Split(new[] { ' ', ',', ':', ';', '_', '-' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                byte[] bytes;

                switch (format)
                {
                    case DataFormat.Hex:
                        {
                            var cleaned = data.Replace(" ", "").Replace(",", "").Replace(":", "").Replace(";", "")
                                              .Replace("-", "").Replace("_", "")
                                              .Replace("0x", "", StringComparison.OrdinalIgnoreCase);
                            if (cleaned.Length == 0) return AddCrlfIfNeeded(Array.Empty<byte>(), clrf);
                            if ((cleaned.Length % 2) != 0) throw new FormatException("Hex length must be even!");

                            bytes = new byte[cleaned.Length / 2];
                            for (int i = 0; i < bytes.Length; i++)
                                bytes[i] = byte.Parse(cleaned.AsSpan(i * 2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
                            return AddCrlfIfNeeded(bytes, clrf);
                        }

                    case DataFormat.Binary:
                        {
                            var cleaned = data.Replace(" ", "").Replace(",", "").Replace(":", "").Replace(";", "")
                                              .Replace("-", "").Replace("_", "")
                                              .Replace("0b", "", StringComparison.OrdinalIgnoreCase);
                            if (cleaned.Length == 0) return AddCrlfIfNeeded(Array.Empty<byte>(), clrf);
                            if ((cleaned.Length % 8) != 0) throw new FormatException("Binary length must be a multiple of 8!");

                            bytes = new byte[cleaned.Length / 8];
                            for (int i = 0; i < bytes.Length; i++)
                            {
                                string octet = cleaned.AsSpan(i * 8, 8).ToString();
                                bytes[i] = Convert.ToByte(octet, 2);
                            }
                            return AddCrlfIfNeeded(bytes, clrf);
                        }

                    case DataFormat.ASCIIString:
                        return AddCrlfIfNeeded(Encoding.ASCII.GetBytes(data), clrf);

                    case DataFormat.Utf8String:
                        return AddCrlfIfNeeded(Encoding.UTF8.GetBytes(data), clrf);

                    case DataFormat.Double:
                        {
                            var ns = NumberStyles.Float | NumberStyles.AllowThousands;
                            bytes = new byte[parts.Length * 8];
                            for (int i = 0; i < parts.Length; i++)
                            {
                                double v = double.Parse(parts[i], ns, CultureInfo.InvariantCulture);
                                long bits = BitConverter.DoubleToInt64Bits(v);
                                if (isBigEndian) BinaryPrimitives.WriteInt64BigEndian(bytes.AsSpan(i * 8, 8), bits);
                                else BinaryPrimitives.WriteInt64LittleEndian(bytes.AsSpan(i * 8, 8), bits);
                            }
                            return AddCrlfIfNeeded(bytes, clrf);
                        }

                    case DataFormat.Float:
                        {
                            var ns = NumberStyles.Float | NumberStyles.AllowThousands;
                            bytes = new byte[parts.Length * 4];
                            for (int i = 0; i < parts.Length; i++)
                            {
                                float v = float.Parse(parts[i], ns, CultureInfo.InvariantCulture);
                                int bits = BitConverter.SingleToInt32Bits(v);
                                if (isBigEndian) BinaryPrimitives.WriteInt32BigEndian(bytes.AsSpan(i * 4, 4), bits);
                                else BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(i * 4, 4), bits);
                            }
                            return AddCrlfIfNeeded(bytes, clrf);
                        }

                    case DataFormat.Int16:
                        {
                            bytes = new byte[parts.Length * 2];
                            for (int i = 0; i < parts.Length; i++)
                            {
                                short v = short.Parse(parts[i], NumberStyles.Integer, CultureInfo.InvariantCulture);
                                if (isBigEndian) BinaryPrimitives.WriteInt16BigEndian(bytes.AsSpan(i * 2, 2), v);
                                else BinaryPrimitives.WriteInt16LittleEndian(bytes.AsSpan(i * 2, 2), v);
                            }
                            return AddCrlfIfNeeded(bytes, clrf);
                        }

                    case DataFormat.UInt16:
                        {
                            bytes = new byte[parts.Length * 2];
                            for (int i = 0; i < parts.Length; i++)
                            {
                                ushort v = ushort.Parse(parts[i], NumberStyles.Integer, CultureInfo.InvariantCulture);
                                if (isBigEndian) BinaryPrimitives.WriteUInt16BigEndian(bytes.AsSpan(i * 2, 2), v);
                                else BinaryPrimitives.WriteUInt16LittleEndian(bytes.AsSpan(i * 2, 2), v);
                            }
                            return AddCrlfIfNeeded(bytes, clrf);
                        }

                    case DataFormat.Int32:
                        {
                            bytes = new byte[parts.Length * 4];
                            for (int i = 0; i < parts.Length; i++)
                            {
                                int v = int.Parse(parts[i], NumberStyles.Integer, CultureInfo.InvariantCulture);
                                if (isBigEndian) BinaryPrimitives.WriteInt32BigEndian(bytes.AsSpan(i * 4, 4), v);
                                else BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(i * 4, 4), v);
                            }
                            return AddCrlfIfNeeded(bytes, clrf);
                        }

                    case DataFormat.UInt32:
                        {
                            bytes = new byte[parts.Length * 4];
                            for (int i = 0; i < parts.Length; i++)
                            {
                                uint v = uint.Parse(parts[i], NumberStyles.Integer, CultureInfo.InvariantCulture);
                                if (isBigEndian) BinaryPrimitives.WriteUInt32BigEndian(bytes.AsSpan(i * 4, 4), v);
                                else BinaryPrimitives.WriteUInt32LittleEndian(bytes.AsSpan(i * 4, 4), v);
                            }
                            return AddCrlfIfNeeded(bytes, clrf);
                        }

                    case DataFormat.Int64:
                        {
                            bytes = new byte[parts.Length * 8];
                            for (int i = 0; i < parts.Length; i++)
                            {
                                long v = long.Parse(parts[i], NumberStyles.Integer, CultureInfo.InvariantCulture);
                                if (isBigEndian) BinaryPrimitives.WriteInt64BigEndian(bytes.AsSpan(i * 8, 8), v);
                                else BinaryPrimitives.WriteInt64LittleEndian(bytes.AsSpan(i * 8, 8), v);
                            }
                            return AddCrlfIfNeeded(bytes, clrf);
                        }

                    case DataFormat.UInt64:
                        {
                            bytes = new byte[parts.Length * 8];
                            for (int i = 0; i < parts.Length; i++)
                            {
                                ulong v = ulong.Parse(parts[i], NumberStyles.Integer, CultureInfo.InvariantCulture);
                                if (isBigEndian) BinaryPrimitives.WriteUInt64BigEndian(bytes.AsSpan(i * 8, 8), v);
                                else BinaryPrimitives.WriteUInt64LittleEndian(bytes.AsSpan(i * 8, 8), v);
                            }
                            return AddCrlfIfNeeded(bytes, clrf);
                        }

                    case DataFormat.Decimal:
                        {
                            bytes = new byte[parts.Length * 16];
                            for (int i = 0; i < parts.Length; i++)
                            {
                                decimal v = decimal.Parse(parts[i], NumberStyles.Number, CultureInfo.InvariantCulture);
                                int[] bits = decimal.GetBits(v);

                                if (isBigEndian)
                                {
                                    BinaryPrimitives.WriteInt32BigEndian(bytes.AsSpan(i * 16 + 0, 4), bits[0]);
                                    BinaryPrimitives.WriteInt32BigEndian(bytes.AsSpan(i * 16 + 4, 4), bits[1]);
                                    BinaryPrimitives.WriteInt32BigEndian(bytes.AsSpan(i * 16 + 8, 4), bits[2]);
                                    BinaryPrimitives.WriteInt32BigEndian(bytes.AsSpan(i * 16 + 12, 4), bits[3]);
                                }
                                else
                                {
                                    BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(i * 16 + 0, 4), bits[0]);
                                    BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(i * 16 + 4, 4), bits[1]);
                                    BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(i * 16 + 8, 4), bits[2]);
                                    BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(i * 16 + 12, 4), bits[3]);
                                }
                            }
                            return AddCrlfIfNeeded(bytes, clrf);
                        }

                    default:
                        throw new Exception("Error: Unsupported format for request conversion");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error converting request: {ex.Message}");
            }
        }

        private static byte[] AddCrlfIfNeeded(byte[] bytes, bool clrf)
        {
            if (!clrf) return bytes;
            var crlf = Encoding.ASCII.GetBytes("\r\n");
            var withCrlf = new byte[bytes.Length + 2];
            Buffer.BlockCopy(bytes, 0, withCrlf, 0, bytes.Length);
            Buffer.BlockCopy(crlf, 0, withCrlf, bytes.Length, 2);
            return withCrlf;
        }

        public static string ConvertResponse(byte[] data, DataFormat format, bool isBigEndian)
        {
            try
            {
                switch (format)
                {
                    case DataFormat.Hex:
                        return string.Join(" ", data.Select(b => b.ToString("X2", CultureInfo.InvariantCulture)));

                    case DataFormat.Binary:
                        return string.Join(" ", data.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));

                    case DataFormat.Utf8String:
                        {
                            int zero = Array.IndexOf(data, (byte)0);
                            return zero >= 0 ? Encoding.UTF8.GetString(data, 0, zero) : Encoding.UTF8.GetString(data);
                        }

                    case DataFormat.ASCIIString:
                        {
                            int zero = Array.IndexOf(data, (byte)0);
                            return zero >= 0 ? Encoding.ASCII.GetString(data, 0, zero) : Encoding.ASCII.GetString(data);
                        }

                    case DataFormat.Double:
                        {
                            if (data.Length % 8 != 0) return $"Error: Expected multiples of 8 bytes, got {data.Length}";
                            int n = data.Length / 8;
                            var sb = new StringBuilder();
                            for (int i = 0; i < n; i++)
                            {
                                var span = new ReadOnlySpan<byte>(data, i * 8, 8);
                                long bits = isBigEndian ? BinaryPrimitives.ReadInt64BigEndian(span)
                                                        : BinaryPrimitives.ReadInt64LittleEndian(span);
                                double v = BitConverter.Int64BitsToDouble(bits);
                                if (i > 0) sb.Append(' ');
                                sb.Append(v.ToString("R", CultureInfo.InvariantCulture));
                            }
                            return sb.ToString();
                        }

                    case DataFormat.Float:
                        {
                            if (data.Length % 4 != 0) return $"Error: Expected multiples of 4 bytes, got {data.Length}";
                            int n = data.Length / 4;
                            var sb = new StringBuilder();
                            for (int i = 0; i < n; i++)
                            {
                                var span = new ReadOnlySpan<byte>(data, i * 4, 4);
                                int bits = isBigEndian ? BinaryPrimitives.ReadInt32BigEndian(span)
                                                       : BinaryPrimitives.ReadInt32LittleEndian(span);
                                float v = BitConverter.Int32BitsToSingle(bits);
                                if (i > 0) sb.Append(' ');
                                sb.Append(v.ToString("R", CultureInfo.InvariantCulture));
                            }
                            return sb.ToString();
                        }

                    case DataFormat.Int16:
                        {
                            if (data.Length % 2 != 0) return $"Error: Expected multiples of 2 bytes, got {data.Length}";
                            int n = data.Length / 2;
                            var sb = new StringBuilder();
                            for (int i = 0; i < n; i++)
                            {
                                var span = new ReadOnlySpan<byte>(data, i * 2, 2);
                                short v = isBigEndian ? BinaryPrimitives.ReadInt16BigEndian(span)
                                                      : BinaryPrimitives.ReadInt16LittleEndian(span);
                                if (i > 0) sb.Append(' ');
                                sb.Append(v.ToString(CultureInfo.InvariantCulture));
                            }
                            return sb.ToString();
                        }

                    case DataFormat.UInt16:
                        {
                            if (data.Length % 2 != 0) return $"Error: Expected multiples of 2 bytes, got {data.Length}";
                            int n = data.Length / 2;
                            var sb = new StringBuilder();
                            for (int i = 0; i < n; i++)
                            {
                                var span = new ReadOnlySpan<byte>(data, i * 2, 2);
                                ushort v = isBigEndian ? BinaryPrimitives.ReadUInt16BigEndian(span)
                                                       : BinaryPrimitives.ReadUInt16LittleEndian(span);
                                if (i > 0) sb.Append(' ');
                                sb.Append(v.ToString(CultureInfo.InvariantCulture));
                            }
                            return sb.ToString();
                        }

                    case DataFormat.Int32:
                        {
                            if (data.Length % 4 != 0) return $"Error: Expected multiples of 4 bytes, got {data.Length}";
                            int n = data.Length / 4;
                            var sb = new StringBuilder();
                            for (int i = 0; i < n; i++)
                            {
                                var span = new ReadOnlySpan<byte>(data, i * 4, 4);
                                int v = isBigEndian ? BinaryPrimitives.ReadInt32BigEndian(span)
                                                    : BinaryPrimitives.ReadInt32LittleEndian(span);
                                if (i > 0) sb.Append(' ');
                                sb.Append(v.ToString(CultureInfo.InvariantCulture));
                            }
                            return sb.ToString();
                        }

                    case DataFormat.UInt32:
                        {
                            if (data.Length % 4 != 0) return $"Error: Expected multiples of 4 bytes, got {data.Length}";
                            int n = data.Length / 4;
                            var sb = new StringBuilder();
                            for (int i = 0; i < n; i++)
                            {
                                var span = new ReadOnlySpan<byte>(data, i * 4, 4);
                                uint v = isBigEndian ? BinaryPrimitives.ReadUInt32BigEndian(span)
                                                     : BinaryPrimitives.ReadUInt32LittleEndian(span);
                                if (i > 0) sb.Append(' ');
                                sb.Append(v.ToString(CultureInfo.InvariantCulture));
                            }
                            return sb.ToString();
                        }

                    case DataFormat.Int64:
                        {
                            if (data.Length % 8 != 0) return $"Error: Expected multiples of 8 bytes, got {data.Length}";
                            int n = data.Length / 8;
                            var sb = new StringBuilder();
                            for (int i = 0; i < n; i++)
                            {
                                var span = new ReadOnlySpan<byte>(data, i * 8, 8);
                                long v = isBigEndian ? BinaryPrimitives.ReadInt64BigEndian(span)
                                                     : BinaryPrimitives.ReadInt64LittleEndian(span);
                                if (i > 0) sb.Append(' ');
                                sb.Append(v.ToString(CultureInfo.InvariantCulture));
                            }
                            return sb.ToString();
                        }

                    case DataFormat.UInt64:
                        {
                            if (data.Length % 8 != 0) return $"Error: Expected multiples of 8 bytes, got {data.Length}";
                            int n = data.Length / 8;
                            var sb = new StringBuilder();
                            for (int i = 0; i < n; i++)
                            {
                                var span = new ReadOnlySpan<byte>(data, i * 8, 8);
                                ulong v = isBigEndian ? BinaryPrimitives.ReadUInt64BigEndian(span)
                                                      : BinaryPrimitives.ReadUInt64LittleEndian(span);
                                if (i > 0) sb.Append(' ');
                                sb.Append(v.ToString(CultureInfo.InvariantCulture));
                            }
                            return sb.ToString();
                        }

                    case DataFormat.Decimal:
                        {
                            if (data.Length % 16 != 0) return $"Error: Expected multiples of 16 bytes, got {data.Length}";
                            int n = data.Length / 16;
                            var sb = new StringBuilder();
                            for (int i = 0; i < n; i++)
                            {
                                var s0 = new ReadOnlySpan<byte>(data, i * 16 + 0, 4);
                                var s1 = new ReadOnlySpan<byte>(data, i * 16 + 4, 4);
                                var s2 = new ReadOnlySpan<byte>(data, i * 16 + 8, 4);
                                var s3 = new ReadOnlySpan<byte>(data, i * 16 + 12, 4);

                                int lo, mid, hi, flags;
                                if (isBigEndian)
                                {
                                    lo = BinaryPrimitives.ReadInt32BigEndian(s0);
                                    mid = BinaryPrimitives.ReadInt32BigEndian(s1);
                                    hi = BinaryPrimitives.ReadInt32BigEndian(s2);
                                    flags = BinaryPrimitives.ReadInt32BigEndian(s3);
                                }
                                else
                                {
                                    lo = BinaryPrimitives.ReadInt32LittleEndian(s0);
                                    mid = BinaryPrimitives.ReadInt32LittleEndian(s1);
                                    hi = BinaryPrimitives.ReadInt32LittleEndian(s2);
                                    flags = BinaryPrimitives.ReadInt32LittleEndian(s3);
                                }

                                var dec = new decimal(new int[] { lo, mid, hi, flags });
                                if (i > 0) sb.Append(' ');
                                sb.Append(dec.ToString(CultureInfo.InvariantCulture));
                            }
                            return sb.ToString();
                        }

                    default:
                        return string.Join(" ", data.Select(b => b.ToString("X2", CultureInfo.InvariantCulture)));
                }
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}
