Console.WriteLine("введите координаты точки А");
Console.Write("XA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("YA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты точки B");
Console.Write("XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("YB: ");
int yb = Convert.ToInt32(Console.ReadLine());

double dlina(int xac, int yac, int xbc, int ybc)
{
    double ab = Math.Sqrt((xbc-xac)*(xbc-xac)+(ybc-yac)*(ybc-yac)); 
    return(ab);
}

double result = dlina(xa, ya, xb, yb);
Console.WriteLine(Math.Round (result,2));