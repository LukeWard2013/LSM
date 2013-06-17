using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace CATS_DAL.Model
{

    [Table("tblCall_Data")]
    public class CallData
    {
        [Key]
        [Column("Call_Data_ID")]
        public int CallDataId { get; set; }

        [Column("OperatorId")]
        public virtual int OperatorId { get; set; }

        [Column("Call_Back_Date")]
        public DateTime CallBackDate { get; set; }

        [Column("Operative")]
        public byte Operative { get; set; }

        [Column("Interview_Start")]
        public DateTime InterviewStart { get; set; }

        [Column("Interview_End")]
        public DateTime InterviewEnd { get; set; }

        [Column("Notes")]
        public string Notes { get; set; }

        [Column("Current_Call")]
        public bool CurrentCall { get; set; }
        
        [Column("RecordStatusId")]
        public virtual byte RecordStatusId { get; set; }

        [ForeignKey("RecordStatusId")]
        public virtual RecordStatusValues RecordStatusValues { get; set; }

        [Column("Reason")]
        public byte Reason { get; set; }

        [ForeignKey("OperatorId")]
        public virtual Operator Operator { get; set; }
    }
}
