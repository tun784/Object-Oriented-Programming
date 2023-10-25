using System;

namespace Class_basic{
    class Animal{
        string name, sex;
        int age;
        double height, weight;
        // get - set
        public string name_{
            get { return name; }
            set { name = value; }
        }
        public int age_{
            get { return age; }
            set { age = value; }
        }
        public double height_{
            get { return height; }
            set { height = value; }
        }
        public double weight_{
            get { return weight; }
            set { weight = value; }
        }
        public string sex_{
            get { return sex; }
            set { sex = value; }
        }
        // Phương thức khởi tạo
        public Animal(){
            name = "PET";
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
            this.name = pet.name;
            this.age = pet.age;
            this.height = pet.height;
            this.weight = pet.weight;
            this.sex = pet.sex;
        }
        // Phương thức xử lý
        public void Input(){
            Console.Write("Nhap ten pet: ");
            name = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Nhap chieu cao: ");
            height = double.Parse(Console.ReadLine().Replace('.',','));
            Console.Write("Nhap can nang: ");
            weight = double.Parse(Console.ReadLine().Replace('.',','));
            Console.Write("Nhap gioi tinh: ");
            sex = Console.ReadLine();
        }
        public void Output(){
            Console.WriteLine("Pet Info: ");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: {0:0.00}", height);
            Console.WriteLine("Weight: {0:0.00}", weight);
            Console.WriteLine("Sex: " + sex);
        }
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
}