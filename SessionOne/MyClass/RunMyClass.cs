namespace ExploringTheNet.SessionOne.MyClass;

public static class RunAnimalClass {
    public static void RunAnimal() {
        Animal dog = new(name: "Golden", age: 0, species: "Nice");
        dog.AnimalDetails(); 
        dog.MakeSound();
    }
}
