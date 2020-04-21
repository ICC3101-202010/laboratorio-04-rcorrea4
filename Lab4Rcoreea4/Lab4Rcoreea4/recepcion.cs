using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Rcoreea4
{
    class recepcion:maquina
    {
        private string name;
        private int id;
        
        private int estado;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Memoria { get => memoria; set => memoria = value; }
        public int Estado { get => estado; set => estado = value; }

        public recepcion(string name,int id,int memoria,int estado)
        {
            this.Name = name;
            this.Id = id;
            this.Memoria = memoria;
            this.Estado = estado;
        }

       
        public override void encender()
        {
            Console.WriteLine("Recepcion"+id+" encendida");
            Estado = 1;
            
        }
        public override void apagar()
        {
            Console.WriteLine("Recepcion"+id+" Apagada");
            Estado = 0;
            memoria = 20;
        }
        public override void reiniciar()
        {
            Console.WriteLine("Recepcion"+id+" Reiniciada");
            Estado = 1;
            memoria = 20;
        }
        public override void MMemoria()
        {
            Random rnd = new Random();
            memoria -= rnd.Next(4);
        }
        
    }
}
