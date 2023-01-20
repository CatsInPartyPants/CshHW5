using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW5
{
    internal class Money
    {
        public int _firstPart;
        public int _secondPart;

        public Money()
        {
            _firstPart = 0;
            _secondPart = 0;
        }
        public void SetFirstPart(int firstPart)
        {
            _firstPart = firstPart;
        }

        public void SetSecondPart(int secondPart)
        {
            _secondPart = secondPart;
        }

        public void ShowBalance()
        {
            Console.WriteLine(_firstPart.ToString() + "." + _secondPart.ToString());
        }
    }

    class Product : Money
    { 
        public void ReduceMoney(int firstPart, int secondPart)
        {
            _firstPart -= firstPart;
            if(_secondPart >= secondPart)
            {
                _secondPart -= secondPart;
            }
            else
            {
                _firstPart--;
                _secondPart = 100 + _secondPart - secondPart;
            }
            

        }
    }

}
