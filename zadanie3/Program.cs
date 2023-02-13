Console.WriteLine("Введите число = ");
int x = int.Parse(Console.ReadLine());
int y = x;
x = -x; 
while (x<=y)
    {if ((x % 2) == 0)
    Console.Write(x + " ," );
    x++;
    }
