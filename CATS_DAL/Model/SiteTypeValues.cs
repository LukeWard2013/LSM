using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_DAL.Model
{
    public class SiteTypeValues
    {
        public enum SiteTypeValue : byte
        {
            HeadOffice=1,
            SingleSite=2,
            Branch=3,
            NotKnown=4,
            Refused=5
        }

        [Key]
        [Column("SiteTypeId")]
        public virtual byte SiteTypeId { get; set; }

        [Column("SiteType")]
        public string SiteType { get; set; }
    }
}
