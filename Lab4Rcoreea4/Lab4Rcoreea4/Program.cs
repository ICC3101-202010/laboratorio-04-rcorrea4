using System;

namespace Lab4Rcoreea4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la fabrica");
            recepcion recepcion1 = new recepcion("recepcion1", 1, 20, 0);
            almacenamiento almacenamiento1 = new almacenamiento("alm1", 1, 20, 0);
            Ensamblaje ensamblaje1 = new Ensamblaje("ensamblaje1", 1, 20, 0);
            Verificar verificar1 = new Verificar("verificar1", 1, 20, 0);
        }
    }
}
