using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace VideoGame
{
    [DataContract]
    [KnownType(typeof(Entity))]
    public class Entity : BaseEntity
    {
        public Entity(string nome, string desc, bool racc, bool indoss, byte[] imgEntity) : base (nome, desc, racc, indoss, imgEntity) { }
    }
}