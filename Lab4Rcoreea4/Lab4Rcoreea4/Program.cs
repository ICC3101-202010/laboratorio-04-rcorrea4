using System;

namespace Lab4Rcoreea4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la fabrica");
            recepcion recepcion1 = new recepcion("recepcion1", 1, 20, 0);
            almacenamiento almacenamiento1 = new almacenamiento("alm1", 20, 0, 2);
            Ensamblaje ensamblaje1 = new Ensamblaje("ensamblaje1", 20, 0, 3);
            Verificar verificar1 = new Verificar("verificar1", 20, 0, 4);
            Empaque empaque1 = new Empaque("empaque1", 20, 0, 5);
            Producto producto1 = new Producto("producto1", 6);

            Console.WriteLine("Empieza el dia. Prendido de maquinas");
            recepcion1.encender();
            almacenamiento1.encender();
            ensamblaje1.encender();
            verificar1.encender();
            empaque1.encender();
            Random random = new Random();
            int minutos = 0;
            maquina[] maquinas = { recepcion1,almacenamiento1,ensamblaje1,verificar1,empaque1};
            while ( minutos < 480)//8 horas de 60 minutos
            {
                int i = 0;
                while (i < 5)
                {
                    maquinas[i].MMemoria();
                    minutos += random.Next(7);
                    
                    if (maquinas[i].memoria<=0)
                    {
                        maquinas[i].reiniciar();
                    }
                    i += 1;
                    
                }

            }
            int final = 0;
            while (final < 5)
            {
                maquinas[final].apagar();
                final += 1;
            }
            Console.ReadLine();


        }
    }
}
