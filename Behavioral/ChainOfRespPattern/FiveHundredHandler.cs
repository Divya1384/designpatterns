using System;

namespace ChainOfRespPattern
{
    public class FiveHundredHandler : MoneyHandler
    {
        public override void DispatchMoney(int amount)
        {
            int noOfNotesToDispatch = amount / 500;

            if (noOfNotesToDispatch > 0)
            {
                Console.Write($"Dispatching {noOfNotesToDispatch} five hundred rupee notes \n");
            }

            int pendingAmount = amount % 500;

            if (pendingAmount > 0)
            {
                moneyHandler.DispatchMoney(pendingAmount);
            }
        }
    }
}
