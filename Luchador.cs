using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Israel
{
    class Luchador : Shape
    {
        readonly float Daño; 
        public Luchador(string name, float Daño) : base(name)
        {
            this.name = name;
            this.Daño = Daño;
        }
    }
}
