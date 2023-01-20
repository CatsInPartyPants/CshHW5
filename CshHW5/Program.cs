using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshHW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            Product car = new Product();
            car.SetFirstPart(10);
            car.SetSecondPart(20);
            car.ShowBalance();
            car.ReduceMoney(2, 21);
            car.ShowBalance();
            Console.ReadKey();

            //task 2

            Teapot teapot = new Teapot("Tefal", "Brand new teapot");
            Car nissan = new Car("Nissan", "Японцы делают вещи");
            Streamboat streamboat = new Streamboat("Гоголь", "Ездит по реке, возит пассажиров");
            Microwave microwave = new Microwave("Микроволновка", "Разогревает тарелку, а не еду");

            microwave.Show();
            microwave.MakeSound();
            microwave.Desc();

            nissan.MakeSound();
            nissan.Desc();
            Console.ReadKey();

            //task 3

            Violin violin = new Violin("Скрипка Страдивари", "Обычная, но дорогая");
            violin.SetHistory("скрипка Страдивари 1686 года, так называемая «аматизе». Эта скрипка принадлежала Третьякову и после его смерти была завещана Московской консерватории и оттуда попала в Госколлекцию.");

            violin.Show();
            violin.Desc();
            violin.History();
            violin.Sound();
            Console.ReadKey();

            //task 4

            Engineer engineer = new Engineer();
            engineer.Print();
            Console.ReadKey();
        }
    }
}
