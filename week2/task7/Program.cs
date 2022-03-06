var signaler = new Signaler();
signaler.AddTime(new JupiterTime(2, 00));
signaler.AddTime(new JupiterTime(4, 00));
signaler.AddTime(new JupiterTime(6, 00));
signaler.Check(new JupiterTime(4, 21));

class JupiterTime
{
    public int _hours = 0, _minutes = 0;

    public override string ToString()
    {
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
            if (value < 0) _hours = (10 + (value % 10));
            else if (value > 9) _hours = (value % 10);
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
                if (_hours < 0) _hours += 10;
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
                if (_hours > 9) _hours -= 10;
                _minutes = (value % 60);
            }
            else _minutes = value;
        }
    }

    public JupiterTime(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }
    public JupiterTime AddHours(int number)
    {
        Hours = _hours + number;
        return new JupiterTime(_hours, _minutes);
    }
    public JupiterTime AddMinutes(int number)
    {
        Minutes = number;
        return new JupiterTime(_hours, _minutes);
    }
}

class Signaler
{
    List<JupiterTime> Timelist = new List<JupiterTime>();

    public void AddTime(JupiterTime time)
    {
        Timelist.Add(time);
    }

    public void Check(JupiterTime time)
    {
        string combinedList = string.Join("-", Timelist);
        int TimelistInt = (combinedList[combinedList.Length - 4]) - '0';

        string combinedTimeList = string.Join("-", time);
        int TimeInt = (combinedTimeList[combinedTimeList.Length - 4]) - '0';

        if (TimelistInt == TimeInt) Console.WriteLine("No signals needed to be sent yet");
        else
        {
            for (int i = TimelistInt + 2; i != TimeInt; i += 2)
            {
                if (i == 10) i = 0;
                Console.WriteLine($"0{i}:00");
            }
        }
    }

}
