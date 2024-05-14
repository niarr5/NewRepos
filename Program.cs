class Program
{
    static void Main(string[] args)
    {
        // Вводим числа
        int a3a2a1 = 123; // Пример для a3a2a1
        int b2b1 = 45;    // Пример для b2b1

        // Получаем цифры
        int a1 = a3a2a1 % 10;
        int a2 = (a3a2a1 / 10) % 10;
        int a3 = a3a2a1 / 100;

        int b1 = b2b1 % 10;
        int b2 = b2b1 / 10;

        // Вычисляем разность
        int c1 = a1 - b1;
        int c2 = a2 - b2;
        int c3 = a3;

        // Обработка "заема"
        if (c1 < 0)
        {
            c1 += 10;
            c2--;
        }
        if (c2 < 0)
        {
            c2 += 10;
            c3--;
        }

        // Выводим результат
        Console.WriteLine("Разность чисел:");
        Console.WriteLine("c3c2c1 = {0}{1}{2}", c3, c2, c1);
    }
}
