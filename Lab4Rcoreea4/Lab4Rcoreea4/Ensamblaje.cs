using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Rcoreea4
{
    class Ensamblaje:maquina
    {
        private string name;
        private int memoria;
        private int estado;
        private int id;

        public Ensamblaje(string name,int memoria,int estado,int id)
        {
            this.Name = name;
            this.Memoria = memoria;
            this.Estado = estado;
            this.Id = id;
        }

        public string Name { get => name; set => name = value; }
        public int Memoria { get => memoria; set => memoria = value; }
        public int Estado { get => estado; set => estado = value; }
        public int Id { get => id; set => id = value; }

        public override void apagar()
        {
            Console.WriteLine("Ensamblaje" + Id + "apagada");
            Estado = 0;
        }
        public override void encender()
        {
            Console.WriteLine("Ensamblaje" + Id + "encendida");
            Estado = 1;
        }
        public override void reiniciar()
        {
            Console.WriteLine("Ensamblaje" + Id + "reiniciada");
            Estado = 1;
        }
    }

}

