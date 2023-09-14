using System;
namespace Animal{
    class Animal{
        public unsigned int height;
        public unsigned int weight;
        public unsigned int age;
        public bool sex;

        public void move(){
            Console.WriteLine("Animal is moving...");
        }
        public void sleep(){
            Console.WriteLine("Animal is sleeping.");
        }
    }
}