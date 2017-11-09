using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMC.WApp.ViewModel
{
    public class ShiftViewModel
    {
        public int ID { set; get; }

        public string Name { set; get; }

        public int StartHour { set; get; }

        public int EndHour { set; get; }

        public int StartMinute { set; get; }

        public int EndMinute { set; get; }
    }
}
