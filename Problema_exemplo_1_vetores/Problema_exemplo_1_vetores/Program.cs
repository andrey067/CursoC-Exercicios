﻿using System;
using System.Globalization;
namespace Problema_exemplo_1_vetores
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite quantas pessoas vão ser cadastradas");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum =0;
            for(int i=0; i< n; i++)
            {
                sum += vect[i];
            }
            double avg = sum / n;
            Console.WriteLine("Average Height"+ avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
