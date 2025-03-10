using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial01
{
    public class Duck : Bird
    {
        public override void Talk()
        {
            Console.WriteLine("Quack quack");

        }

        public override void Fly()
        {
            Console.WriteLine("Duck is flying");
        }

        public override void Walk()
        {
            Console.WriteLine("Walk on two feet");
        }
    }
    
}
