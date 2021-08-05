namespace AbstractFactoryPattern
{
    public interface IGuiFactory
    {
        IButton CreateButton();

        ITextBox CreateTexBox();
    }
}
