Console.WriteLine("введите номер четверти");
int num = Convert.ToInt32(Console.ReadLine());

string Quarter(int numc)
{
if(numc == 1) return ("X > _0, Y > 0");
if(numc == 2) return ("X < 0, Y > 0");
if(numc == 3) return ("X < _0, Y < 0");
if(numc == 4) return ("X > _0, Y < 0");
return ("нет такой четверти");
}

string result = Quarter(num);
Console.WriteLine(result);
