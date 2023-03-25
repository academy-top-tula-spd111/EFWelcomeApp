using EFWelcomeApp;

/*
using (ApplicationContext context = new ApplicationContext())
{
    Employee tom = new() { Name = "Tom", Age = 32 };
    Employee bob = new() { Name = "Bob", Age = 27 };

    context.Employees.Add(tom);
    context.Employees.Add(bob);

    context.SaveChanges();
}
*/

using(ApplicationContext context = new ApplicationContext())
{
    var employes = context.Employees.ToList();
    Console.WriteLine("Employees:");
    foreach(Employee e in employes)
        Console.WriteLine($"{e.Id}: {e.Name} ({e.Age})");
}