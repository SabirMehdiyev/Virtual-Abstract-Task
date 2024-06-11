namespace _11._06LessonTask;

internal abstract class Vehicle
{
    public string Color { get; set; }
    public int Year { get; set; }

    public Vehicle( int year)
    {
        Year = year;
    }

    public abstract void ShowInfo();
}
