using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTimer
{
    internal interface ITimer
    {
        void Star();
        void Pause();
        void Stop();
    }
}
