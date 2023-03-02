//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.Write("Задайте количество элементов вашего массива:  ");
int ChisloElementov = int.Parse(Console.ReadLine());
int[] array = new int[ChisloElementov];

string FillingArray() // заполнение массива
{
    string result = "";
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine());
        result = result + array[i];
    }
    return result;
}
string PrintArray()  // вывод массива
{
    string result2 = "";
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write(array[i] + ", ");
    }
    return result2;
}
int NumberPositiveNumbers(int[] array)// подсчет положительных элементов
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

string arr = FillingArray();
string Print = PrintArray();
Console.WriteLine($"кол-во положительных элементов = {NumberPositiveNumbers(array)}");