using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_DAL.Model
{
    [Table("tblRecord_Status_Values")]
    public class RecordStatusValues
    {
        public enum RecordStatuses:byte
        {
            Bronze = 1,
            Silver = 2,
            Gold = 3
        }
        
        [Key]
        [Column("RecordStatusId")]
        public virtual byte RecordStatusId { get; set;}

        [Column("RecordStatus")]
        public string Status { get; set; }
    }
}
