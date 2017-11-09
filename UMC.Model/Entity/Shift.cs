using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMC.Model.Entity
{
    [Table("Shifts")]
    public class Shift
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        public string Name { set; get; }

        public int StartHour { set; get; }

        public int EndHour { set; get; }

        public int StartMinute { set; get; }

        public int EndMinute { set; get; }
    }
}
