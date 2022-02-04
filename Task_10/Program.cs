// Показать вторую цифру трёхзначного числа.

 int a = new Random().Next(100,999);
 Console.WriteLine( "new random: " + a);
 Console.WriteLine((a%100)/10);
