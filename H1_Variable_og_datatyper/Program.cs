using System;

namespace H1_Variable_og_datatyper
{
    internal class Program
    {
        static void Main()
        {
            int length = 16;
            double width = 5.1;

            Console.WriteLine(length + width);

            // Area kan ikke få værdierne fra length of width, fordi width er en double og int kan ikke have kommatal.
            int area = length * width;

            // Her kan d godt blive length * width,
            // fordi d er en double og har de samme "muligheder" som både legth og width har, hvilket er kommatal
            double d = length * width;


        }
    }
}