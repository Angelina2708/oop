using System;

//клас банк
public class Bank
{
    public string Name { get; set; }
}

//клас рахунок
public class Account
{
    public string Number { get; set; }
    public int PinCode { get; set; }
    public decimal Balance { get; set; }

    public Account(string number, int pinCode, decimal balance)
    {
        try
        {
            if (balance < 0)
            {
                throw new ZalyshokNaRahunkuException(balance);
            }

            Number = number;
            PinCode = pinCode;
            Balance = balance;
        }
        catch (ZalyshokNaRahunkuException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
}

//клас звичайний рахунок
public class RegularAccount : Account
{
    public RegularAccount(string number, int pinCode, decimal balance)
        : base(number, pinCode, balance)
    {
    }

    public void Withdraw(decimal amount)
    {
        try
        {
            if (amount < 0 || amount > Balance)
            {
                throw new ZnyatyZRahunkuException(amount);
            }

            Balance -= amount;
        }
        catch (ZnyatyZRahunkuException ex)
        {
            Console.WriteLine(ex.Message); //виведення на екран повідомлення про помилку
        }
    }
}

//клас пільговий рахунок
public class PrivilegedAccount : Account
{
    public PrivilegedAccount(string number, int pinCode, decimal balance)
        : base(number, pinCode, balance)
    {
    }

    public void Withdraw(decimal amount)
    {
        try
        {
            if (amount < 0 || amount > Balance)
            {
                throw new ZnyatyZRahunkuException(amount);
            }

            Balance -= amount;
        }
        catch (ZnyatyZRahunkuException ex)
        {
            Console.WriteLine(ex.Message); //виведення на екран повідомлення про помилку
        }
    }
}

//клас банкомат
public class ATM
{
    public int Id { get; set; }
    public string Address { get; set; }
}

//зняти з рахунку
public class ZnyatyZRahunkuException : Exception //Опис власного класу винятків ZnyatyZRahunkuException
{
    public ZnyatyZRahunkuException(decimal amount)
        : base($"Помилка при знятті коштів: некоректна сума {amount}.")
    {
    }
}

//клас залишок на рахунку
public class ZalyshokNaRahunkuException : Exception //Опис власного класу винятків ZalyshokNaRahunkuException
{
    public ZalyshokNaRahunkuException(decimal balance)
        : base($"Неможливо створити рахунок - зазначено некоректне значення залишку на рахунку: {balance}.")
    {
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            var account = new RegularAccount("12345678", 1234, -1000);
        }
        catch (ZalyshokNaRahunkuException)
        {
            // Обробка помилки.
        }

        var regularAccount = new RegularAccount("12345678", 1234, 1000);
        regularAccount.Withdraw(-500);
        regularAccount.Withdraw(2000);

        var privilegedAccount = new PrivilegedAccount("23456789", 5678, 2000);
        privilegedAccount.Withdraw(-500);
        privilegedAccount.Withdraw(3000);
    }
}