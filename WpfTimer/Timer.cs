using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Threading;

namespace WpfTimer
{
    internal class Timer : ITimer
    {
        private DispatcherTimer _timer;
        private TimeSpan _time;

        public EventHandler<TimeSpan> OnTimeChanged;

        public Timer()
        {
            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1),
            };

            _timer.Tick += Timer_Tick;
            _time = TimeSpan.Zero;  
        }

        public void Star()
        { 
            _timer.Start();
        }

        public void Pause()
        { 
            _timer.Stop();
        }
        public void Stop() 
        {
            _timer.Stop();
            _time = TimeSpan.Zero;
            OnTimeChanged?.Invoke(this, _time);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _time = _time.Add(TimeSpan.FromSeconds(1));
            OnTimeChanged?.Invoke(this, _time);
        }
    }
}
