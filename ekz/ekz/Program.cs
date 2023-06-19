//Створити інтерфейс Lamp. Він має містити дані про освітлювальний прилад: тип, виробник, потужність у люменах, вид та кількість освітлювальних елементів. Інтерфейс має включати методи для друку на екрані значень цих даних та зміну потужності. 
//Створити інтерфейс Camera. Він має містити дані про фото прилад: тип, виробник, світлочутливість оптичного об'єктиву. Також інтерфейс має включати методи для друку на екрані значень цих даних та зміну світлочутливості. 
//Створити клас PhotoStudio, який буде наслідувати описані вище інтерфейси. 
//Створити мінімум два екземпляри даного класу.
//Вивести на екран усі характеристики фото та світлового обладнання.
//Змінити значення світлочутливості для одного об'єкту і вивести його на екран.


using System;
using System.Text;

// Інтерфейс Lamp
public interface ILamp
{
    string Type { get; set; }
    string Manufacturer { get; set; }
    int Power { get; set; }
    string LightType { get; set; }
    int NumberOfElements { get; set; }

    void Print1();
    void ChangePower(int newPower);
}

// Інтерфейс Camera
public interface ICamera
{
    string Type { get; set; }
    string Manufacturer { get; set; }
    int OpticalSensitivity { get; set; }

    void Print2();
    void ChangeSensitivity(int newSensitivity);
}

// Клас PhotoStudio, що реалізує інтерфейси ILamp та ICamera
public class PhotoStudio : ILamp, ICamera
{
    // Властивості для ILamp
    public string Type { get; set; }
    public string Manufacturer { get; set; }
    public int Power { get; set; }
    public string LightType { get; set; }
    public int NumberOfElements { get; set; }

    // Властивості для ICamera
    public int OpticalSensitivity { get; set; }

    // Методи для ILamp
    public void Print1()
    {
        Console.WriteLine("Lamp: ");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Power: {Power} lumen");
        Console.WriteLine($"Light Type: {LightType}");
        Console.WriteLine($"Number of Elements: {NumberOfElements}");
        Console.WriteLine();
    }

    public void ChangePower(int newPower)
    {
        Power = newPower;
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Console.WriteLine("Потужність змінена успішно!");
    }

    // Методи для ICamera
    public void Print2()
    {
        Console.WriteLine("Camera: ");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Optical Sensitivity: {OpticalSensitivity}");
        Console.WriteLine();
    }

    public void ChangeSensitivity(int newSensitivity)
    {
        OpticalSensitivity = newSensitivity;
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Console.WriteLine("Світлочутливість змінена успішно!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        PhotoStudio studio1 = new PhotoStudio();
        studio1.Type = "Room Lamp";
        studio1.Manufacturer = "Canon";
        studio1.Power = 1750;
        studio1.LightType = "LED";
        studio1.NumberOfElements = 5;

        PhotoStudio studio2 = new PhotoStudio();
        studio2.Type = "Ultra Super camera";
        studio2.Manufacturer = "Canon";
        studio2.OpticalSensitivity = 370;

        studio1.Print1();
        studio2.Print2();

        studio2.ChangeSensitivity(300);

        Console.ReadLine();
    }
}
