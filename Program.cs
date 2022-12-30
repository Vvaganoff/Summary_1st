Console.Write("Ввести массив с клавиатуры?(да, нет): ");
string Answer = Console.ReadLine();

string[] strArray = new string[] {};

if (Answer == "Да" || Answer == "Yes" || Answer == "Y" || Answer == "да" || Answer == "yes" || Answer == "y")
{
    //Console.Write("Введите размер массива: ");
    //int arraySize = Convert.ToInt32(Console.ReadLine());
    //string[] strArray = new string[arraySize];
    strArray = FillManually();
}
else if (Answer == "Нет" || Answer == "No" || Answer == "N" || Answer == "нет" || Answer == "no" || Answer == "n")
{
    strArray = new string[] { "Hallo", "2", "world", ":-)" };
}
else
{
    Console.WriteLine("Я вас не понял!");
    return;
}

foreach(string strElement in strArray)
{
    if (strElement.Length <= 3)
    {
        Console.Write($"{strElement}, ");
    }
}

string[] FillManually()
{
    Console.Write("Введите одномерный массив строк через запятую: ");
    string strArrayRaw = Console.ReadLine(); //Пользователь вводит строки массива через запятую 
    char[] charSeparators = new char[] { ' ', 'x', '+', '*', 'X', '-', ',', ';' };//Определяем, чем пользователь может отделить строки
    string[] strArray = strArrayRaw.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
    return strArray;
}