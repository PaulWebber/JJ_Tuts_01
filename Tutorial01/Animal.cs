using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial01
{

    public interface IAnimal
    {
        void Talk();
        void Walk();

        int Walk(int numOfLegs);

        void Walk(double NumOfWhiskers);
    }

    public abstract class Animal : IAnimal
    {
        public virtual void Talk()
        {
            Console.WriteLine("talks like an animal");

        }

        public void Walk()
        {
            Console.WriteLine("walk like an animal");
        }

        public abstract int Walk(int numOfLegs);

        public abstract void Walk(double NumOfWhiskers);
        

    }
}
