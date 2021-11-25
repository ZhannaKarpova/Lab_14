using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14
{


    abstract class Animal
    {
        
        public string name;
        // конструктор, устанавливающий значение по умолчанию для названия;
        public Animal(string name)
        {
            this.name = name;
        }
        //  Свойства доступа к полям класса
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //  Метод Print() - вывести значения полей на экран
        public void Print()
        {
            Console.WriteLine(Name);
        }
        //  Абстрактный метод   
        public abstract void Say();

        //неабстрактный метод ShowInfo()
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Say");
        }
        //Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal.
        class Cat : Animal
        {
            public Cat(string name) :base(name)
            {
                Name = name;

            }
            public override void Say() // реализация абстрактного метода
            {
                Console.WriteLine("мяу");
            }
        }
        class Dog : Animal
        {
            public Dog(string name) : base(name)
            {
                Name = name;

            }
            public override void Say() // реализация абстрактного метода
            {
                Console.WriteLine("гав");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                List<Animal> animals = new List<Animal>();
                animals.Add(new Dog("собака Тёма"));
                animals.Add(new Cat("кот Пушок"));
                foreach (Animal animal in animals)
                    animal.Say();

                Console.ReadKey();
            }
        }   } }
