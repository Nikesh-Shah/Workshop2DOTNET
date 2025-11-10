// See https://aka.ms/new-console-template for more information
int [] num= { 1, 2, 3, 4, 5 };

Array.Sort(num);
Console.WriteLine(string.Join(", ", num));
Array.Reverse(num);
Console.WriteLine(string.Join(", ", num));

for (int i =0;i<=num.Length-1;i++)
{
    Console.WriteLine(num[i]);
}
Console.WriteLine("\n");
Console.WriteLine(Array.IndexOf(num,3));