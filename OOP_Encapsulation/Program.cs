using System;

class Customer
{
    private int Id;
    // dữ liệu bên trong đối tượng cần được ẩn dấu tuân thủ theo Encapsulation
    public int CustomerID
    // dữ liệu ID khách hàng có thể truy cập và thay đổi các giá ID
    {
        get
        {
            return Id;
        }

        set
        {
            Id = value;
        }

    }

    public string CustomerName { get; set; } = "New customer";
    
    public void Print()
    {
        // in ra thông tin khách hàng
        Console.WriteLine($"ID:{CustomerID}, Name:{CustomerName}");

    }
}

class Program
    //truy cập thay đổi thuộc tính r in ra màn hình
{
    static void Main(string[] args)
    {
        //sử dụng thuộc tính public để tương tác với đôi tượng mà không cần phải truy cập trực tiếp vào private bên trong
        Customer obj = new Customer();
        obj.CustomerID = 1000;
        Console.WriteLine($"ID:{obj.CustomerID}, Name:{obj.CustomerName}");
        obj.CustomerID = 2000;
        obj.CustomerName = "Ky";
        obj.Print();
        Console.ReadLine();
    }
}
