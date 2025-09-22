using LimitlessController.Core.Models;

namespace LimitlessController.Core.Services
{
    public interface IDataConverter
    {
        DataFormat Format { get; }
        byte[] ConvertRequest(string data, bool isBigEndian, bool clrf);
        string ConvertResponse(byte[] data, bool isBigEndian);
    }
}
