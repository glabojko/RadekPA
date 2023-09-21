namespace RadekPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // var nowy = new Employee();
            Human nowychop = new("greg", "labojko", "male", 46);
            Console.WriteLine(nowychop.ToString());
            Employee nowyPracownik = new("greg", "labojko", "male", 46, 30, "cap", "manango", 500.3, 3);
            Console.WriteLine(nowyPracownik.ToString());
            nowyPracownik.ChangeName("dupa");
            Console.WriteLine(nowyPracownik.ToString());
            nowyPracownik.Rise();
            Console.WriteLine(nowyPracownik.ToString());
            Console.WriteLine(nowychop.ToString());
            Console.WriteLine(nowychop.Metoda());
            Console.WriteLine(nowyPracownik.Metoda());

        }
    }
}