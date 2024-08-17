
// Task 1 : Variable Declaration and Initialization

string name = "John Doe";
int age = 25;
bool isAdmin = true;

Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Is Admin: " + isAdmin);

// Task 2: Even or Odd Determination

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}

// Task 3: Print Numbers 1 to 10

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// Task 4: Array Sum and Elements

int[] numbers = { 2, 4, 6, 8, 10 };
int sum = 0;

foreach (int num in numbers)
{
    Console.WriteLine(num);
    sum += num;
}

Console.WriteLine("Sum: " + sum);

// Task 5: Personalized Greeting Method

  Greet("Alice");

static void Greet(string name)
{
    Console.WriteLine($"Hello, {name} !");
}