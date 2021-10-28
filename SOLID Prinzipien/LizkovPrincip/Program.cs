using System;

namespace LizkovPrincip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    #region BadCode

    public class Sauerkirsche
    {
        public virtual string GetColor()
        {
            return "rot";
        }
    }

    public class Erdbeere : Sauerkirsche
    {
        public override string GetColor()
        {
            return "rot";
        }
    }
    #endregion


    #region GoodCode

    public abstract class Fruit
    {
        public abstract string GetColor();
    }

    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }

    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
    #endregion
}
