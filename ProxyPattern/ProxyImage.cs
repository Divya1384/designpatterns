namespace ProxyPattern
{
    public class ProxyImage : IImage
    {
        private string FileName { get; set; }

        private RealImage realImage = null;

        public ProxyImage(string fileName)
        {
            FileName = fileName;
        }

        public void DisplayImage()
        {
            if (realImage == null)
            {
                realImage = new RealImage(FileName);
            }
            realImage.DisplayImage();
        }
    }
}
