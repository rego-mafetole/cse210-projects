using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;
    protected string _type;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes() => _minutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {_type} ({_minutes} min): Distance {GetDistance():0.1} km," +
        $" Speed {GetSpeed():0.1} kph, Pace: {GetPace():0.1} min per km";
    }
}