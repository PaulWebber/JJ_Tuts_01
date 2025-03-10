using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial01
{
    public class Bird : Animal
    {
        public virtual void Fly()
        {
            Console.WriteLine("fly like a bird");
        }

        public override void Walk()
        {
            Console.WriteLine("walks like a bird");
        }

    }
}
