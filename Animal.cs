using System;
namespace Animal{
    class Animal{
        string name;
        int age;
        double height, weight;
        string sex;
        // get - set
        public string _name{
            get { return name; }
            set { name = value; }
        }
        public int _age{
            get { return age; }
            set { age = value; }
        }
        public double _height{
            get { return height; }
            set { height = value; }
        }
        public double _weight{
            get { return weight; }
            set { weight = value; }
        }
        public string _sex{
            get { return sex; }
            set { sex = value; }
        }
        // Phương thức khởi tạo
        public Animal(){
            name = "ANIMAL";
            age = 0;
            height = weight = 0.0;
            sex = "Unknown";
        }
        public Animal(string name, int age, double height, double weight, string sex){
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.sex = sex;
        }
        public Animal(Animal pet){
            this.name = pet._name;
            this.age = pet._age;
            this.height = pet.height;
            this.weight = pet._weight;
            this.sex = pet._sex;
        }
        // Phương thức xử lý
        public string showName(){
            return this.name;
        }
        public int showAge(){
            return this.age;
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
            Animal pet01 = new Animal("Lion", 2, 0.9, 48.7, "Female");
            Animal pet02 = new Animal("Tiger", 1, 0.8, 46.4, "Male");
            Console.WriteLine("{0} and {1}", pet01.showName(), pet02.showName());
        }
    }
}