using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace VideoGame
{
    [DataContract]
    public class Inventario
    {
        [DataMember]
        List<Entity> inventario;
        public Inventario()
        {
            inventario = new List<Entity>();
        }
        public Entity this[int i]
        {
            get { return inventario[i]; }
            set { inventario[i] = value; }
        }
        public void Add(Entity oggetto)
        {
            inventario.Add(oggetto);
        }
        public void Remove(Entity oggetto)
        {
            inventario.Remove(oggetto);
        }
        public void RemoveAt(int index)
        {
            inventario.RemoveAt(index);
        }
    }
}