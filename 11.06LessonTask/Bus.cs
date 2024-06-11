namespace _11._06LessonTask;

internal class Bus : Vehicle
{
    public int PassengerCount { get; set; }

    public Bus(int year) : base(year)
    {
       
    }
    public override void ShowInfo()
    {
        Console.WriteLine($"Year:{Year}");
    }
}
