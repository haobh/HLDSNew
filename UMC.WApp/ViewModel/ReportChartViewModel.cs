using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMC.WApp.ViewModel
{
    public class ReportChartViewModel
    {
        public int LineId { set; get; }

        public int QuanitiesId { set; get; }

        public int StationId { set; get; }

        public string NameLine { set; get; }

        public string NameStation { set; get; }

        public DateTime CreateDate { set; get; }

        public float? TotalShiftA { set; get; }

        public float? TotalShiftB { set; get; }
    }
}
