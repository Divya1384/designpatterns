namespace ChainOfRespPattern
{
    public class ATM
    {
        private TwoThousandHandler twoThousandHandler = new TwoThousandHandler();

        private FiveHundredHandler fiveHundredHandler = new FiveHundredHandler();

        private TwoHundredHandler twoHundredHandler = new TwoHundredHandler();

        private HundredHandler hundredHandler = new HundredHandler();

        public ATM()
        {
            twoThousandHandler.NextMoneyHandler(fiveHundredHandler);
            fiveHundredHandler.NextMoneyHandler(twoHundredHandler);
            twoHundredHandler.NextMoneyHandler(hundredHandler);
        }

        public void Withdraw(int amount)
        {
            twoThousandHandler.DispatchMoney(amount);
        }
    }
}
