namespace RadekPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, and welcome to Labojko's company!");
            
            Human Chris = new("Chris", "Labojko", "male", 19);
            Human Peter = new("Peter", "Labojko", "male", 18);
            Human Wojtek = new("Wojtek", "Labojko", "male", 15);
            Human Adam = new("Adam", "Labojko", "male", 13);
            Human Anna = new("Anna", "Labojko", "male", 9);
            Console.WriteLine(Chris.ToString());
            Console.WriteLine(Peter.ToString());
            Console.WriteLine(Wojtek.ToString());
            Console.WriteLine(Adam.ToString());
            Console.WriteLine(Anna.ToString());
            Employee ChrisEmployee = new("Chris", "Labojko", "male", 19, 20, "The Labojko's Company", "manango", 825.5, 2);
            Console.WriteLine(ChrisEmployee.ToString());
            ChrisEmployee.ChangeName("dupa");
            //Console.WriteLine(nowyPracownik.ToString());
            //nowyPracownik.Rise();
            //Console.WriteLine(nowyPracownik.ToString());
            //Console.WriteLine(nowychop.ToString());
            //Console.WriteLine(nowychop.Metoda());
            //Console.WriteLine(nowyPracownik.Metoda());

        }
    }
}