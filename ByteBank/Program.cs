using System;

namespace ByteBank
{
    class Program
    {
        static void Main( string[] args )
        {
            try
            {
                Metodo();
            }
            catch( Exception e )
            {
                Console.WriteLine( e.Message );
                Console.WriteLine( e.StackTrace );
            }
        }

        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao( 0 );
        }

        private static void TestaDivisao( int divisor )
        {

            int resultado = Dividir( 10, divisor );
            Console.WriteLine( "Resultado da divisão de 10 por " + divisor + " é " + resultado );
        }

        private static int Dividir( int numero, int divisor )
        {
            try
            {
                return numero / divisor;
            }
            catch
            {
                Console.WriteLine( "Exceção com numero=" + numero + "e divisor=" + divisor );
                throw;
            }
        }
    }
}