// Задайте с клавиатуры массив ыещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.



Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
FillArrayRandomNumbers(num);
Console.WriteLine("массив: ");
PrintArray(num);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < num.Length; i++)
{
    if (num[i] > max)
        {
            max = num[i];
        }
    if (num[i] < min)
        {
            min = num[i];
        }
}


Console.WriteLine($"Разница между максимальным и минимальным значением  {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}