namespace AbstractFactoryPattern
{
    public class MacFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextBox CreateTexBox()
        {
            return new MacTextBox();
        }
    }
}
