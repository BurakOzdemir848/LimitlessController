namespace LimitlessController
{
    public class Config
    {
        public string IP { get; set; }
        public string Port { get; set; }
        public List<KeyItem> Keys { get; set; }
    }
    public class KeyItem
    {
        public string Key { get; set; }
    }

}
