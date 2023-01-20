using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW5
{
    internal class Device
    {
        protected string _name;
        protected string _description;

        public Device(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public virtual void MakeSound(string sound = "Default sound")
        {
            Console.WriteLine(sound);
        }

        public void Desc()
        {
            Console.WriteLine(_description);
        }

        public void Show()
        {
            Console.WriteLine(_name);
        }
    }

    class Teapot : Device
    {
        public Teapot(string name, string description) : base(name, description)
        {
            _name = name;
            _description = description;
        }

        public override void MakeSound(string sound = "Teapot sound")
        {
            Console.WriteLine(sound);
        }
    }

    class Microwave : Device
    {
        public Microwave(string name, string description) : base(name, description)
        {
            _name = name;
            _description = description;
        }

        public override void MakeSound(string sound = "Pi Pi Pi")
        {
            Console.WriteLine(sound);
        }

    }

    class Car : Device
    {
        public Car(string name, string description) : base(name, description)
        {
            _name = name;
            _description = description;
        }

        public override void MakeSound(string sound = "Wrum Wrum")
        {
            Console.WriteLine(sound);
        }

    }

    class Streamboat : Device
    {
        public Streamboat(string name, string description) : base(name, description)
        {
            _name = name;
            _description = description;
        }
        public override void MakeSound(string sound = "Tuu Tuu")
        {
            Console.WriteLine(sound);
        }
    }

}
