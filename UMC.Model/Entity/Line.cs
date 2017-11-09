using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMC.Model.Entity
{
    [Table("Lines")]
    public class Line
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public string Name { set; get; }

        public virtual IEnumerable<LineStation> LineStation { set; get; }

        public virtual IEnumerable<Quantity> Quantities { set; get; }

    }
}
