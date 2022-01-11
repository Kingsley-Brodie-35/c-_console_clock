namespace Count
{
    public class Clock
    {
        //Fields
        private Counter _seconds = new Counter("s");
        private Counter _minutes = new Counter("m");
        private Counter _hours = new Counter("h");
        //Constructor
        public Clock()
        {
        }
        //Properties
        public string Time
        {
            get
            {
                string h = Hours.ToString();
                string m = Minutes.ToString();
                string s = Seconds.ToString();
                if (Hours < 10)
                {
                    h = $"0{Hours}";
                }
                if (Minutes < 10)
                {
                    m = $"0{Minutes}";
                }
                if (Seconds < 10)
                {
                    s = $"0{Seconds}";
                }
                return $"{h}:{m}:{s}";
            }
        }
        public int Hours
        {
            get
            {
                return _hours.Count;
            }
        }
        public int Minutes
        {
            get
            {
                return _minutes.Count;
            }
        }
        public int Seconds
        {
            get
            {
                return _seconds.Count;
            }
        }
        //Methods
        public void Tick()
        {
            _seconds.Increment();
            if (Seconds >= 60 && Minutes < 59)
            {
                _minutes.Increment();
                _seconds.Reset();
            }
            if (Seconds >= 60 && Minutes == 59 && Hours < 24)
            {
                _hours.Increment();
                _seconds.Reset();
                _minutes.Reset();
            }
            if (_hours.Count == 24)
            {
                Reset();
            }
        }
        public void Reset()
        {
            _hours.Reset();
            _minutes.Reset();
            _seconds.Reset();
        }
    }
}
