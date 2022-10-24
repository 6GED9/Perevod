using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perevod
{
    internal class Program
    {
        string chis;
        static void Main(string[] args)
        {
            Program perevod = new Program();
            perevod.Perevod1();
            Console.ReadLine();

        }

        public void Perevod1()
        {
            char[] numb = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
            Console.Write("Введите число: ");
            chis = Console.ReadLine();
            chis = chis.ToLower();
            Console.Write("Введите из какой: ");
            int Iz = int.Parse(Console.ReadLine());
            Console.Write("Введите в какую: ");
            int V = int.Parse(Console.ReadLine());
            if (chis != "" && Iz != 0 && V != 0)
            {
                if (!(Iz > 1 && Iz < 17 && V > 1 && V < 17))
                {
                    Console.WriteLine("Неверная система счисления! Введите число от 2 до 16.");
                    return;
                };
                for (int i = 0; i < chis.Length; i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        if (chis[i] == numb[j])
                        {
                            if (j > (Iz - 1))
                            {
                                Console.WriteLine("Число не соответствует системе счисления.");
                                return;
                            }
                        }
                    }
                }
            }
            int chis_10 = 0;
            int st = 0;
            for (int i = chis.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (chis[i] == numb[j])
                    {
                        chis_10 += (int)(j * Math.Pow(Iz, st));
                        st++;
                        break;
                    }
                }
            }
            string res = "";
            while (chis_10 != 0)
            {
                res = numb[chis_10 % V].ToString() + res;
                chis_10 = chis_10 / V;
            }
            Console.WriteLine("Результат: "+ res.ToUpper());
        }
    }
}
