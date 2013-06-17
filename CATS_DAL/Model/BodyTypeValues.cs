using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_DAL.Model
{
    [Table("tblBody_Values")]
    public class BodyTypeValues
    {
        public enum BodyTypes:byte
        {
            Flat = 1,
            Tipper = 2,
            Box = 3,
            Curtainsider = 4,
            Tanker = 5,
            Mixer = 6,
            Fridge = 7,
            Refuse = 8,
            Dropside = 9,
            CarTransporter = 10,
            Tilt = 11,
            Skeletal = 12,
            Standard = 13,
            HighRoof = 14,
            Lowloader = 15,
            Skip = 16,
            RolloNRollOff = 17,
            Bulker = 18,
            Coach = 19,
            Other = 20,
            Luton = 21,
            FireFightingVehicles = 22,
            BeaverTail = 23,
            Panel = 24,
            RecoveryVehicle = 25,
            AnimalTransporter = 26,
            Demount = 27,
            PickUp = 28                  
        }
        [Key]
        public virtual byte BodyTypeId { get; set; }
        public string BodyType { get; set; }
    }
}
