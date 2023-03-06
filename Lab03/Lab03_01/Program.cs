namespace DerivativeClass
{
    class Building
    { // базовий клас - будинок
        public int floors; // кількість поверхів
        public double area; // площа
    }
    class OfficeBuilding : Building
    { // похідний клас - офісний будинок
        public int numOffices; // кількість офісів
    }
    class LivingBuilding : Building
    { // ще один похідний клас - житловий будинок
        public int numFlats; // кількість квартир
        public int numPeople; // кількість жителів
    }
    class Program
    {
        static void Main()
        {
            Building b = new Building(); // створюємо будинок
            b.area = 1000; // визначаємо площу
            b.floors = 10; // визначаємо кількість поверхів
                           // створюємо офісний будинок
            OfficeBuilding ob = new OfficeBuilding();
            ob.area = 500; // визначаємо площу
            ob.floors = 3; // визначаємо кількість поверхів
            ob.numOffices = 8; // визначаємо кількість офісів
                               // створюємо житловий будинок
            LivingBuilding lb = new LivingBuilding();
            lb.area = 2000; // визначаємо площу
            lb.floors = 5; // визначаємо кількість поверхів
            lb.numFlats = 20; // визначаємо кількість квартир
            lb.numPeople = 75; // визначаємо кількість мешканців
            Console.WriteLine("Будинок : поверхiв {0} площа {1}", b.floors, b.area);
            Console.WriteLine("Офiсний будинок : поверхiв {0} площа {1} офiсiв {2}", ob.floors, ob.area, ob.numOffices);
            Console.WriteLine("Житловий будинок : поверхiв {0} площа {1} квартир {2} мешканцiв {3}", lb.floors, lb.area, lb.numFlats, lb.numPeople);
        }
    }
}
