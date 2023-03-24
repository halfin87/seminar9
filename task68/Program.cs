// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = 3;
int n = 2;
Console.WriteLine(GetNumber(m,n));
int GetNumber(int m, int n)
{
if (m == 0) return n + 1;
else if (m > 0 && n == 0) return GetNumber(m - 1, 1);
else  return GetNumber(m - 1,GetNumber(m,n - 1));
}
