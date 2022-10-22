using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fund_UnderstandingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.NumberOfOwners = 5;
            // Console.WriteLine(myCar.NumberOfOwners);

            //myCar = DetermineMarketValue(myCar);
            //Console.WriteLine("{0:C}",myCar.MarketValue);

            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
            

            Console.ReadLine();
        }

        private static Car DetermineMarketValue (Car car)
        {
            car.MarketValue = 100.0M;
            return car;
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal MarketValue { get; set; }
        public int NumberOfOwners { private get; set; }
        
        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;
            return carValue;
        
        }

    }
}
