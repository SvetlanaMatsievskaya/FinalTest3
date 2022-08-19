Console.Write("Введите слова через пробел: ");// запрашиваем у пользователя строковые данные, которые будем добавлять в массив
string str = Console.ReadLine(); 

void PrintArray(string[] matrix)// создается функция для вывода массива на экран
{
for (int i = 0; i < matrix.Length; i++)
{
    Console.Write($"{matrix[i]} ");
}
Console.WriteLine();
}
string[] ar = str.Split(); // создается массив из элементов строки, предварительно разбив строку на слова
PrintArray(ar);

string[] temp = new string[ar.Length]; // создается временный массив, его размер равен массиву, созданному из строки

int count = 0;// создаем счетчик, который будет считать, сколько элементов соответствуют условию
for (int i = 0; i < ar.Length; i++)
{
if (ar[i].Length <= 3)
{
    temp[count] = ar[i];
    count++;
}
}

string[] ar2 = new string[count]; // этот массив создаётся на нужное кол-во элементов, соответствующих условию

for (int i = 0; i < count; i++)
{
ar2[i] = temp[i];
}

foreach (string s in ar2)
{
Console.Write(s + " ");   
}
