﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using CATS_DAL.Repository;
using CATS_DAL.Model;
using NUnit.Framework;
using Should;

namespace CRUD_Tests
{
    public class Crud
    {
        private List<Operator> _operators;

        [SetUp]
        public void SetUp()
        {
            Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0", @"..\Repository", "");

            using (var context = new CatsDatabaseContext())
            {
                //                Database.SetInitializer<CatsDatabaseContext>(new CatsDbInitialiser());    
                _operators = new List<Operator>
                {
                new Operator {OperatorId=58,CompanyName="DP Tarmacadam & Landscaping",CareOfCompanyName="Care of company name",Address1="4 Rompney Terrace",	Address2="Rumney",	Address3="",	Address4="",	Town="Cardiff",	County="",	Postcode="CF3 3AT",	TelephoneStd="029",	TelephoneNumber="20779298",	FaxStd="029",	FaxNumber="20779298",	WebAddress="",	IntervieweeEmail="",	CompanyEmail="",	PafCompanyName="DP Tarmacadam & Landscaping",	PafAddress1="4 Rompney Terrace",	PafAddress2="Rumney",	PafAddress3="",	PafAddress4="",	PafTown="Cardiff",	PafCounty="",	PafPostcode="CF3 3AT",	PafTelephoneNumber="",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true, OLicenseExpiry=new DateTime(2013, 12, 25), CurrentOLicense=true, InternationalLicense=false},
                new Operator {OperatorId=59,CompanyName="DP Tarmacadam & Landscaping",CareOfCompanyName="Care of company name",Address1="4 Rompney Terrace",	Address2="",	Address3="",	Address4="",	Town="Rumney",	County="South Glamorgan",	Postcode="CF3 8AT",	TelephoneStd="029",	TelephoneNumber="20779298",	FaxStd="029",	FaxNumber="20779298",	WebAddress="",	IntervieweeEmail="",	CompanyEmail="",	PafCompanyName="",	PafAddress1="",	PafAddress2="",	PafAddress3="",	PafAddress4="",	PafTown="",	PafCounty="",	PafPostcode="",	PafTelephoneNumber="",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=63,CompanyName="High Profile Exhibition Ltd",CareOfCompanyName="Care of company name",Address1="Unit 26",	Address2="Woolsbridge Industrial Park",	Address3="Three Legged Cross", Address4="", Town="Wimborne",	County="Dorset",	Postcode="BH21 6SY",	TelephoneStd="01202",	TelephoneNumber="820411",	FaxStd="01202",	FaxNumber="820410",	WebAddress="",	IntervieweeEmail="",	CompanyEmail="highproex@aol.com",	PafCompanyName="",	PafAddress1="",	PafAddress2="",	PafAddress3="",	PafAddress4="",	PafTown="",	PafCounty="",	PafPostcode="",	PafTelephoneNumber="",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=64,CompanyName="D P Fabrications Ltd",CareOfCompanyName="Care of company name",Address1="Chantry Road",	Address2="Woburn Road Industrial Estate",	Address3="Kempston",	Address4="",	Town="Bedford",	County="",	Postcode="MK42 7HU",	TelephoneStd="01234",	TelephoneNumber="840166",	FaxStd="01234",	FaxNumber="840177",	WebAddress="",	IntervieweeEmail="philip@dpfabs.co.uk",	CompanyEmail="sales@dpfab.co.uk",	PafCompanyName="D.P Fabrications Ltd",	PafAddress1="Chantry Road",	PafAddress2="Woburn Road Industrial Estate",	PafAddress3="Kempston",	PafAddress4="",	PafTown="Bedford",	PafCounty="",	PafPostcode="MK42 7HU",	PafTelephoneNumber="01234 840166",	Tps=false,	Fps=false, SiteType=(byte)SiteTypeValues.SiteTypeValue.Branch,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=66,CompanyName="Excel Special Products",CareOfCompanyName="Care of company name",Address1="Rhodia",	Address2="Trinity Street",	Address3="Warley",	Address4="",	Town="Oldbury",	County="West Midlands",	Postcode="B69 4LA",	TelephoneStd="0121",	TelephoneNumber="5411648",	FaxStd="0121",	FaxNumber="5413223",	WebAddress="",	IntervieweeEmail="john.evans@dhl.com",	CompanyEmail="",	PafCompanyName="Excel Special Products",	PafAddress1="Rhodia",	PafAddress2="Trinity Street",	PafAddress3="Warley",	PafAddress4="",	PafTown="Oldbury",	PafCounty="West Midlands",	PafPostcode="B69 4LA",	PafTelephoneNumber="0121 5411648",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=70,CompanyName="Five Star Mechanical Handling",CareOfCompanyName="Care of company name",Address1="East Road",	Address2="Penallta Industrial Estate",	Address3="Hengoed",	Address4="",	Town="Cardiff",	County="Mid Glamorgan",	Postcode="CF8 7QZ",	TelephoneStd="01443",	TelephoneNumber="813453",	FaxStd="01444",	FaxNumber="381 4819",	WebAddress="",	IntervieweeEmail="",	CompanyEmail="office@fivestar.softnet.co.uk",	PafCompanyName="Five Star Mechanical Handling",	PafAddress1="Penallta Industrial Estate",	PafAddress2="",	PafAddress3="",	PafAddress4="",	PafTown="Hengoed",	PafCounty="Mid Glamorgan",	PafPostcode="CF82 7QZ",	PafTelephoneNumber="",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=72,CompanyName="Shaftfield Group Plc",CareOfCompanyName="Care of company name",Address1="8 Ironside Road",	Address2="",	Address3="",Address4 = "",Town="Waterlooville",	County="Hampshire",	Postcode="PO7 7UP",	TelephoneStd="023",	TelephoneNumber="92231188",	FaxStd="023",	FaxNumber="92231124",	WebAddress="n/a",	IntervieweeEmail="",	CompanyEmail="purchase@shaftfield.co.uk",	PafCompanyName="Shatfield",	PafAddress1="Unit 8",	PafAddress2="Arnside Road",	PafAddress3="",	PafAddress4="",	PafTown="Waterlooville",	PafCounty="Hampshire",	PafPostcode="PO7 7UP",	PafTelephoneNumber="023 92231124",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=73,CompanyName="Dorset Ambulance NHS Trust",CareOfCompanyName="Care of company name",Address1="Ambulance Headquarters",	Address2="Ringwood Road",	Address3="St Leonard",	Address4="",	Town="Ringwood",	County="Hampshire",	Postcode="BH24 2SP",	TelephoneStd="01202",	TelephoneNumber="851670",	FaxStd="01202",	FaxNumber="870511",	WebAddress="",	IntervieweeEmail="chief.executive@ms.dorsetamb-tr.swest.nhs.uk",	CompanyEmail="chief.executive@ms.dorsetamb-tr.swest.nhs.uk",	PafCompanyName="Dorset Ambulance N H S Trust",	PafAddress1="241 Ringwood Road",	PafAddress2="St. Leonards",	PafAddress3="",	PafAddress4="",	PafTown="Ringwood",	PafCounty="Hampshire",	PafPostcode="BH24 2SP",	PafTelephoneNumber="",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=74,CompanyName="Beake Cartons",CareOfCompanyName="Care of company name",Address1="Unit D",	Address2="Buchanans Warehouse",	Address3="Chittening Industrial Estate",Address4 = "",Town="Bristol",	County="City & County of Bristol",	Postcode="BS11 0YB",	TelephoneStd="0117",	TelephoneNumber="9381200",	FaxStd="0117",	FaxNumber="9380900",	WebAddress="",	IntervieweeEmail="",	CompanyEmail="",	PafCompanyName="",	PafAddress1="",	PafAddress2="",	PafAddress3="",	PafAddress4="",	PafTown="",	PafCounty="",	PafPostcode="",	PafTelephoneNumber="",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=76,CompanyName="Mid - Devon Haulage",CareOfCompanyName="Care of company name",Address1="Midco Station Road",	Address2="Bow",	Address3="",Address4 = "",Town="Crediton",	County="Devon",	Postcode="EX17 6JD",	TelephoneStd="01363",	TelephoneNumber="82200",	FaxStd="01363",	FaxNumber="82200",	WebAddress="N/A",	IntervieweeEmail="",	CompanyEmail="enquires@mdcoaches.co.uk",	PafCompanyName="",	PafAddress1="Midco",	PafAddress2="Bow",	PafAddress3="",	PafAddress4="",	PafTown="Crediton",	PafCounty="Devon",	PafPostcode="EX17 6JD",	PafTelephoneNumber="",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=3,CompanyName="Cleanaway Ltd",CareOfCompanyName="Care of company name",Address1="25 Coventry Road",	Address2="Bordesley",	Address3="",	Address4="",	Town="Birmingham",	County="West Midlands",	Postcode="B10 0RU",	TelephoneStd="0121",	TelephoneNumber="7725386",	FaxStd="0121",	FaxNumber="779152",	WebAddress="",	IntervieweeEmail="",	CompanyEmail="",	PafCompanyName="",	PafAddress1="",	PafAddress2="",	PafAddress3="",	PafAddress4="",	PafTown="",	PafCounty="",	PafPostcode="",	PafTelephoneNumber="",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=52,CompanyName="Bridgend Office Furniture",CareOfCompanyName="Care of company name",Address1="Tower House",	Address2="Tower Close",	Address3="Bridgend Industrial Estate",	Address4="",	Town="Bridgend",	County="Mid Glamorgan",	Postcode="CF31 3TH",	TelephoneStd="01656",	TelephoneNumber="661061",	FaxStd="01656",	FaxNumber="648346",	WebAddress="",	IntervieweeEmail="",	CompanyEmail="sales@bof.co.uk",	PafCompanyName="Bridgend Office Furniture",	PafAddress1="Tower House",	PafAddress2="Tower Close",	PafAddress3="Bridgend Industrial Estate",	PafAddress4="",	PafTown="Bridgend",	PafCounty="Mid Glamorgan",	PafPostcode="CF31 3TH",	PafTelephoneNumber="",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=51,CompanyName="Cheveley Park Stud Ltd",CareOfCompanyName="Care of company name",Address1="Duchess Drive",	Address2="Cheveley",	Address3="",	Address4="",Town="Newmarket",	County="Suffolk",	Postcode="CB8 9DD",	TelephoneStd="01638",	TelephoneNumber="730316",	FaxStd="01638",	FaxNumber="730868",	WebAddress="www.cheveleypark.co.uk",	IntervieweeEmail="",	CompanyEmail="",	PafCompanyName="Cheveley Park Stud Ltd",	PafAddress1="Cheveley Park Stud",	PafAddress2="Cheveley",	PafAddress3="",	PafAddress4="",	PafTown="Newmarket",	PafCounty="Suffolk",	PafPostcode="CB8 9DD",	PafTelephoneNumber="",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=28,CompanyName="Bath and North East Somerset Community Recycling",	CareOfCompanyName="Care of company name",	Address1="Central Services Department",	Address2="Upper Bristol Road",	Address3="",	Address4="",	Town="Bath",	County="Avon",	Postcode="BA1 3AT",	TelephoneStd="01179",	TelephoneNumber="396010",	FaxStd="01225",	FaxNumber="422612",	WebAddress="",	IntervieweeEmail="",	CompanyEmail="",	PafCompanyName="Bath & Northeast Somerset Community Recycling",	PafAddress1="Upper Bristol Road",	PafAddress2="",	PafAddress3="",	PafAddress4="",	PafTown="Bath",	PafCounty="",	PafPostcode="BA1 3AT",	PafTelephoneNumber="",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=27,CompanyName="Avonmouth Fabrications Ltd",CareOfCompanyName="Care of company name",Address1="Western Contractors Estate",	Address2="Severn Road",	Address3="",Address4="",	Town="Hallen",	County="City & County of Bristol",	Postcode="BS10 7SE",	TelephoneStd="0117",	TelephoneNumber="9823114",	FaxStd="0117",	FaxNumber="9235418",	WebAddress="",	IntervieweeEmail="",	CompanyEmail="avonfabs@eidosnet.co.uk",	PafCompanyName="",	PafAddress1="",	PafAddress2="",	PafAddress3="",	PafAddress4="",	PafTown="",	PafCounty="",	PafPostcode="",	PafTelephoneNumber="",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=24,CompanyName="McIntosh Plant Hire (Aberdeen) Ltd",CareOfCompanyName="Care of company name",Address1="Birchmoss Plant & Storage Depot",	Address2="Echt",Address3="",Address4 = "",	Town="Westhill",	County="Aberdeenshire",	Postcode="AB32 6XL",	TelephoneStd="01330",	TelephoneNumber="860751",	FaxStd="01330",	FaxNumber="860749",	WebAddress="",	IntervieweeEmail="",	CompanyEmail="general@mphltd.co.uk",	PafCompanyName="McIntosh Plant Hire (Aberdeen) Ltd",	PafAddress1="Birchmoss Plant & Storage Depot",	PafAddress2="Echt",	PafAddress3="",	PafAddress4="",	PafTown="Westhill",	PafCounty="Aberdeenshire",	PafPostcode="AB32 6XL",	PafTelephoneNumber="01330 860751",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=19,CompanyName="Speedy Loo Ltd.",CareOfCompanyName="Care of company name",	Address1="Unit 2",Address2="Poly Waste House",	Address3="Princes Road", Address4	= "",Town="London",	County="",	Postcode="N18 3PR",	TelephoneStd= "020",	TelephoneNumber="88842838",	FaxStd="020",	FaxNumber="88070282",	WebAddress="",	IntervieweeEmail="",	CompanyEmail="",	PafCompanyName="",	PafAddress1="",	PafAddress2="",	PafAddress3="",	PafAddress4="",	PafTown="",	PafCounty="",	PafPostcode="",	PafTelephoneNumber="",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=16,CompanyName="Kingfield Cotswold",CareOfCompanyName="Care of company name",Address1="Cotswold House",Address2="St. Philips Road",Address3="",Address4="",Town="Bristol",	County="",	Postcode="BS2 0JZ",	TelephoneStd="0117",	TelephoneNumber="9006000",	FaxStd="0117",	FaxNumber="900 6100",	WebAddress="",	IntervieweeEmail="sbi@kingfieldheath.com",	CompanyEmail="",	PafCompanyName="Kingfield Health Ltd",	PafAddress1="Cotswold House",	PafAddress2="Kingsland Trading Estate",	PafAddress3="St. Philips Road",	PafAddress4="",	PafTown="Bristol",	PafCounty="",	PafPostcode="BS2 0JZ",	PafTelephoneNumber="0117 9006000",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=11,CompanyName="R & J Simpson Ltd.",CareOfCompanyName="Care of company name",	Address1="27 Sinclair Road",Address2="",Address3="",Address4 = "",Town="Aberdeen",County="Aberdeenshire",	Postcode="AB11 9PL",	TelephoneStd="01224",	TelephoneNumber="894043",	FaxStd="01224",	FaxNumber="871 516",	WebAddress="",	IntervieweeEmail="",	CompanyEmail="",	PafCompanyName="R & J Simpson Ltd",	PafAddress1="27 Sinclair Road",	PafAddress2="",	PafAddress3="",	PafAddress4="",	PafTown="Aberdeen",	PafCounty="",	PafPostcode="AB11 9PL",	PafTelephoneNumber="01224 894043",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false},
                new Operator {OperatorId=10,CompanyName="Bardon Aggregates Ltd",CareOfCompanyName="Care of company name",Address1="Pitmedden Road Mill",Address2="",Address3="",Address4="",Town="Dyce",County="Aberdeenshire",	Postcode="AB2 0HA",	TelephoneStd="01224",	TelephoneNumber="722855",	FaxStd="01224",	FaxNumber="771032",	WebAddress="",	IntervieweeEmail="",	CompanyEmail="",	PafCompanyName="",	PafAddress1="",	PafAddress2="",	PafAddress3="",	PafAddress4="",	PafTown="",	PafCounty="",	PafPostcode="",	PafTelephoneNumber="",	Tps=false,	Fps=false,	SiteType=4,	TruckStatus=2,	Below7500Kg=true,	OLicenseExpiry=new DateTime(2013, 12, 25),	CurrentOLicense=true,	InternationalLicense=false}
                };

                _operators.ForEach(o => context.Operators.Add(o));
                context.SaveChanges();
            }
        }

        [Test]
        public void Should_update_call_data_id5_record_status_to_gold()
        {
            var repository = new OperatorRepository();
            var op = repository.FindById(3);
            var call = op.Calls.First(callId => callId.CallDataId == 3);

            call.RecordStatusId = (byte)RecordStatusValues.RecordStatuses.Gold;

            repository.Save(op);

            call.RecordStatusValues.Status.ShouldEqual("Gold");
        }

        [Test]
        public void Should_return_operatorId_of_1_for_next_interview()
        {
            var repository = new OperatorRepository();
            Operator opData = repository.GetValidInterview();
            opData.OperatorId.ShouldEqual(1);
        }

        [Test]
        public void Delete_an_operator_with_primary_key_of_22()
        {
            var repository = new OperatorRepository();

            var op = repository.FindById(10);
            repository.Delete(op);
        }

        [Test]
        public void Should_add_one_vehicle()
        {
            var repo = new OperatorRepository();
            var op = repo.FindById(3);

            op.Vehicles.Add(new Vehicle { VehicleCount = 10, VehicleWeightId = 2 });

            repo.Save(op).ShouldEqual(1);
        }

        [Test]
        public void Should_add_body()
        {
            var repo = new OperatorRepository();
            var op = repo.FindById(3);

            var vehicle = op.Vehicles.First(v => v.VehicleId == 2);
            vehicle.BodyTypes.Add(new BodyType { BodyTypeId = 2 });

            repo.Save(op).ShouldEqual(1);

        }

    }
}
