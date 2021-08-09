namespace MementoPattern
{
    public class LedTv
    {
        public string Size { get; set; }

        public string Price { get; set; }

        public bool USBSupport { get; set; }

        public LedTv(string Size, string Price, bool USBSupport)
        {
            this.Size = Size;
            this.Price = Price;
            this.USBSupport = USBSupport;
        }

        public string GetDetails()
        {
            return "LEDTV [Size=" + Size + ", Price=" + Price + ", USBSupport=" + USBSupport + "]";
        }
    }
}
