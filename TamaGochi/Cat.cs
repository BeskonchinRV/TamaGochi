using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stick
{
    public class Cat
    {
        private int hunger = 20;
        public string name;
        private int minhunger = 5;
        public bool alive = true;

        Random rand = new Random();

        public Cat(string name = "Floppa")
        {
            this.name = name;

        }
        public void Meow()
        {
            if (alive)
            {
                Console.WriteLine("Мяу");
            }
            else
            {
                Console.WriteLine("Ничего не происходит");
                Die();
            }
        }
        public string Name()
        {
            return name;
        }
        public void Eat(Food food)
        {
            if (alive == true)
            {
                Console.WriteLine($"Кошка ест: {food.type}. {food.health} HP");
                hunger += food.health;
            }
            Die();
        }
        public void Play()
        {
            if (alive)
            {
                Console.WriteLine("Кошка играет!");
                hunger -= 5;
                Die();
            }
        }
        public void Run()
        {
            if (alive)
            {
                Console.WriteLine("Кошка бежит!");
                hunger -= 5;
                Die();
            }
        }
        public void Die()
        {
            if (hunger < minhunger)
            {
                Console.WriteLine("Кошка умерла с голоду, вы плохо присматривали за ней!");
                alive = false;
            }
            if (hunger < 10 && alive == true)
            {
                Meow();
            }
        }
        public void Health()
        {
            Console.WriteLine($"Кошка чувствует это: голод: {hunger}");
        }
        public void Wait()
        {
            Console.WriteLine("\nПока кошка ждет, она будет делать что-то случайное или вообще ничего не делать.");
            int wait = rand.Next(1, 5);
            switch (wait)
            {
                case 1: Meow(); break;
                case 2: Run(); break;
                case 3: Play(); break;
                case 4: Console.WriteLine("Она просто пялиться в стену..."); break;
            }
        }
    }
}
