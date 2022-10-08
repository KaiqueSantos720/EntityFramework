using IntroEntityFramework.Models;

Console.WriteLine("Hello, World!");

SystemContext context = new SystemContext();

//A titulo de teste, utiliza-se migrations no projeto aspnet core
context.Database.EnsureCreated(); //garante que o banco existe


//Insert / Create
//context.Computers.Add(new Computer(1, "16gb", "i5"));
//context.SaveChanges();

// context.Computers.Add(new Computer(2, "4gb", "i3"));
// context.SaveChanges();

// context.Computers.Add(new Computer(3, "32gb", "i9"));
// context.SaveChanges();


//Get
foreach(var computer in context.Computers.ToList())
{
    Console.WriteLine($"{computer.Id}, {computer.Ram}, {computer.Processor}");
};

//GetById
var pc = context.Computers.Find(3);
Console.WriteLine($"Computador buscado: {pc.Id}, {pc.Ram}, {pc.Processor}");

//Update
pc.Ram = "64gb";
pc.Processor = "i7";
context.Computers.Update(pc);
context.SaveChanges();
Console.WriteLine($"Computador buscado atualizado: {pc.Id}, {pc.Ram}, {pc.Processor}");

//Remover passando pc
context.Computers.Remove(pc);
context.SaveChanges();

foreach(var computer in context.Computers.ToList())
{
    Console.WriteLine($"{computer.Id}, {computer.Ram}, {computer.Processor}");
};