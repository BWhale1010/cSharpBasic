string name = "Paul";
int age = 20;

string GetDescription(string name, int age)
{
    return $"Hello, My name is {name} and " +
        $"I am {age} years old";
}

string description;
if (name == "Paul" && age == 20)
{
    description = GetDescription(name, age);
}
else
{
    description = "Invalid name or age.";
}

Console.WriteLine(description);
Console.ReadKey();