namespace ChainOfRespPattern
{
    public abstract class MoneyHandler
    {
        public MoneyHandler moneyHandler;

        public void NextMoneyHandler(MoneyHandler moneyHandler)
        {
            this.moneyHandler = moneyHandler;
        }

        public abstract void DispatchMoney(int amount);
    }
}
