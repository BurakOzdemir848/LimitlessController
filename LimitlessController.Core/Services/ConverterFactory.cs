using LimitlessController.Core.Models;

namespace LimitlessController.Core.Services
{
    public class ConverterFactory
    {
        private readonly Dictionary<DataFormat, IDataConverter> _converters;

        public ConverterFactory(IEnumerable<IDataConverter> converters)
        {
            _converters = converters.ToDictionary(c => c.Format);
        }

        public IDataConverter Resolve(DataFormat format)
        {
            if (_converters.TryGetValue(format, out var converter))
                return converter;

            throw new NotSupportedException($"No converter registered for {format}");
        }
    }
}
