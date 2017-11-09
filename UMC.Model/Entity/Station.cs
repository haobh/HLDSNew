using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UMC.Model.Entity
{
    [Table("Stations")]
    public class Station
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public string Name { set; get; }

        public virtual IEnumerable<LineStation> LineStation { set; get; }

        public virtual IEnumerable<Quantity> Quantities { set; get; }

    }
}
