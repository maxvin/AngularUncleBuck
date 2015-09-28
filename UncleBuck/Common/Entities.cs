using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UncleBuck.Common;

namespace UncleBuck.Common
{
    using System.ComponentModel.DataAnnotations;

    public enum Titles
    {
        NotSelected,
        Mr,
        Mrs,
        Ms,
        Miss,
        Dr,
        Rev,
        Prof
    }

    public enum MaritalStatuses
    {
        NotSelected,
        Married,
        Single,
        Divorced,
        Widowed,
        LivingTogether,
        Separated,
        Other

    }

    public enum ResidentialStatuses
    {
        NotSelected,
        HomeOwner,
        JointOwner,
        LivingWithParentsFamily,
        PrivateTenant,
        CouncilTenant,
        SocialHousing,
        Other
    }

    public enum IncomeFrequencies
    {
        NotSelected,
        LastWorkingDayofMonth,
        FourWeekly,
        LastMondayOfMonth,
        LastTuesdayOfMonth,
        LastWednesdayOfMonth,
        LastThursdayOfMonth,
        LastFridayOfMonth,
        SpecificDate,
        NotApplicable
    }
    
    public enum CardTypes
    {
        NotSelected = 0,

        MasterCard = 1,

        DebitMasterCard = 20,

        VisaDebit = 22,

        Visa = 2,

        VisaDelta = 3,

        VisaElectron = 4,

        AmericanExpress = 5,

        SwitchMaestro = 6,

        Solo = 7,

        Unknown = 21
    }

    public enum EmploymentStatuses
    {
        NotSelected,
        FullTime,
        PartTime,
		SelfEmployed,
		TemporaryEmployment,
		Student,
		Homemaker,
		OnBenefits,
		OnPension,
		Retired
    }

    public enum EmploymentLengths
    {
        NotSelected,

        NotApplicable,

        LessThan3Months,

        ThreeMonthsTo1Year,

        OneYearTo2Years,

        PwoYearsTo4Years,

        MoreThan4Years
    }

    public enum JobTitles
    {
        Accountant,
		Administration,
		Advertising,
		AgencyWorker,
		AreaManager,
		ArmedForces,
		Baker,
		Barworker,
		BookKeeper,
		BranchManager,
		BrickLayer,
		BusDriver,
		Butcher,
		CabinAttendant,
		CallCenterOperator,
		CareTaker,
		CareWorker,
		Carpenter,
		Chauffer,
		Chef,
		CivilServant,
		Cleaner,
		Clergyman,
		Designer,
		Doctor,
		Draughtsman,
		Driver,
		Electrician,
		EmploymentAgency,
		Engineer,
		EstateAgent,
		FactoryWorker,
		FarmWorker,
		FastFoodAssistant,
		FinanceManager,
		FireService,
        Gardener,
		Hairdresser,
		HealthCare,
		HomeMaker,
		HomeOffice,
		HumanResourceManager,
		ITSpecialist,
		Joiner,
		Labourer,
		Lecturer,
		LegalProfessional,
		Librarian,
		MachineOperator,
		MarketingManager,
		MotorMechanic,
		Nurse,
		NurseryNurse,
		OfficeAssistant,
        PainterDecorator,
		Pilot,
		Plasterer,
		Plumber,
		PoliceForce,
		Postman,
		PublicServiceWorker,
		QuantitySurveyor,
		RecruitmentAgency,
		SalesRep,
		Salesman,
		Secretary,
		SecurityGuard,
		SecurityOfficer,
		SelfEmployed,
		ShopAssistant,
		Sportsman,
		Sportswoman,
		SupermarketWorker,
		Surveyor,
		TaxiDriver,
		Teacher,
		Technician,
		TrainDriver,
		TravelAgent,
		Vet,
		Waiter,
		Waitress,
		ZooKepper
    }

    public enum EmployersIndustries
    {
        NotSelected,

        [Display(Name = "Accountancy, Banking & Finance")]
        AccountancyBankingFinance,

        [Display(Name = "Armed Forces")]
        ArmedForces,

        [Display(Name = "Business, Consulting and Management")]
        BusinessConsultingAndManagement,

        [Display(Name = "Charities and Voluntary Work")]
        CharitiesAndVoluntaryWork,

        [Display(Name = "Creative Art & Culture")]
        CreativeCulture,

        [Display(Name = "Emergency Services")]
        EmergencyServices,

        [Display(Name = "Energy & Utilities")]
        EnergyUtilities,

        [Display(Name = "Engineering & Manufacturing")]
        EngineeringManufacturing,

        [Display(Name = "Environment & Agriculture")]
        EnvironmentAgriculture,

        [Display(Name = "Health & Social Care")]
        HealthSocialCare,

        [Display(Name = "Hospitality, Tourism & Sport")]
        HospitalityTourismSport,

        [Display(Name = "IT  Information Services")]
        ITInformationServices,

        [Display(Name = "Law")]
        Law,

        [Display(Name = "Marketing, Advertising & PR")]
        MarketingAdvertisingPR,

        [Display(Name = "Media & Publishing")]
        MediaPublishing,

        [Display(Name = "Property & Construction,")]
        PropertyConstruction,

        [Display(Name = "Public Sector")]
        PublicSector,

        [Display(Name = "Recruitment & HR")]
        RecruitmentHR,

        [Display(Name = "Retail & Sales")]
        RetailSales,

        [Display(Name = "Science & Pharmaceuticals")]
        SciencePharmaceuticals,

        [Display(Name = "Teaching & Education")]
        TeachingEducation,

        [Display(Name = "Transport & Logistics")]
        TransportLogistics,

    }

    public class PersonalDetails
    {

        public Titles Title { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public MaritalStatuses MaritalStatuses { get; set; }

        public DateTime DateOfBirth { get; set; }

        public byte Dependants { get; set; }
    }

    public class AddressDetails
    {
        public string PostCode { get; set; }

        public string FlatNo { get; set; }

        public string BuildingName { get; set; }

        public string BuildingNo { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        public string Town { get; set; }

        public string Country { get; set; }

        public TimeSpan TimeAtAddress { get; set; }

        public ResidentialStatuses ResidentalStatus { get; set; }

    }

    public class ContactDetails
    {
        public string HomePhone { get; set; }

        public string MobilePhone { get; set; }
    }

    public class Expenses
    {
        public float MonthlyUtilityBillPayments { get; set; }

        public float MonthlyCreditStoreCardPayments { get; set; }

        public float MonthlyTransportCosts { get; set; }

        public float MonthlyFoodCost { get; set; }

        public float MonthlyOtherExpenses { get; set; }

        public float MonthlyRentorMortgage { get; set; }

    }

    public class LoanDetails
    {
        public int LoanRequest { get; set; }

        public IncomeFrequencies IncomeFrequency { get; set; }

        public DateTime NextPayDate { get; set; }

        public DateTime FollowingPayDate { get; set; }

    }

    public class BankDetails
    {
        public string BankName { get; set; }

        public string NameOnAccount { get; set; }

        public long AccountNumber { get; set; }

        public string SortCode { get; set; }

        public bool SalaryDirectlyIntoYourBankAccount { get; set; }

        public bool DebitCardOnTheSameBankAccount { get; set; }

        public CardTypes CardType { get; set; }

    }

    public class EmploymentDetails
    {
        public EmploymentStatuses EmploymentStatus { get; set; }

        public EmploymentLengths EmploymentLength { get; set; }

        public float MonthlyNetSalary { get; set; }

        public string EmployerName { get; set; }

        public JobTitles JobTitle { get; set; }

        public EmployersIndustries EmployersIndustry { get; set; }

        public string Phone { get; set; }

        public string Town { get; set; }
    }

    public class Agreement
    {
        bool AcceptTermsAndPolicy { get; set; }
        
        bool ConsentToReceiveInfo { get; set; }

        bool AllowAlternativeLeadSearch { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public PersonalDetails PersonalDetails { get; set; }

        public AddressDetails AddressDetails { get; set; }

        public ContactDetails ContactDetails { get; set; }

        public Expenses Expenses { get; set; }

        public LoanDetails LoanDetails { get; set; }

        public BankDetails BankDetails { get; set; }

        public EmploymentDetails EmploymentDetails { get; set; }

        public Agreement Agreement { get; set; }
    }
}

