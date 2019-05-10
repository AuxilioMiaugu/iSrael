using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Israel
{
    class Sanador : Shape
    {
        readonly float Curacion;
        public Sanador(string name, float Curacion) : base(name)
        {
            this.name = name;
            this.Curacion = Curacion;
        }
    }
}
