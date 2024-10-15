namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {


             car car1 = new car("Bmw" ,"i5" ,4);
             car1.mile = 295;
             car1.ShowFullInfo();
             bicycle bicycle1 = new bicycle("Altec","Sirius" ,2);
             bicycle1.mile = 65;
             bicycle1.ShowFullInfo();
            /*car[] cars = new car[1];
            cars[0] = new car("Ford", "Mustang", 4);
            
            Array.Resize(ref cars, 2);
            cars[1] = new car("Bmw", "i5", 4);
            foreach (car car in cars)
            {
                car.ShowFullInfo();

            }
            bicycle[] bicycles = new bicycle[1];
            bicycles[0] = new bicycle("asd","dsa",2);
            Array.Resize(ref bicycles, 2);
            bicycles[1] = new bicycle("Altec","Sirius",2);
            foreach (bicycle bicycle in bicycles )
            {

                bicycle.ShowFullInfo();
            }
            */


              
        }
        public class car : vehicle
        {
            public int doorsNum;
            public car(string brand, string model, int doorsNum) : base(brand, model)
            {
                this.doorsNum = doorsNum;


            }
            public void ShowFullInfo()
            {

                Console.WriteLine($"brand:{brand}, model:{model},mile :{mile},doorsNum:{doorsNum}");
            }
           
            

        }
        public class bicycle:vehicle
        {
            public int whellNum;
            public bicycle (string brand, string model, int whellNum ):base(brand, model)
            {
                this.whellNum = whellNum;


            }
            public void ShowFullInfo()
            {
                Console.WriteLine($"brand:{brand},model:{model},mile:{mile},whellNum:{whellNum}");

            }



        }
        public class vehicle
        {
            public string brand;
            public string model;
            public double mile;
            public vehicle( string brand, string model )
            {
                this.brand = brand;
                this.model = model;
                

            }
            public vehicle(string brand, string model, double mile)
            {
                this.mile = mile;
            
            
            }



        }
    }
}
