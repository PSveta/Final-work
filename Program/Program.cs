//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма.

// Метод чтения данных
int ReadData(string line)
{
    Console.Write(line);
    int array = int.Parse(Console.ReadLine() ?? "0");
    return array;
}

//Метод проверяет длину элемента массива и если она меньше или ровна 3, то записывает элемент в новый массив
void ShortArray(string[] array, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        newArray[count] = array[i];
        count++;
        }
    }
}

//Метод печати массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] array = new string[4] {"1234", "1567", "-2", "computer science"};
string[] newArray = new string[array.Length];
ShortArray(array, newArray);
PrintArray(newArray);