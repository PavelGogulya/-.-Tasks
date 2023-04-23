Задача 55.
создать программу в которой будет замена строк на столбцы
Задача 55
void EditArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}

bool CheckArray(int[,] array)
{
    return array.GetLength(0) == array.GetLength(1);
}