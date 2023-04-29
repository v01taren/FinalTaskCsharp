// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());

string[] stringArray = new string[m];
void array(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите { i + 1} элемент массива");
stringArray[i] = Console.ReadLine();
  }
}

string[] symbol(string[] stringArray)
{
    int n = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            n++;
    }

    string[] result = new string[n];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            result[j] = stringArray[i];
            j++;
        }
    }
    return result;
}

void printA(string[] stringArray)
{
    Console.WriteLine("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($" { stringArray[i]}, ");
    }
    Console.WriteLine("]");
}

array(stringArray);
printA(symbol(stringArray));

