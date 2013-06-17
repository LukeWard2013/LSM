using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_DAL.Model
{

    [Table("tblOperators")]
    public class Operator
    {
        [Key]
        [Column("OperatorId")]
        public virtual int OperatorId { get; set; }

        [Column("CO_Company_Name")]
        public string CareOfCompanyName { get; set; }

        [MaxLength(255, ErrorMessage = "Company name must be between 1 and 255 characters."), MinLength(1)]
        [Column("Company_Name")]
        public string CompanyName { get; set; }

        [StringLength(255, ErrorMessage = "Address Line 1 must be between 1 and 255 characters."), MinLength(1)]
        [Column("Address1")]
        public string Address1 { get; set; }

        [Column("Address2")]
        public string Address2 { get; set; }

        [Column("Address3")]
        public string Address3 { get; set; }

        [Column("Address4")]
        public string Address4 { get; set; }

        [Column("Town")]
        public string Town { get; set; }

        [Column("County")]
        public string County { get; set; }

        [Column("Postcode")]
        public string Postcode { get; set; }

        [Column("Telephone_STD")]
        public string TelephoneStd { get; set; }

        [Column("Telephone_Number")]
        public string TelephoneNumber { get; set; }

        [Column("Fax_STD")]
        public string FaxStd { get; set; }

        [Column("Fax_Number")]
        public string FaxNumber { get; set; }

        [Column("Web_Address")]
        public string WebAddress { get; set; }

        [Column("Interviewee_Email")]
        public string IntervieweeEmail { get; set; }

        [Column("Company_Email")]
        public string CompanyEmail { get; set; }

        [Column("PAF_Company_Name")]
        public string PafCompanyName { get; set; }

        [Column("PAF_Address1")]
        public string PafAddress1 { get; set; }

        [Column("PAF_Address2")]
        public string PafAddress2 { get; set; }

        [Column("PAF_Address3")]
        public string PafAddress3 { get; set; }

        [Column("PAF_Address4")]
        public string PafAddress4 { get; set; }

        [Column("PAF_Town")]
        public string PafTown { get; set; }

        [Column("PAF_County")]
        public string PafCounty { get; set; }

        [Column("PAF_Postcode")]
        public string PafPostcode { get; set; }

        [Column("PAF_Telephone_Number")]
        public string PafTelephoneNumber { get; set; }

        [Column("TPS")]
        public bool Tps { get; set; }

        [Column("FPS")]
        public bool Fps { get; set; }

        [Column("Site_Type")]
        public byte? SiteType { get; set; }

        [Column("Truck_Status")]
        public byte TruckStatus { get; set; }

        [Column("Below_7500kg")]
        public bool Below7500Kg { get; set; }

        [Column("OLicense_Expiry")]
        public DateTime? OLicenseExpiry { get; set; }

        [Column("Current_OLicense")]
        public bool CurrentOLicense { get; set; }

        [Column("International_License")]
        public bool InternationalLicense { get; set; }

        public virtual ICollection<CallData> Calls { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }

    }
}
