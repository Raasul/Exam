using Exam;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.Linq;

string world; //*_*
world = "42";
world = "hello";
const string kek = "constant";
string input = Console.ReadLine();
Console.WriteLine(input);
var reference = new Object();
int? value = 5;
input = null;
//value = Int32.Parse(Console.ReadLine());


int num1 = 25;
int num2 = 10;
if (num1 > num2)
{
    Console.WriteLine("25>10");
}
else
{
    Console.WriteLine("25<10");
}

switch (input)
{
    case "case1":
        break;
    case "case2":
        break;
    default:
        break;
}

int a, b;
b = -4;
a = b >=0 ? b : b*b; 

while (true)
{
    Console.WriteLine("---------------");
    break;
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("test");
}


for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}


do
{
    Console.WriteLine("hello");
} while (false);


int[] array = { 1, 2, 3, 4, 5 };


foreach (var item in array)
{
    Console.WriteLine(item);
}

Console.WriteLine("array " + array.Length);


DateTime date = DateTime.Now;
date.AddYears(1);

var concant = date + input;


string name = "Расул";
string message = $"Привет, меня зовут {name}!";
Console.WriteLine(message);

var publicClass = new PublicClass();

