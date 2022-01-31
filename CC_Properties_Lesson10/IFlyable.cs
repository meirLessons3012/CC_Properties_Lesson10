using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Properties_Lesson10
{
    internal interface IAliveThing
    {
        void Move();
    }

    public class Flower : IAliveThing
    {
        public void Move()
        {
            Console.WriteLine("moving...");
        }
    }

    internal interface IPerson : IAliveThing
    {
        void Run()
        {
            Console.WriteLine("running...");
        }
    }

    public class Person : IPerson
    {
        public void Move()
        {
            Console.WriteLine("...");
        }

        public void Run()
        {
            Console.WriteLine("person running...");
        }
    }


}
