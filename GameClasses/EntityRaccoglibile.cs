using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGame
{
    public class EntityRaccoglibile : BaseEntity
    {
        public EntityRaccoglibile(string nome, string desc, bool indoss) : base(nome, desc, true, indoss) { }
    }
}