using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Rcoreea4
{
    class almacenamiento:maquina
    {
        private string name;
        private int memoria;
        private int estado;
        private int id;

        public almacenamiento(string name, int memoria,int estado,int id)
        {
            this.name = name;
            this.memoria = memoria;
            this.estado = estado;
            this.id = id;
        }

        public override void apagar()
        {
            Console.WriteLine("Almacenamiento" + id + "apagada");
            estado = 0;
        }
        public override void encender()
        {
            Console.WriteLine("Almacenamiento" + id + "encendida");
            estado = 1;
        }
        public override void reiniciar()
        {
            Console.WriteLine("Almacenamiento" + id + "reiniciada");
            estado = 0;
        }
    }   
    
}
