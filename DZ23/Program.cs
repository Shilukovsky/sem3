Console.WriteLine("введите номер четверти");
int num = Convert.ToInt32(Console.ReadLine());

WriteSquareTable(num);

void WriteSquareTable(int num)
{
    int i =1;
    while (i <= num)
    {
        Console.WriteLine($"| {i} | {i * i * i, 3} |");
        i++;
    }
}    