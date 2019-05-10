using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Israel
{

    class Francotirador : Shape
    {
        readonly float MaxDistance;
        public Francotirador(string name, float MaxDistance) : base(name)
        {
            this.MaxDistance = MaxDistance;
            this.name = name;
        }
    }
}
