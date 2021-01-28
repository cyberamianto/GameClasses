using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoGame
{
    public class EntityIndossabile : BaseEntity
    {
        public EntityIndossabile(string nome, string desc, bool racc) : base(nome, desc, racc, true) { }
    }
}