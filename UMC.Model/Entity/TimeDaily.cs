using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMC.Model.Entity
{
    public class TimeDaily
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public int Time1 { set; get; }

        public int Time2 { set; get; }

        public int Time3 { set; get; }

        public int Time4 { set; get; }

        public int Time5 { set; get; }

        public int Time6 { set; get; }
    }
}
