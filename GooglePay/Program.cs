using System;

namespace GooglePay
{
    class Program
    {
        static void Main(string[] args)
        {
            var restAPIObj = new RestAPI();
            restAPIObj.TestInsertOfferClassAndObject();
            Console.WriteLine("Hello World!");
        }
    }
}
