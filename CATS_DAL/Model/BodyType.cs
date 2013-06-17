using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_DAL.Model
{
    [Table("tblBody")]
    public class BodyType
    {
        [Key]
        public int BodyId { get; set; }

        public virtual int VehicleId { get; set; }

        [ForeignKey("VehicleId")]
        public virtual Vehicle Vehicle { get; set; }

        public virtual byte BodyTypeId { get; set; }

        [ForeignKey("BodyTypeId")]
        public virtual BodyTypeValues BodyTypeValues { get; set; }
    }
}
