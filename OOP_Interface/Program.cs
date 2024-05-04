
using System;
public interface IFirst
{
    void Print();
    void Display();
}

public interface ISecond
{
    void Print();
}

public class Myclass : IFirst, ISecond
{
    public void Display()
        // triển khai từ Interface First
    {
        Console.WriteLine("Display method");
    }

    void IFirst.Print() // sử dụng void để cung cấp triển khai khác nhau cho mỗi interface
    {
        // triển khai từ Interface First
        Console.WriteLine("IFirst's Print method.");
    }

    void ISecond.Print()
        // triển khai từ Interface Srcond
    {
        Console.WriteLine("ISecond's Print method.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // in ra màn hình
        Myclass obj = new Myclass();
        obj.Display();
        IFirst first = obj;
        first.Print();
        ISecond second = obj;
        second.Print();
        Console.ReadLine(); 
    }
}