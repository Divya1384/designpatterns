using System;

namespace AbstractFactoryPattern
{
    public class WinFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ITextBox CreateTexBox()
        {
            return new WinTextBox();
        }
    }
}
