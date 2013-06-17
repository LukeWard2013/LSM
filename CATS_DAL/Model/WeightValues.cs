using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_DAL.Model
{
    [Table("dbo.tblVehicle_Weight_Values")]
    public class WeightValues
    {
        public enum Weights:byte
        {
            W7500 = 1,
            W800016000 = 2,
            W18000 = 3,
            W26000 = 4, 
            W32000 = 5, 
            WTractor = 6
        }
        [Key]
        [Column("Vehicle_Weight_ID")]
        public virtual byte VehicleWeightId { get; set; }

        [Column("Vehicle_Weight")]
        public string VehicleWeight { get; set; }
    }
}
