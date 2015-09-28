namespace UncleBuck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonalDetails_Title = c.Int(nullable: false),
                        PersonalDetails_FirstName = c.String(),
                        PersonalDetails_MiddleName = c.String(),
                        PersonalDetails_Surname = c.String(),
                        PersonalDetails_Email = c.String(),
                        PersonalDetails_MaritalStatuses = c.Int(nullable: false),
                        PersonalDetails_DateOfBirth = c.DateTime(nullable: false),
                        PersonalDetails_Dependants = c.Byte(nullable: false),
                        AddressDetails_PostCode = c.String(),
                        AddressDetails_FlatNo = c.String(),
                        AddressDetails_BuildingName = c.String(),
                        AddressDetails_BuildingNo = c.String(),
                        AddressDetails_AddressLine1 = c.String(),
                        AddressDetails_AddressLine2 = c.String(),
                        AddressDetails_AddressLine3 = c.String(),
                        AddressDetails_Town = c.String(),
                        AddressDetails_Country = c.String(),
                        AddressDetails_TimeAtAddress = c.Time(nullable: false, precision: 7),
                        AddressDetails_ResidentalStatus = c.Int(nullable: false),
                        ContactDetails_HomePhone = c.String(),
                        ContactDetails_MobilePhone = c.String(),
                        Expenses_MonthlyUtilityBillPayments = c.Single(nullable: false),
                        Expenses_MonthlyCreditStoreCardPayments = c.Single(nullable: false),
                        Expenses_MonthlyTransportCosts = c.Single(nullable: false),
                        Expenses_MonthlyFoodCost = c.Single(nullable: false),
                        Expenses_MonthlyOtherExpenses = c.Single(nullable: false),
                        Expenses_MonthlyRentorMortgage = c.Single(nullable: false),
                        LoanDetails_LoanRequest = c.Int(nullable: false),
                        LoanDetails_IncomeFrequency = c.Int(nullable: false),
                        LoanDetails_NextPayDate = c.DateTime(nullable: false),
                        LoanDetails_FollowingPayDate = c.DateTime(nullable: false),
                        BankDetails_BankName = c.String(),
                        BankDetails_NameOnAccount = c.String(),
                        BankDetails_AccountNumber = c.Long(nullable: false),
                        BankDetails_SortCode = c.String(),
                        BankDetails_SalaryDirectlyIntoYourBankAccount = c.Boolean(nullable: false),
                        BankDetails_DebitCardOnTheSameBankAccount = c.Boolean(nullable: false),
                        BankDetails_CardType = c.Int(nullable: false),
                        EmploymentDetails_EmploymentStatus = c.Int(nullable: false),
                        EmploymentDetails_EmploymentLength = c.Int(nullable: false),
                        EmploymentDetails_MonthlyNetSalary = c.Single(nullable: false),
                        EmploymentDetails_EmployerName = c.String(),
                        EmploymentDetails_JobTitle = c.Int(nullable: false),
                        EmploymentDetails_EmployersIndustry = c.Int(nullable: false),
                        EmploymentDetails_Phone = c.String(),
                        EmploymentDetails_Town = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
