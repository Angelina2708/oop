//Приклад #6:Event Handling
using System;
delegate void Action(); // First Create а delegate
class AlarmClock
{
    public event Action Alarm; // Public Alarm Event
    public void Start(int count)
    {
        for (int i = 0; i < count; ++i) { } // Delay loop
        if (Alarm != null)
        {
            Alarm();
        }
    }
}
class TestMain
{
    public static void WakeUp()
    {
        Console.WriteLine("Wake Up Now....");
    }
    public static void Main()
    {
        AlarmClock clk = new AlarmClock();
        clk.Alarm += new Action(WakeUp);
        clk.Start(1000000000);
    }
}
