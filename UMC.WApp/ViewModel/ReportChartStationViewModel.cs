using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMC.WApp.ViewModel
{
    public class ReportChartStationViewModel
    {
        public int LineId { set; get; }

        public string LineName { set; get; }

        public int StationId { set; get; }

        public string StationName { set; get; }

        public string ShiftCode { set; get; }

        public DateTime CreateDate { set; get; }

        public float? TotalDay { set; get; }

        public float? TotalShiftA { set; get; }

        public float? TotalShiftB { set; get; }
    }
}
