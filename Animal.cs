using System;
namespace Animal{
    class Animal{
        string name;
        int age, height, weight;
        bool sex;
        // get - set
        public string _name{
            get { return name; }
            set { name = value; }
        }
        public int _age{
            get { return age; }
            set { age = value; }
        }
        public int _height{
            get { return height; }
            set { height = value; }
        }
        public int _weight{
            get { return weight; }
            set { weight = value; }
        }
        public bool _sex{
            get { return sex; }
            set { sex = value; }
        }
        // Phương thức khởi tạo
        public Animal(){
            name = "ANIMAL";
            age = height = weight = 0;
            sex = null;
        }
        public Animal(string name, int age, int height, int weight, bool sex){
            this.name = name;
            this.age = age;
            this. height = height;
            this.weight = weight;
            this.sex = sex;
        }
        // Phương thức xử lý
        public void showName(){
            Console.WriteLine($"{name}");
        }
        public void showAge(){
            Console.WriteLine($"{age}");
        }
        public void move(){
            Console.WriteLine("Animal is moving...");
        }
        public void sleep(){
            Console.WriteLine("Animal is sleeping.");
        }
    }
    class Program{
        static void _Main()
        {

        }
    }
}