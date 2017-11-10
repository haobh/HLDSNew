using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UMC.Model.Entity
{
    [Table("Quantities")]
    public class Quantity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        public DateTime CreatedDate { set; get; }

        public DateTime UpdatedDate { set; get; }

        public string Type { set; get; }

        public float? T1 { set; get; }

        public float? T2 { set; get; }

        public float? T3 { set; get; }

        public float? T4 { set; get; }

        public float? T5 { set; get; }

        public float? T6 { set; get; }

        public float? T7 { set; get; }

        public float? T8 { set; get; }

        public float? T9 { set; get; }

        public float? T10 { set; get; }

        public float? T11 { set; get; }

        public float? T12 { set; get; }

        public string ShiftCode { set; get; }

        [Column(Order = 1)]
        public int LineID { set; get; }

        [Column(Order = 2)]
        public int StationID { set; get; }

        [ForeignKey("StationID")]
        public virtual Station Station { set; get; }

        [ForeignKey("LineID")]
        public virtual Line Line { set; get; }

    }
}
