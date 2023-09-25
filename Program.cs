using RadekPA;

Console.WriteLine("Hello, and welcome to Labojko's family!\n");

Human Chris = new("Chris", "Labojko", "male", 19);
Human Peter = new("Peter", "Labojko", "male", 18);
Human Wojtek = new("Wojtek", "Labojko", "male", 15);
Human Adam = new("Adam", "Labojko", "male", 13);
Human Anna = new("Anna", "Labojko", "female", 9);
Human Greg = new("Greg", "Labojko", "male", 46);
Human Ela = new("Ela", "Labojko", "female", 46);
Human Dominika = new("Domi", "Nowak", "female", 23);

Console.WriteLine("\n1) Każdy człowiek potrafi podać swoje imię i nazwisko oraz wiek.\n");
Console.WriteLine(Greg.ToString());
Console.WriteLine(Ela.ToString());
Console.WriteLine(Chris.ToString());
Console.WriteLine(Peter.ToString());
Console.WriteLine(Wojtek.ToString());
Console.WriteLine(Adam.ToString());
Console.WriteLine(Anna.ToString());
Console.WriteLine(Dominika.ToString());

Employee GregEmployee = new("Greg", "Labojko", "male", 46, 150, "The Labojko's Company", "familys head", 6000, 22);
Employee ElaEmployee = new("Ela", "Labojko", "male", 46, 80, "The Labojko's Company", "housewife", 7000, 22);
Employee ChrisEmployee = new("Chris", "Labojko", "male", 19, 20, "The Labojko's Company", "delfin", 850, 2);
Employee PeterEmployee = new("Peter", "Labojko", "male", 18, 15, "The Labojko's Company", "fizyczny", 545, 1);

Console.WriteLine("\n2) Każdy pracownik potrafi się przedstawić tak jak człowiek podając dodatkowo firmę w jakiej pracuje i swoje stanowisko służbowe.\n");
Console.WriteLine(GregEmployee.ToString());
Console.WriteLine(ElaEmployee.ToString());
Console.WriteLine(ChrisEmployee.ToString());
Console.WriteLine(PeterEmployee.ToString());




Specialist ElaSpecialist = new("Ela", "Labojko", "male", 46, 80, "The Labojko's Company", "housewife", 7000, 22);
Console.WriteLine(ElaSpecialist.ToString());


Manager GregManager = new("Greg", "Labojko", "male", 46, 150, "The Labojko's Company", "familys head", 6000, 22);
Console.WriteLine(GregManager.ToString());
GregManager.LosePhone();
Console.WriteLine(GregManager.ToString());
Console.WriteLine("\n5) Każdy kierownik będzie podawał poziom swojej lojalności (I am loyal at X points level :) )\n");
Console.WriteLine(GregManager.LoyaltyAnnouncement());

Console.WriteLine(ElaEmployee.PromoteToSpecialist());
Console.WriteLine(ChrisEmployee.PromoteToSpecialist());

Console.WriteLine(ChrisEmployee.ToString());
ChrisEmployee.Rise();
Console.WriteLine(ChrisEmployee.ToString());




Chris.ChangeName("dupa");
Console.WriteLine(Chris.ToString());
