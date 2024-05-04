// Lớp cơ sở "Vehicle"
public class Vehicle
    // thông tin xe
{
    public string Make { get; set; }
    // hãng
    public string Model { get; set; }
    // loại
    public int Year { get; set; }
    // năm sx

    public void Start()
    {
        Console.WriteLine("The vehicle is starting.");
        // mô tả hoạt động bắt đầu, khởi động phương tiên
    }

    public void Stop()
    {
        Console.WriteLine("The vehicle is stopping.");
        // end phương tiện
    }
}

// Lớp con "Car" kế thừa từ "Vehicle"
public class Car : Vehicle
{
    public int NumDoors { get; set; }

    public void Refuel()
    {
        Console.WriteLine("The car is being refueled.");
    }
    // kế thừa class car và thêm thuộc tính numdoor, phương thức refuel
}

// Lớp con "Motorcycle" kế thừa từ "Vehicle"
public class Motorcycle : Vehicle
{
    public bool HasSideCar { get; set; }

    public void Lean()
    {
        Console.WriteLine("The motorcycle is leaning into the turn.");
    }

    // kế thừa và thêm thuộc tính, phuong thức
}

// Sử dụng các lớp
public class Program
{
    static void Main(string[] args)
    {
        // Tạo đối tượng "Car"
        Car myCar = new Car
        {
            Make = "Toyota",
            Model = "Camry",
            Year = 2020,
            NumDoors = 4
        };
        myCar.Start();
        myCar.Refuel();
        myCar.Stop();

        // Tạo đối tượng "Motorcycle"
        Motorcycle myMotorcycle = new Motorcycle
        {
            Make = "Honda",
            Model = "CBR600RR",
            Year = 2018,
            HasSideCar = false
        };
        myMotorcycle.Start();
        myMotorcycle.Lean();
        myMotorcycle.Stop();
    }
}
