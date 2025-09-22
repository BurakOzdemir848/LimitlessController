using System.Text;
using LimitlessController.Core.Models;

namespace LimitlessController.Core.Services
{
    public class Utf8StringConverter : IDataConverter
    {
        public DataFormat Format => DataFormat.Utf8String;

        public byte[] ConvertRequest(string data, bool isBigEndian, bool clrf) =>
            AddCrlf(Encoding.UTF8.GetBytes(data), clrf);

        public string ConvertResponse(byte[] data, bool isBigEndian)
        {
            int zero = Array.IndexOf(data, (byte)0);
            return zero >= 0 ? Encoding.UTF8.GetString(data, 0, zero) : Encoding.UTF8.GetString(data);
        }

        private static byte[] AddCrlf(byte[] bytes, bool clrf) =>
            clrf ? bytes.Concat(Encoding.ASCII.GetBytes("\r\n")).ToArray() : bytes;
    }
}
