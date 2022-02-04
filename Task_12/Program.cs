// Удалить вторую цифру трёхзначного числа.

Console.WriteLine("Enter a three-digit number: ");

int num = int.Parse(Console.ReadLine());
int number = (num / 100 * 10) + (num % 10);

Console.WriteLine("Number" + num + "After removing the second digit" + number +".");
    
