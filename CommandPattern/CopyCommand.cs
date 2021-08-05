namespace CommandPattern
{
    /// <summary>
    /// Concrete Command
    /// </summary>
    public class CopyCommand : ICommand
    {
        private Document _document;

        public CopyCommand(Document document)
        {
            _document = document;
        }

        public void Execute()
        {
            _document.Copy();
        }
    }
}
