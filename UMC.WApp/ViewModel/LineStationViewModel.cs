using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMC.WApp.ViewModel
{
    public class LineStationViewModel
    {
        public int Id { set; get; }
        public string NameStation { set; get; }
        public string NameLine { set; get; }
        public int LineId { set; get; }
        public int StationId { set; get; }
    }
}
