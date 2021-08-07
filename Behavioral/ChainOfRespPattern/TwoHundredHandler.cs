using System;

namespace ChainOfRespPattern
{
    public class TwoHundredHandler : MoneyHandler
    {
        public override void DispatchMoney(int amount)
        {
            int noOfNotesToDispatch = amount / 200;

            if (noOfNotesToDispatch > 0)
            {
                Console.Write($"Dispatching {noOfNotesToDispatch} two hundred rupee notes \n");
            }

            int pendingAmount = amount % 200;

            if (pendingAmount > 0)
            {
                moneyHandler.DispatchMoney(pendingAmount);
            }
        }
    }
}
