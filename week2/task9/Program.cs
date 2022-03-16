var jupiterTime = new JupiterTime(3, 23);
var titanTime = new TitanTime(1000, 23);
var ganymedeTime = new GanymedeTime(200, 23);

Console.WriteLine(jupiterTime);
Console.WriteLine(titanTime);
Console.WriteLine(ganymedeTime);

public abstract class AlienTime
{
    private int _hours = 0, _minutes = 0, _hoursInDays;

    public override string ToString()
    {
        if (_hours >= _hoursInDays) _hours = _hours % _hoursInDays;
        if (_hoursInDays > 99)
        {
            if (_minutes < 10)
            {
                if (_hours < 10) return "00" + _hours + ":0" + _minutes;
                else if (_hours < 100 && _hoursInDays > 100) return "0" + _hours + ":0" + _minutes;
                return _hours + ":" + _minutes;
            }
            if (_hours < 10) return "00" + _hours + ":" + _minutes;
            else if (_hours < 100 && _hoursInDays > 100) return "0" + _hours + ":" + _minutes;
            return _hours + ":" + _minutes;
        }
        if (_minutes < 10) return _hours + ":0" + _minutes;
        return _hours + ":" + _minutes;
    }


    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            if (value < 0) throw new Exception("WHAT THE HACK!!! Hours should be bigger then 0");
            else _hours = value;
        }
    }
    public int Minutes
    {
        get
        {
            return _minutes;
        }
        set
        {
            if (value < 0) throw new Exception("WHAT THE HACK!!! Minutes should be bigger then 0");
            else if (value > 60)
            {
                _hours = _hours + (value / 60);
                if (_hours > _hoursInDays - 1) _hours = _hours - _hoursInDays;
                _minutes = (value % 60);
            }
            else _minutes = value;
        }
    }
    public AlienTime(int hours, int minutes, int hoursInDay)
    {
        Hours = hours;
        Minutes = minutes;
        _hoursInDays = hoursInDay;
    }
}

class JupiterTime : AlienTime
{
    public JupiterTime(int hours, int minutes)
        : base(hours, minutes, 10)
    { }
}

class TitanTime : AlienTime
{
    public TitanTime(int hours, int minutes)
        : base(hours, minutes, 900)
    { }

}

public class GanymedeTime : AlienTime
{
    public GanymedeTime(int hours, int minutes)
        : base(hours, minutes, 171)
    { }
}