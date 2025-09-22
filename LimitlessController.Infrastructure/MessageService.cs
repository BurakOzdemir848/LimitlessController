using LimitlessController.Core;
using LimitlessController.Core.Models;
using LimitlessController.Core.Services;

namespace LimitlessController.Infrastructure.Services
{
    public class MessageService
    {
        private readonly IConnection _connection;
        private readonly ConverterFactory _factory;

        public MessageService(IConnection connection, ConverterFactory factory)
        {
            _connection = connection;
            _factory = factory;
        }

        public async Task<MessageResult> SendAndReceiveAsync(
            string requestText,
            DataFormat requestFormat,
            DataFormat responseFormat,
            bool isBigEndian,
            bool clrf,
            CancellationToken token)
        {

            var requestConverter = _factory.Resolve(requestFormat);
            byte[] requestBytes = requestConverter.ConvertRequest(requestText, isBigEndian, clrf);


            await _connection.SendAsync(clrf, requestBytes, token);


            byte[] response = await _connection.ReceiveAsync(null, token);
            if (response == null || response.Length == 0)
                throw new InvalidOperationException("No response received!");

            string hexDump = _factory.Resolve(DataFormat.Hex).ConvertResponse(response, isBigEndian);
            string formatted = _factory.Resolve(responseFormat).ConvertResponse(response, isBigEndian);


            return new MessageResult
            {
                RequestText = requestText,
                HexDump = hexDump,
                Formatted = formatted
            };
        }
    }
}
