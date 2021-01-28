using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGame
{
    public class Inventario
    {
        List<BaseEntity> inventario;
        public Inventario()
        {
            inventario = new List<BaseEntity>();
        }
        public BaseEntity this[int i]
        {
            get { return inventario[i]; }
            set { inventario[i] = value; }
        }
        public void Add(BaseEntity oggetto)
        {
            inventario.Add(oggetto);
        }
        public void Remove(BaseEntity oggetto)
        {
            inventario.Remove(oggetto);
        }
        public void RemoveAt(int index)
        {
            inventario.RemoveAt(index);
        }
    }
}