using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_DAL.Model
{
    [Table("tblVehicles")]
    public class Vehicle
    {
        [Key]
        [Column("VehicleId")]
        public virtual int VehicleId { get; set; }

        [Column("OperatorId")]
        public virtual int OperatorId { get; set; }

        [ForeignKey("OperatorId")]
        public virtual Operator Operator { get; set; }

        [Column("VehicleCount")]
        public int VehicleCount { get; set; }

        [Column("VehicleWeightId")]
        public virtual byte VehicleWeightId { get; set; }

        [ForeignKey("VehicleWeightId")]
        public virtual WeightValues VehicleWeight { get; set; }

        [ForeignKey("VehicleId")]
        public virtual ICollection<BodyType> BodyTypes { get; set; }
    }
}
