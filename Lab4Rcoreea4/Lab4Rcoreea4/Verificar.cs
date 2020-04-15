using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Rcoreea4
{
    class Verificar:maquina
    {
        public string name;
        public int memoria;
        public int estado;
        public int id;

        public Verificar(string name, int memoria, int estado, int id)
        {
            this.name = name;
            this.memoria = memoria;
            this.estado = estado;
            this.id = id;
        }

        public override void apagar()
        {
            Console.WriteLine("Verificar" + id + "apagada");
            estado = 0;

        }
        public override void encender()
        {
            Console.WriteLine("Verificar" + id + "prendida");
            estado = 1;
        }
        public override void reiniciar()
        {
            Console.WriteLine("Verificar" + id + "reiniciada");
            estado = 1;
        }
    }

}

