﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double nota1, nota2, nota3, media = 0;

            
            Console.Write("Entre com a nota 1 : ");
            nota1 = double.Parse(Console.ReadLine());    

            Console.Write("Entre com a nota 2 : ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Entre com a nota 3 : ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            
            Console.Write("A média ponderada é : " + media);

            Console.ReadKey();   
        }
    }
}