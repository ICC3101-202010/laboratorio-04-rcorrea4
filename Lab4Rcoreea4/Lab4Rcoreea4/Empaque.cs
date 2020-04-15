using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Rcoreea4
{
    class Empaque:maquina
    {
        public string name;
        public int memoria;
        public int estado;
        public int id;

        public Empaque(string name, int memoria,int estado,int id)
        {
            this.name = name;
            this.memoria = memoria;
            this.estado = estado;
            this.id = id;
        }

        public override void apagar()
        {
            Console.WriteLine("Empaque" + id + "apagada");
            estado = 0;
        }
        public override void encender()
        {
            Console.WriteLine("Empaque" + id + "encendida");
            estado = 1;
        }
        public override void reiniciar()
        {
            Console.WriteLine("Empaque" + id + "encendida");
            estado = 1;
        }
    }

}

