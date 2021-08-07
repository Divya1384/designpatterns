using System;

namespace ChainOfRespPattern
{
    public class TwoThousandHandler : MoneyHandler
    {
        public override void DispatchMoney(int amount)
        {
            int noOfNotesToDispatch = amount / 2000;

            if (noOfNotesToDispatch > 0)
            {
                Console.Write($"Dispatching {noOfNotesToDispatch} two thousand rupee notes \n");
            }

            int pendingAmount = amount % 2000;

            if (pendingAmount > 0)
            {
                moneyHandler.DispatchMoney(pendingAmount);
            }
        }
    }
}
