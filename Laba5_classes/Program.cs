class Program
{
    static void Main()
    {
        Dog dog = new Dog { food = "кости", location = "будке", bark = "громко" };
        Cat cat = new Cat { food = "вискас", location = "квартире", meow = "интересно" };
        Horse horse = new Horse { food = "яблочки", location = "амбаре", speed = "быстро" };
        Animal animal = new Animal { food = "ням-нямыч", location = "пентхаус"};

        animal.sleep();

        horse.makeNoise();
        cat.eat();
        dog.makeNoise();

        Vet vet = new Vet();
        vet.treatAnimal(horse);
        vet.treatAnimal(cat);
    }
}


class Animal
{
    public string food { get; set; }
    public string location { get; set; }

    public virtual void makeNoise()
    {
        Console.WriteLine("Издаёт звук");
    }

    public virtual void eat()
    {
        Console.WriteLine("Ест");
    }

    public void sleep()
    {
        Console.WriteLine("Спит");
    }
}

class Dog : Animal
{
    public string bark { get; set; }
    public override void makeNoise()
    {
        Console.WriteLine("Собака лаёт");
    }

    public override void eat()
    {
        Console.WriteLine("Собака ест педигри");
    }
}

class Cat : Animal
{
    public string meow { get; set; }

    public override void makeNoise()
    {
        Console.WriteLine("Кошка мяукает");
    }

    public override void eat()
    {
        Console.WriteLine("Киска любит вискас");
    }
}

class Horse : Animal
{
    public string speed { get; set; }

    public override void makeNoise()
    {
        Console.WriteLine("Лошадь ржёт");
    }

    public override void eat()
    {
        Console.WriteLine("Лошадь кушает яблочки");
    }
}

class Vet
{
    public void treatAnimal(Animal animal)
    {
        Console.WriteLine($"Животное питается: {animal.food}, животное живёт в {animal.location}");
    }
}