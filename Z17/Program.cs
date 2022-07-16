Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// if(x > 0 && y > 0)
// {
//     Console.WriteLine("первая четверть");
// }
// else if(x < 0 && y > 0)
// {
//     Console.WriteLine("вторая четверть");
// }
// else if(x < 0 && y < 0)
// {
//     Console.WriteLine("третья четверть");
// }
// else if(x > 0 && y < 0)
// {
//     Console.WriteLine("четвертая четверть");
// }
// else
// {
//     Console.WriteLine("некорректные координаты");
// }

string Quarter(int xc, int yc)
{
if(xc > 0 && yc > 0) return ("первая четверть");
if(xc < 0 && yc > 0) return ("вторая четверть");
if(xc < 0 && yc < 0) return ("третья четверть");
if(xc > 0 && yc < 0) return ("четвертая четверть");
return ("некорректные координаты");
}

string result = Quarter(x, y);
Console.WriteLine(result);