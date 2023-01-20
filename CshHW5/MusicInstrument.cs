using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW5
{
    internal class MusicInstrument
    {
        protected string _name;
        protected string _description;
        protected string _history;

        public MusicInstrument(string name, string description)
        {
            _name = name;
            _description = description; 
        }

        public void Show()
        {
            Console.WriteLine(_name);
        }

        public void Desc()
        {
            Console.WriteLine(_description);
        }

        public void SetHistory(string history)
        {
            _history = history;
        }

        public void History()
        {
            Console.WriteLine(_history);
        }

        public virtual void Sound(string sound = "Music instrument sound")
        {
            Console.WriteLine(sound);
        }


    }

    class Violin : MusicInstrument
    {
        public Violin(string name, string description) : base(name, description)
        {
            _name = name;
            _description = description;
        }

        public override void Sound(string sound = "Violin sound")
        {
            base.Sound(sound);
        }

    }

    class Trombone : MusicInstrument
    {
        public Trombone(string name, string description) : base(name, description)
        {
            _name = name;
            _description = description;
        }
        public override void Sound(string sound = "Trombone sound")
        {
            base.Sound(sound);
        }

    }

    class Uculele : MusicInstrument
    {
        public Uculele(string name, string description) : base(name, description)
        {
            _name = name;
            _description = description;
        }

        public override void Sound(string sound = "Trombone sound")
        {
            base.Sound(sound);
        }

    }

    class Cello : MusicInstrument
    {
        public Cello(string name, string description) : base(name, description)
        {
            _name = name;
            _description = description;
        }

        public override void Sound(string sound = "Cello sound")
        {
            base.Sound(sound);
        }

    }
}
