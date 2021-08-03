namespace AbstractFactoryPattern
{
    public class LinuxFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new LinuxButton();
        }

        public ITextBox CreateTexBox()
        {
            return new LinuxTextBox();
        }
    }
}
