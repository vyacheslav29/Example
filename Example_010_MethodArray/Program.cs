// Нахождения индекса в масиве заданного числа этого же массива:

int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

int n = array.Length; //Определяет длинну массива.
int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++; // Счетчик +1 шаг.
}