using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UMC.Model.Entity
{
    [Table("LineStations")]
    public class LineStation
    {
        [Key]
        [Column(Order = 1)]
        public int LineId { set; get; }

        [Key]
        [Column(Order = 2)]
        public int StationId { set; get; }

        [ForeignKey("LineId")]
        public virtual Line Line { set; get; }

        [ForeignKey("StationId")]
        public virtual Station Station { set; get; }
    }
}
