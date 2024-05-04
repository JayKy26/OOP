// Lớp cha Animal
public class Animal
{
    // khai báo các thuộc tính như tên and tiếng sủa
    public string Name { get; set; }

    public virtual void MakeSound()
    {   
        // the hien tính trừu tượng Abstraction
        Console.WriteLine("The animal makes a sound.");
    }
}

// Lớp con Dog
public class Dog : Animal
{
    public override void MakeSound()
    {
        // ghi đè lên MakeSound để cho biết tiến sủa của con chó
        Console.WriteLine("The dog Gau Gau.");
    }
}

// Lớp con Cat
public class Cat : Animal
{
    public override void MakeSound()
    {
        // như trên
        Console.WriteLine("The cat Meo Meo.");
    }
}

// Sử dụng các đối tượng
public class Mains
{
    static void Main(string[] args)
    {
        Animal[] animals = new Animal[]
        {
            new Dog { Name = "Buddy" },
            new Cat { Name = "Whiskers" },
            new Animal { Name = "Unknown" }
            // thêm du lieu name
        };

        foreach (var animal in animals)
        {
            animal.MakeSound();
            // từng đối tượng hiển thị tiếng keu tương ứng
        }
    }
}