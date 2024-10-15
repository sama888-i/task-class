namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Asus",8,2000.88,16,512);
            notebook.Sale();
            notebook.ShowFullData();

        }
        public class Notebook : Product
        {
            public byte ram;
            public int storage;
            public Notebook(string name, int count, double price, byte ram, int storage) : base(name, count, price)
            {
                this.ram = ram;
                this.storage = storage;
            }
            public void GetFullInfo()
            {
                Console.WriteLine($"name:{name},count:{count},price:{price}, ram:{ram},storage:{storage},IsStock:{IsStock}");


            }
            public void ShowFullData()
            {
                if (IsStock )
                {
                    Console.WriteLine(GetFullInfo());

                }
                else
                {
                    Console.WriteLine("Mehsul Yoxdur!");
                }
            }



        }
        public class Product
        {
            public string name;
            public string description;
            public int count;
            public bool IsStock;
            public double price;
            public Product(string name, int count, double price)
            {
                this.name = name;
                this.count = count;
                this.price = price;




            }
            public Product(string name, int count, double price, string description, bool IsStock)
            {
                this.description = description;
                this.IsStock = IsStock;

            }
            public void Sale()
            {
                if (IsStock && count >0)
                {
                    Console.WriteLine("Mehsul Satisdadir");

                }
                else
                {
                    Console.WriteLine("Mehsul Yoxdur!");
                }

            }

        }
    }
}