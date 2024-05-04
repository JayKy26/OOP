public interface ICustomer
{
    string GetName();
    int GetAge();

    // Default Interface Method
    public void PrintInfo()
    {
        Console.WriteLine($"Name: {GetName()}, Age: {GetAge()}");
    }
}

public class IndividualCustomer : ICustomer
{
    private string _name;
    private int _age;

    public string GetName()
    {
        return _name;
    }

    public int GetAge()
    {
        return _age;
    }

    // không cần triển khai lại PrintInfo vì nó được triển khai mặc định sẵn tron Interface
}
