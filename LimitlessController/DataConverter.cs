namespace LimitlessController
{
    public class DataConverter
    {
        public static string ConvertResponse(byte[] data, DataFormat format)
        {
            try
            {
                switch (format)
                {
                    case DataFormat.Hex:
                        return string.Join(" ", data.Select(b => b.ToString("X2")));

                    case DataFormat.Utf8String:
                        return System.Text.Encoding.UTF8.GetString(data);

                    case DataFormat.Binary:
                        return string.Join(" ", data.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));

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
                        if (data.Length >= 2)
                            return BitConverter.ToUInt16(data, 0).ToString();
                        else
                            return "Error: Insufficient data for UInt16";
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
