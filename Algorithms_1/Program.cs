using System.ComponentModel;

try
{
    Console.WriteLine("Выберете действие: " +
    "\r\n 1 - решение квадратного уравнения" +
    "\r\n 2 - гипотенуза прямоугольного треугольника по двум катетам" +
    "\r\n 3 - исследует введенное число");//Находит его квадрат, куб, корень, кубический корень
    int firstAction = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    switch (firstAction)
    {
        case 1://Решение квадратного уравнения
            {
                Console.WriteLine("Решение квадратного уравнения");
                Console.Write("a = ");
                var a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                var b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                var c = double.Parse(Console.ReadLine());
                double x1, x2;
                //дискриминант
                var discriminant = Math.Pow(b, 2) - 4 * a * c;
                if (discriminant < 0)
                {
                    Console.WriteLine("Квадратное уравнение не имеет корней");
                }
                else
                {
                    if (discriminant == 0) //квадратное уравнение имеет два одинаковых корня
                    {
                        x1 = -b / (2 * a);
                        x2 = x1;
                    }
                    else //уравнение имеет два разных корня
                    {
                        x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                        x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    }
                    //вывод корней уравнения
                    Console.WriteLine($"x1 = {x1}; x2 = {x2}");
                }


            }
            break;

        case 2://Нахождение гипотенузы прямоугольного треугольника по двум катетам
            {
                try
                {
                    Console.WriteLine("Нахождение гипотенузы прямоугольного треугольника по двум катетам");
                    Console.Write("A = ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("B = ");
                    double b = Convert.ToDouble(Console.ReadLine());

                    double res = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    Console.WriteLine("The gipotenuza is {0:0.00}", res);

                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка ввода данных, введите число");
                }
                
                
            }
            break; 

        case 3: //Исследование введённого числа
            {
                try
                {
                    Console.WriteLine("Исследование числа");
                    Console.Write("Введите число для исследования: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    
                    Console.WriteLine($"Квадрат числа = {0}",Math.Pow(a,2));
                    Console.WriteLine($"Куб числа = {0}",Math.Pow(a,3));
                    Console.WriteLine($"Корень числа = {0}", Math.Sqrt(a));
                    Console.WriteLine($"Кубический корень = {0}", Math.Cbrt(a));
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный ввод");
                }
                
            }
            break;
    }

}
catch (Exception)
{
    Console.WriteLine("Неверный ввод действия");
    
}


