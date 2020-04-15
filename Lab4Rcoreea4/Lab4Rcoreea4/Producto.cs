using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Rcoreea4
{
    class Producto
    {
        private string name;
        private int id;
         public Producto(string name,int id)
        {
            this.Name = name;
            this.Id = id;

        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
    }
}
