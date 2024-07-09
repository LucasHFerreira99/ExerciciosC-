using System;

namespace ExerciciosEstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int pref, alcool=0, gasolina=0, diesel=0;

            pref = int.Parse(Console.ReadLine());
            
            while ( pref != 4 )
            {
                if( pref == 1 )
                {
                    alcool++;
                }
                else if( pref == 2 )
                {
                    gasolina++;
                }
                else if( pref == 3 )
                {
                    diesel++;
                }
                pref = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Alcool: " +alcool);
            Console.WriteLine("Gasolina: " +gasolina);
            Console.WriteLine("Diesel: " +diesel);



        }
    }
}