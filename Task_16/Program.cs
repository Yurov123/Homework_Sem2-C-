// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Enter number: ");
int num = Convert.ToInt16(Console.ReadLine());
switch (num)
{
    case 1: Console.WriteLine("Monday"); break;
    case 2: Console.WriteLine("Tuesday"); break;
    case 3: Console.WriteLine("Wednesday"); break;
    case 4: Console.WriteLine("Thursday"); break;
    case 5: Console.WriteLine("Friday"); break;
    case 6: Console.WriteLine("Saturday day off"); break;
    case 7: Console.WriteLine("Sunday day off"); break;
    default: Console.WriteLine("ERROR"); break;
}    
