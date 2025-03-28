using UsingTopLevelStatementFetaure.Entities;

Print();
static void Print()
{
    Console.WriteLine("Hello, World!");
}
Person anilPerson = new() { Id = 1, Name = "Anil" };
Console.WriteLine(anilPerson.Name);

//the types must be created at the bottom of this file
//class Person
//{
//    public int Id { get; set; }
//    public string Name { get; set; } = "";
//}
