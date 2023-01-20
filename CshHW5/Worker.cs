using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW5
{
    public abstract class Worker
    {
        public abstract void Print();
    }

    public class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("This is president");
        }
    }

    public class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("This is security");
        }
    }

    public class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("This is manager");
        }
    }

    public class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("This is engineer");
        }
    }

}
