var time = new TitanTime(1000, 40);
Console.WriteLine(time);
time = new TitanTime(30, 70);
Console.WriteLine(time);

class TitanTime
{
    public int _hours = 0, _minutes = 0;

    public override string ToString()
    {
        if (_minutes < 10)
        {
            if (_hours < 10) return "00" + _hours + ":0" + _minutes;
            else if (_hours < 100) return "0" + _hours + ":0" + _minutes;
            return _hours + ":" + _minutes;
        }
        if (_hours < 10) return "00" + _hours + ":" + _minutes;
        else if (_hours < 100) return "0" + _hours + ":" + _minutes;
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
            if (value < 0) _hours = (900 + (value % 900));
            else if (value > 899) _hours = (value % 900);
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
            if (value < 0)
            {
                _hours = _hours + (value / 60);
                if (_hours < 0) _hours += 900;
                _minutes = _minutes + (value % 60);
                if (_minutes < 0)
                {
                    _minutes += 60;
                    _hours -= 1;
                }
            }
            else if (value > 59)
            {
                _hours = _hours + (value / 60);
                if (_hours > 899) _hours -= 900;
                _minutes = (value % 60);
            }
            else _minutes = value;
        }
    }
    public TitanTime(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }
}
