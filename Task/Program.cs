Console.WriteLine("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine());
string[] array1 = new string[size];
string[] array2 = new string[array1.Length];

    for (int i = 0; i < size; i++){
	    Console.Write("Введите элемент массива: ");
    string result = Console.ReadLine();
	    array1[i] = result;  
}

Console.Write("Введенный массив: [");
Console.Write(string.Join(",", array1));
Console.Write("]");
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
Console.WriteLine();
Console.Write("Полученный массив: [");
void PrintArray(string[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++){
        if (array1[i].Length <= 3){
            array2[j] = array1[i];
            Console.Write(array2[j] + ",");
            j++;
        }  
    }
    Console.Write("]");
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);

