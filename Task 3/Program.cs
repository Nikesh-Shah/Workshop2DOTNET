byte by = 1;
short sh = 2;
int i = 42;
long l = 4;
float f = 5.0f;
double d = 6.0;
decimal dec = 7.0m;
char c = 'A';
bool b = true;
string str = "Hello, World!";
Console.WriteLine($"byte: {by}, short: {sh}, int: {i}, long: {l}, float: {f}, double: {d}, decimal: {dec}, char: {c}, bool: {b}, string: {str}");
string name = i.ToString();
Console.WriteLine($"The string representation of int {i} is: {name}");

double newdob = Convert.ToDouble(i);
Console.WriteLine($"The double representation of int {i} is: {newdob}");