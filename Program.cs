Console.WriteLine("Ввежите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
string[] startArray = new string[length];
int count = 0;
for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Ввежите {i}-й элемент: ");
    startArray[i] = Console.ReadLine();
    if (startArray[i].Length <= 3) count++;
}

string[] resultArray = new string[count];
count = 0;

Console.WriteLine("Элементы длиной не больше трех: ");
for (int i = 0; i < length; i++)
{
    if (startArray[i].Length <= 3)
    {   
        resultArray[count] = startArray[i];
        Console.WriteLine(resultArray[count]);
        count++;
    }
}