using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial01
{
    public class Cow : Animal
    {
        public override void Talk()
        {
            Console.WriteLine("Moo");

        }

        public override void Walk()
        {
            Console.WriteLine("walks on four legs");
        }

        public void Milk()
        {
            Console.WriteLine("milk me");
        }

        public override int Walk(int numOfLegs)
        {
            throw new NotImplementedException();
        }

        public override void Walk(double NumOfWhiskers)
        {
            throw new NotImplementedException();
        }
    }
}
