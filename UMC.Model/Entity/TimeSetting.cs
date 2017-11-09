using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMC.Model.Entity
{
    public class TimeSetting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public int T1 { set; get; }

        public int T2 { set; get; }

        public int T3 { set; get; }

        public int T4 { set; get; }

        public int T5 { set; get; }

        public int T6 { set; get; }

        public int T7 { set; get; }

        public int T8 { set; get; }

        public int T9 { set; get; }

        public int T10 { set; get; }

        public int T11 { set; get; }

        public int T12 { set; get; }
    }
}
