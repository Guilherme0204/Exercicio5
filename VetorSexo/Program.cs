using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetorSexo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random sorte = new Random();  
            int[] idade = new int[100];
            int[] sexo = new int[100];
            int mulher = 0; int homem = 0;
            int tmulher = 0;
            int thomem = 0;
            int controleh = 0;
            int controlem = 0;
            //Armazenando dados nas variaveis idade e sexo
            for (int i = 0; i < idade.Length; i++)
            {

                idade[i] = sorte.Next(1, 100);
                sexo[i] = sorte.Next(1, 3);
            }
            //Verificando as condicionais para a realização de calcúlos
            for (int i = 0;i < idade.Length; i++)
            {
                if (sexo[i] == 1)
                {
                    mulher++;
                    if (idade[i] >=25 && idade[i] <=50)
                    {
                        controlem++;
                       tmulher += idade[i];
                    }
                    
                }
                else if (sexo[i] == 2)
                {
                    homem++;
                    if (idade[i] >= 50 && idade[i] <= 75)
                    {
                        controleh++;
                        thomem += idade[i];
                    }
                }

            }
            double pm = Convert.ToDouble(controlem) / Convert.ToDouble(mulher) * 100;
            double ph = Convert.ToDouble(controleh) / Convert.ToDouble(homem) * 100;
            double mediam = Convert.ToDouble(tmulher) / Convert.ToDouble(controlem);
            double mediah = Convert.ToDouble(thomem) / Convert.ToDouble(controleh);
            Console.WriteLine($"A porcentagem de mulheres entre 25 e 50 anos é de {pm.ToString("N2")}%");
            Console.WriteLine($"A porcentagem de homens entre 50 e 75 anos é de {ph.ToString("N2")}%");
            Console.WriteLine($"A média da idade das mulheres é de {mediam.ToString("N2")}");
            Console.WriteLine($"A média da idade dos homens é de {mediah.ToString("N2")}");
            Console.ReadKey();
        }
    }
}
