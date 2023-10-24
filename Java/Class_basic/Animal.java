package Class_basic;

import java.util.Scanner;

class Animal {
    private String name;
    private int age;
    private double height, weight;
    private String sex;

    public String getName() {
        return name;
    }

    public void setName(String value) {
        name = value;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int value) {
        age = value;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double value) {
        height = value;
    }

    public double getWeight() {
        return weight;
    }

    public void setWeight(double value) {
        weight = value;
    }

    public String getSex() {
        return sex;
    }

    public void setSex(String value) {
        sex = value;
    }

    public Animal() {
        name = "PET";
        age = 0;
        height = weight = 0.0;
        sex = "Unknown";
    }

    public Animal(String name, int age, double height, double weight, String sex) {
        this.name = name;
        this.age = age;
        this.height = height;
        this.weight = weight;
        this.sex = sex;
    }

    public Animal(Animal pet) {
        this.name = pet.name;
        this.age = pet.age;
        this.height = pet.height;
        this.weight = pet.weight;
        this.sex = pet.sex;
    }

    public void Input() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Nhap ten pet: ");
        name = scanner.nextLine();
        System.out.print("Nhap tuoi: ");
        age = Integer.parseInt(scanner.nextLine());
        System.out.print("Nhap chieu cao: ");
        height = Double.parseDouble(scanner.nextLine().replace(',', '.'));
        System.out.print("Nhap can nang: ");
        weight = Double.parseDouble(scanner.nextLine().replace(',', '.'));
        System.out.print("Nhap gioi tinh: ");
        sex = scanner.nextLine();
    }

    public void Output() {
        System.out.println("Pet Info: ");
        System.out.println("Name: " + name);
        System.out.println("Age: " + age);
        System.out.printf("Height: %.2f%n", height);
        System.out.printf("Weight: %.2f%n", weight);
        System.out.println("Sex: " + sex);
    }

    public String showName() {
        return this.name;
    }

    public int showAge() {
        return this.age;
    }

    public void move() {
        System.out.println("Animal is moving...");
    }

    public void sleep() {
        System.out.println("Animal is sleeping.");
    }
}
