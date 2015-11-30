using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor_V3
{
    class SerialControl
    {
        public delegate void delLogUpdate(Log log);

        Thread serialThread;
        ListBox logBox;

        public int PULSETIME; // seconds for one pulse/log to arrive
        public int timeout;//How long before disconnect in seconds (preferably double that of the clock rate)


        public SerialControl(ListBox logs)
        {
           
        }

        public void setPulseTime(int time)
        {
            this.PULSETIME = time;
            this.timeout = PULSETIME * 4;
        }

    }
}
