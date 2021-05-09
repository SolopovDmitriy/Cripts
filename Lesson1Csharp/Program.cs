using System;

namespace My3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chr = { 'F', 'I', 'O', ':', ' ', 'e', 'm', 'a', 'i', 'l', ' ', 'a', 'd', 'r', 'e', 's', 's', ' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] result = new char[chr.Length];
            Console.Write("TEXT: ");
            Console.WriteLine(chr);

            // шифрование числов
            for (int i = 0; i < chr.Length; i++)
            {
                result[i] = (char)(chr[i] + 5);
            }
            Console.Write("SHIFR + 5: ");
            Console.WriteLine(result); // вывод результата
                                       // дешифрование числов
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (char)(result[i] - 5);
            }
            Console.Write("DESHIFR - 5: ");
            Console.WriteLine(result); // вывод результата

            // шифрование буквой
            for (int i = 0; i < chr.Length; i++)
            {
                result[i] = (char)(chr[i] + 'a');
            }
            Console.Write("SHIFR + a: ");
            Console.WriteLine(result);

            // дешифрование буквой
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (char)(result[i] - 'a');
            }
            Console.Write("DESHIFR - a: ");
            Console.WriteLine(result); // вывод результата


            // шифрование логическим XOR буквой R
            for (int i = 0; i < chr.Length; i++)
            {
                result[i] = (char)(chr[i] ^ 'r');
            }
            Console.Write("SHIFR XOR: ");
            Console.WriteLine(result); // вывод результата
                                       // дешифрование логическим XOR буквой R
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (char)(result[i] ^ 'r');
            }
            Console.Write("DESHIFR XOR: ");
            Console.WriteLine(result); // вывод результата
            Console.ReadKey();
        }
    }
}





