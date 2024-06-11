namespace _11._06LessonTask;

internal class Program
{
    static void Main(string[] args)
    {
        Car car = new Car(2024,"Mercedes","Maybach");
        Bus bus = new Bus(2023);

        Vehicle[] vehicles = {car,bus};
        foreach (var item in vehicles)
        {
            item.ShowInfo();
        }
    }
}
