using System;

public class Calculator
{
    public int Add(int a, int b) => a + b;

    public int Subtract(int a, int b) => a - b;
    
    public int Multiply(int a, int b) => a * b;
    
    public int Divide(int a, int b) => b == 0 ? throw new DivideByZeroException("Cannot divide by zero") : a / b;

    public bool IsPrime(int number) => number <= 1 ? false : !HasDivisors(number);

    private bool HasDivisors(int number)
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
                return true;
        }
        return false;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Soma: " + calculator.Add(5, 3));
        Console.WriteLine("Subtração: " + calculator.Subtract(5, 3));
        Console.WriteLine("Multiplicação: " + calculator.Multiply(5, 3));
        Console.WriteLine("Divisão: " + calculator.Divide(10, 2));

        Console.WriteLine("Número 7 é primo? " + calculator.IsPrime(7));
        Console.WriteLine("Número 4 é primo? " + calculator.IsPrime(4));

        Console.WriteLine("Digite dois números para somar:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Resultado da soma: {calculator.Add(num1, num2)}");
    }
}
