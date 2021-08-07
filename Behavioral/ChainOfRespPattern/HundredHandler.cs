using System;

namespace ChainOfRespPattern
{
    public class HundredHandler : MoneyHandler
    {
        public override void DispatchMoney(int amount)
        {
            int noOfNotesToDispatch = amount / 100;

            if (noOfNotesToDispatch > 0)
            {
                Console.Write($"Dispatching {noOfNotesToDispatch} two hundred rupee notes \n");
            }

            int pendingAmount = amount % 100;

            if (pendingAmount > 0)
            {
                moneyHandler.DispatchMoney(pendingAmount);
            }
        }
    }
}
