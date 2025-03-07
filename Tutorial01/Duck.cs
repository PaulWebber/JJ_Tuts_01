using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial01
{
    public class Duck : Animal
    {
        public override void Talk()
        {
            Console.WriteLine("Quack quack");

        }

        public void Fly()
        {
            Console.WriteLine("Duck is flying");
        }
    }
    
}
