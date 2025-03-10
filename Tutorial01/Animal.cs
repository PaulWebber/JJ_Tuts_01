using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial01
{
    public abstract class Animal
    {
        public virtual void Talk()
        {
            Console.WriteLine("talks like an animal");

        }

        //public virtual void Walk()
        //{
        //    Console.WriteLine("walk like an animal");
        //}

        public abstract void Walk();

    }
}
