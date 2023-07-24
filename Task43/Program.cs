// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindIntersection(double k1, double b1, double k2, double b2)
{
    double intersectionX = (b2 - b1) / (k1 - k2);
    double intersectionY = (k1 * intersectionX + b1);
    Console.WriteLine($"Точка пересечения - ({Math.Round(intersectionX, 2)}, {Math.Round(intersectionY, 2)})");
}

int GetImput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double k1 = GetImput("Введите коэффицент k первой прямой: ");
double b1 = GetImput("Введите коэффицент b первой прямой: ");
double k2 = GetImput("Введите коэффицент k второй прямой: ");
double b2 = GetImput("Введите коэффицент b второй прямой: ");
FindIntersection(k1, b1, k2, b2);