
Console.WriteLine("Введите пятизначное число!");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 9999 && num < 100000) 
    {
    string result = Polindrom(num);
    Console.WriteLine(result);
    }
else 
     Console.WriteLine("это не пятизначное число");   
string Polindrom(int numc)
{
    int a = numc / 10000;
    int b = numc % 10000 / 1000;
    int d = numc % 100 / 10;
    int e = numc % 10;

    if (a == e && b == d) return ("палиндром");
    return ("не палиндром");
}
