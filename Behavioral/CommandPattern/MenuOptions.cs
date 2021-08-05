namespace CommandPattern
{
    /// <summary>
    /// Invoker
    /// </summary>
    public class MenuOptions
    {
        private ICommand _copyCommand;
        private ICommand _pasteCommand;

        public MenuOptions(ICommand copyCommand, ICommand pasteCommand)
        {
            _copyCommand = copyCommand;
            _pasteCommand = pasteCommand;
        }

        public void OnCopy()
        {
            _copyCommand.Execute();
        }

        public void OnPaste()
        {
            _pasteCommand.Execute();
        }
    }
}
