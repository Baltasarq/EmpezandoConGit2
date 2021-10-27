
namespace HolaMundo {
    class Saludo {
        static void Salida(string msg, bool cr=true)
        {
            System.Console.Write( msg );

            if ( cr ) {
                System.Console.WriteLine();
            }
        }
        
        static void Main()
        {
            Salida( "Hola, mundo mundial !!!" );
        }
    }
}
