using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Car.MyStaticMethod();
            Car myCar = new Car();
            Console.WriteLine(myCar.Make);
            
            /*myCar.Make = "Toyota";
            myCar.Model = "HighLander";
            myCar.Year = 2022;
            myCar.Color = "Green";
            */
            //тестkkk

            Car myThirdCar = new Car("Geely", "Coutlus", 2022, "Green");

            Car myOtherCar;
            myOtherCar = myThirdCar;

            myThirdCar.MyInstanceMethod();

            /*Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "Land Cruiser";
            Console.WriteLine("{0} {1} {2} {3}",
                            myCar.Make,
                            myCar.Model,
                            myCar.Year,
                            myCar.Color); */


            //myOtherCar = null;

            Console.ReadLine();
        }
    }
    class Car
    {
        public string Make { get; }
        public string Model{ get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            this.Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }
        public static void MyStaticMethod()
        {
            Console.WriteLine("This is a static method");
        }
        public void MyInstanceMethod()
        {
            Console.WriteLine("This is a non-static (instance) method:");
            Console.WriteLine("{0} {1} {2} {3}",
                this.Make,
                this.Model,
                this.Year,
                this.Color);
        }

    }
}
