using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_DAL.Model
{
    [Table("tblChassis")]
    public class Chassis
    {
        [Key]
        public int ChassisId { get; set; }

        public virtual int VehicleId { get; set; }

        [ForeignKey("VehicleId")]
        public virtual Vehicle Vehicle { get; set; }

        public virtual byte ChassisMakeId { get; set; }

        [ForeignKey("ChassisMakeId")]
        public virtual ChassisMakeValues ChassisMakeValues { get; set; }
    }
}
