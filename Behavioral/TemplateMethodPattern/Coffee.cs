using System;

namespace TemplateMethodPattern
{
    public abstract class Coffee
    {
        /// <summary>
        /// This has to be implemented by the subclasses
        /// </summary>
        public abstract void AddCoffeePowder();

        /// <summary>
        /// This can be overridden by the subclasses 
        /// if there is change in implemnetation
        /// </summary>
        public virtual void AddMilk()
        {
            Console.WriteLine("Milk added");
        }

        /// <summary>
        /// This can be overridden by the subclasses 
        /// if there is change in implemnetation
        /// </summary>
        public virtual void AddSugar()
        {
            Console.WriteLine("Sugar added");
        }

        /// <summary>
        /// This can be overridden by the subclasses 
        /// if there is change in implemnetation
        /// </summary>
        public virtual void BoilWater()
        {
            Console.WriteLine("Water boiled");
        }

        /// <summary>
        /// This is the template method
        /// </summary>
        public void PrepareCoffee()
        {
            BoilWater();
            AddMilk();
            AddSugar();
            AddCoffeePowder();

            Console.WriteLine("\n" + this.GetType().Name + " is Ready");
        }
    }
}
