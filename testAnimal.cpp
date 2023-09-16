#include <iostream>
using namespace std;
// Define a class called Animal
class Animal {
  // Declare some private attributes
  private:
    string name;
    int age;
  // Declare some public methods
  public:
    // Constructor that takes name and age as parameters  
    Animal(string n, int a) {
      name = n;
      age = a;
    }
    // Method that returns the name of the animal
    string getName() {
      return name;
    }

    // Method that returns the age of the animalz
    int getAge() {
      return age;
    }

    // Method that prints a greeting from the animal
    void greet() {
      cout << "Hello, I am " << name << " and I am " << age << " years old." << endl;
    }
};

// Main function
int main() {
  // Create an object of class Animal with name "Lion" and age 5
  Animal lion("Lion", 5);

  // Call the greet method on the object
  lion.greet();

  // Print the name and age of the object using the getter methods
  cout << "The name of the animal is " << lion.getName() << endl;
  cout << "The age of the animal is " << lion.getAge() << endl;

  return 0;
}