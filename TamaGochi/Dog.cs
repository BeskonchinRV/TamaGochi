using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stack
{
    public class Dog
    {
        private int hunger = 30;
        public string name;
        private int minhunger = 5;
        public bool alive = true;

        Random rand = new Random();
        public Dog(string name = "Dogy")
        {
            this.name = name;
        }

        public void Bark()
        {
            if (alive)
            {
                Console.WriteLine("Лаять");
            }
            else
            {
                Console.WriteLine("Ничего не произошло");
                Die();
            }
        }
        public string Name()
        {
            return name;
        }
        public void Health()
        {
            Console.WriteLine($"Собака чувствует это: голод: {hunger}");
        }
        public void Eat(Food food)
        {
            if (alive == true)
            {
                Console.WriteLine($"Собака ест {food.type}. {food.health} HP");
                hunger += food.health;
            }
            Die();
        }
        private void Die()
        {
            if (hunger < minhunger)
            {
                Console.WriteLine("the dog have starved, you didn't care for it well enough!");
                alive = false;
            }
            if (hunger < 10 && alive == true)
            {
                Bark();
            }
        }
        public void Play()
        {
            if (alive)
            {
                Console.WriteLine("Собака играет!");
                hunger -= 5;
                Die();
            }
        }
        public void Run()
        {
            if (alive)
            {
                Console.WriteLine("Собака бежит!");
                hunger -= 5;
                Die();
            }

        }
        public void Wait()
        {
            Console.WriteLine("\nПока собака ждет, она будет делать что-то случайное или вообще ничего не делать.");
            int wait = rand.Next(1, 5);
            switch (wait)
            {
                case 1: Bark(); break;
                case 2: Run(); break;
                case 3: Play(); break;
                case 4: Console.WriteLine("Она пялиться в стену..."); break;
            }
        }
    }
}
