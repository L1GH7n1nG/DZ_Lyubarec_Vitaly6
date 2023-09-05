// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

double[] UserArray(int num)
{
	int j = 1;
	double[] arr = new double[num];
	for (int i = 0; i < arr.Length; i++)
	{
		Console.Write($"Введите {j} число: ");
		arr[i] = Convert.ToDouble(Console.ReadLine());
		j++;
	}
	return arr;
}

int NumberPositive(double[] arr)
{
	int count = 0;
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] > 0) count++;
	}
	return count;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] massiv = UserArray(size);
string strmassiv = string.Join(" ", massiv);
Console.WriteLine($"Количество чисел больше нуля в массиве - [{strmassiv}] = {NumberPositive(massiv)}");
