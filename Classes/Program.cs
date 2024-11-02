namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", "Camry", 2025);

            Console.WriteLine($"Make: {car1.Make} / Model: {car1.Model} / Year: {car1.Year}");
        }
    }
}
