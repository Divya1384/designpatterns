namespace CommandPattern
{
    /// <summary>
    /// Concrete Command
    /// </summary>
    public class PasteCommand : ICommand
    {
        private Document _document;

        public PasteCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Paste();
        }
    }
}
