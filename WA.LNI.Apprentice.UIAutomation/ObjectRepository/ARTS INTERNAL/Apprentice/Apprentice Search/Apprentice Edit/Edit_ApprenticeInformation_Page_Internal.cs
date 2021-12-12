﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Threading;
using WA.LNI.Apprentice.TestFramework;

namespace WA.LNI.Apprentice.UIAutomation.ObjectRepository.ARTS_INTERNAL.Apprentice.Apprentice_Search.Apprentice_Edit
{

    public class Edit_ApprenticeInformation_Page_Internal : Base
    {
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Apprentice ID')]//following::div[1]/label")]
        public IWebElement ApprenticeIDListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='First Name']")]
        public IWebElement ApprenticeFirstNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Last Name']")]
        public IWebElement ApprenticeLastNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Middle Name']")]
        public IWebElement ApprenticeMiddleNameInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[@class='ng-tns-c4-180 ui-dropdown-label ui-inputtext ui-corner-all']")]
        public IWebElement EduicationListDrpDwnBtn { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//p-dropdown[@name='EducationLevelCode']//li/span")]
        public List<IWebElement> EduicationListDrpDwnTxt { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Email')]")]
        public IWebElement EmailAddressInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Phone Number')]")]
        public IWebElement PhoneNumberListInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Address1')]")]
        public IWebElement AddressLine1Input { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Address2')]")]
        public IWebElement AddressLine2Input { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'City')]")]
        public IWebElement CityInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'Zip Code')]")]
        public IWebElement ZipInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(@class,'ng-tns-c4-181 ui-dropdown-label ui-inputtext ui-corner-all')]")]
        public IWebElement CityDropDwnBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'col-md-2')]//li/span")]
        public IWebElement CityDropDwnListTxt{ get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@placeholder,'SSN')]")]
        public IWebElement SSNInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Birth Date:')]//following::input[1]")]
        public IWebElement BirthDateInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(@class,'ng-tns-c4-183 ui-dropdown-label ui-inputtext ui-corner-all')]")]
        public IWebElement GenderListBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//p-dropdown[contains(@name,'GenderCode')]//li/span")]
        public List<IWebElement> GenderListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(@class,'ng-tns-c4-184 ui-dropdown-label ui-inputtext ui-corner-all')]")]
        public IWebElement MilitaryStatusListBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//p-dropdown[contains(@name,'militaryStatusList')]//li/span")]
        public List<IWebElement> MilitaryStatusListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(@class,'ui-multiselect-label ui-corner-all')]")]
        public IWebElement RaceListBtn { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'layout-content')]//li/span")]
        public List<IWebElement> RaceListTxt { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[contains(@class,'ng-tns-c4-185 ui-dropdown-label ui-inputtext ui-corner-all')]")]
        public IWebElement HispanicEthnicityListBtn{ get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//p-dropdown[contains(@name,'Hispanic')]//li/span")]
        public List<IWebElement> HispanicEthnicityListTxt { get; set; }

        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Save Apprentice')]")]
        public IList<IWebElement> SaveApprenticeBtn { get; set; }

        /*
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'card card-w-title ui-g-12 ui-fluid ui-md-12 ui-sm-12')]//div[contains(@class,'ui-g')]//div[1]//following::div/div/div[2]/label")]
        public IList<IWebElement> ApprenticeProgramOccupationInformationListTxt { get; set; }
        
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Program Name:')]//following::div[1]/label[1]")]
        public IList<IWebElement> ProgramHistory_NameTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Sub Program:')]//following::div[1]/label[1]")]
        public IList<IWebElement> ProgramHistory_SubProgrmaTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Occupation Name:')]//following::div[1]/label[1]")]
        public IList<IWebElement> ProgramHistory_OccupationTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Employer Name:')]//following::div[1]/label[1]")]
        public IList<IWebElement> ProgramHistory_EmployerTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Current Status:')]//following::div[1]/label[1]")]
        public IList<IWebElement> ProgramHistory_AllStatusTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Registration Date:')]//following::div[1]/label[1]")]
        public IList<IWebElement> ProgramHistory_RegistrationDateTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Probation Start Date:')]//following::div[1]/label[1]")]
        public IList<IWebElement> ProgramHistory_ProbationStartTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Probation End Date:')]//following::div[1]/label[1]")]
        public IList<IWebElement> ProgramHistory_ProbationEndTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Direct Entry:')]//following::div[1]/label[1]")]
        public IList<IWebElement> ProgramHistory_DirectEntryTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Credit For Previous Experience:')]//following::div[1]/label[1]")]
        public IList<IWebElement> ProgramHistory_CreditOJTTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Credit RSI For Previous Experience:')]//following::div[1]/label[1]")]
        public IList<IWebElement> ProgramHistory_CreditRSITxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Final Hours:')]//following::div[1]/label[1]")]
        public IList<IWebElement> ProgramHistory_FinalHoursTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div//app-apprentice-program-occupation//p-panel[1]//div[1]//div[2]//div[1]//div[1]//div[14]//app-apprentice-status[1]//p-panel[1]/div/div[2]/div[1]/div/table/tbody/tr/td[1]")]
        public IList<IWebElement> StatusHistory_StatusTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//div//app-apprentice-program-occupation//p-panel[1]//div[1]//div[2]//div[1]//div[1]//div[14]//app-apprentice-status[1]//p-panel[1]/div/div[2]/div[1]/div/table/tbody/tr/td[2]")]
        public IList<IWebElement> StatusHistory_EffectiveDateTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation/p-panel/div/div/div/div/div[14]/app-apprentice-steps/p-panel/div/div/div/div/table/tbody/tr/td[1]")]
        public IList<IWebElement> StepHistory_StepTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation/p-panel/div/div/div/div/div[14]/app-apprentice-steps/p-panel/div/div/div/div/table/tbody/tr/td[2]")]
        public IList<IWebElement> StepHistory_EffectiveDateTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation/p-panel/div/div/div/div/div[14]/app-apprentice-hours[2]/p-panel/div/div/div/div/table/tbody/tr/td[1]")]
        public IList<IWebElement> RSIUnpaidHistory_YearsTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation/p-panel/div/div/div/div/div[14]/app-apprentice-hours[2]/p-panel/div/div/div/div/table/tbody/tr/td[2]")]
        public IList<IWebElement> RSIUnpaidHistory_QuaterTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation/p-panel/div/div/div/div/div[14]/app-apprentice-hours[2]/p-panel/div/div/div/div/table/tbody/tr/td[3]")]
        public IList<IWebElement> RSIUnpaidHistory_CreatedDateTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation/p-panel/div/div/div/div/div[14]/app-apprentice-hours[2]/p-panel/div/div/div/div/table/tbody/tr/td[4]")]
        public IList<IWebElement> RSIUnpaidHistory_HoursTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation[1]/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[14]/app-apprentice-hours[1]/p-panel[1]/div[1]/div[2]/div[1]/div/table/tbody/tr/td[1]")]
        public IList<IWebElement> RSIPaidHistory_YearsTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation[1]/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[14]/app-apprentice-hours[1]/p-panel[1]/div[1]/div[2]/div[1]/div/table/tbody/tr/td[2]")]
        public IList<IWebElement> RSIPaidHistory_QuaterTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation[1]/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[14]/app-apprentice-hours[1]/p-panel[1]/div[1]/div[2]/div[1]/div/table/tbody/tr/td[3]")]
        public IList<IWebElement> RSIPaidHistory_CreatedDateTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation[1]/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[14]/app-apprentice-hours[1]/p-panel[1]/div[1]/div[2]/div[1]/div/table/tbody/tr/td[4]")]
        public IList<IWebElement> RSIPaidHistory_HoursTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation[1]/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[14]/app-apprentice-hours[3]/p-panel[1]/div/div/div/div/table/tbody/tr/td[1]")]
        public IList<IWebElement> OJTHistory_YearsTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation[1]/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[14]/app-apprentice-hours[3]/p-panel[1]/div/div/div/div/table/tbody/tr/td[2]")]
        public IList<IWebElement> OJTHistory_QuaterTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation[1]/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[14]/app-apprentice-hours[3]/p-panel[1]/div/div/div/div/table/tbody/tr/td[3]")]
        public IList<IWebElement> OJTHistory_CreatedDateTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "//body/app-root/div/div/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation[1]/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[14]/app-apprentice-hours[3]/p-panel[1]/div/div/div/div/table/tbody/tr/td[4]")]
        public IList<IWebElement> OJTHistory_HoursTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[14]/app-apprentice-hours[4]/p-panel[1]/div[1]/div[2]/div[1]/div/table/tbody/tr/td[1]")]
        public IList<IWebElement> AdditionalHoursHistory_YearsTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[14]/app-apprentice-hours[4]/p-panel[1]/div[1]/div[2]/div[1]/div/table/tbody/tr/td[2]")]
        public IList<IWebElement> AdditionalHoursHistory_QuaterTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[14]/app-apprentice-hours[4]/p-panel[1]/div[1]/div[2]/div[1]/div/table/tbody/tr/td[3]")]
        public IList<IWebElement> AdditionalHoursHistory_CreatedDateTxt { get; set; }
        [FindsByAll]
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/app-root[1]/div[1]/div[1]/app-apprentice-search/app-apprentice-search-detail/app-apprentice-detail/div/div/div/app-apprentice-program-occupation/p-panel[1]/div[1]/div[2]/div[1]/div[1]/div[14]/app-apprentice-hours[4]/p-panel[1]/div[1]/div[2]/div[1]/div/table/tbody/tr/td[4]")]
        public IList<IWebElement> AdditionalHoursHistory_HoursTxt { get; set; }
        */
        /// <summary>
        /// Gets the apprentice ID
        /// </summary>
        public string ApprenticeIDList_Txt()
        {
            return Selenium.Driver.GetText(ApprenticeIDListTxt, "ApprenticeIDListTxt");
        }
        /// <summary>
        /// Gets the apprentice Name
        /// </summary>
       /* public string NameList_Txt()
        {
            return Selenium.Driver.GetText(NameListTxt, "NameListTxt");
        }
        /// <summary>
        /// Gets the apprentice Education
        /// </summary>
        public string EduicationList_Txt()
        {
            return Selenium.Driver.GetText(EduicationListTxt, "EduicationListTxt");
        }
        /// <summary>
        /// Gets the apprentice Email ID
        /// </summary>
        public string EmailAddressList_Txt()
        {
            return Selenium.Driver.GetText(EmailAddressListTxt, "EmailAddressListTxt");
        }
        /// <summary>
        /// Gets the apprentice Phone Number
        /// </summary>
        public string PhoneNumberList_Txt()
        {
            return Selenium.Driver.GetText(PhoneNumberListTxt, "PhoneNumberListTxt");
        }
        /// <summary>
        /// Gets the apprentice Address Line 1
        /// </summary>
        public string AddressLine1List_Txt()
        {
            return Selenium.Driver.GetText(AddressLine1ListTxt, "AddressLine1ListTxt");
        }
        /// <summary>
        /// Gets the apprentice Address Line 2
        /// </summary>
        public string AddressLine2List_Txt()
        {
            return Selenium.Driver.GetText(AddressLine2ListTxt, "AddressLine2ListTxt");
        }
        /// <summary>
        /// Gets the apprentice Previous address line 1
        /// </summary>
        public string PreviousAddressLine1List_Txt()
        {
            return Selenium.Driver.GetText(PreviousAddressLine1ListTxt, "PreviousAddressLine1ListTxt");
        }
        /// <summary>
        /// Gets the apprentice Previous Address Line 2
        /// </summary>
        public string PreviousAddressLine2List_Txt()
        {
            return Selenium.Driver.GetText(PreviousAddressLine2ListTxt, "PreviousAddressLine2ListTxt");
        }
        /// <summary>
        /// Gets the apprentice SSN
        /// </summary>
        public string SSNList_Txt()
        {
            return Selenium.Driver.GetText(SSNListTxt, "SSNListTxt");
        }
        /// <summary>
        /// Gets the apprentice Birth Date
        /// </summary>
        public string BirthDateList_Txt()
        {
            return Selenium.Driver.GetText(BirthDateListTxt, "BirthDateListTxt");
        }
        /// <summary>
        /// Gets the apprentice Gender
        /// </summary>
        public string GenderList_Txt()
        {
            return Selenium.Driver.GetText(GenderListTxt, "GenderListTxt");
        }
        /// <summary>
        /// Gets the apprentice Military
        /// </summary>
        public string MilitaryStatusList_Txt()
        {
            return Selenium.Driver.GetText(MilitaryStatusListTxt, "MilitaryStatusListTxt");
        }
        /// <summary>
        /// Gets the apprentice Race
        /// </summary>
        public string RaceList_Txt()
        {
            return Selenium.Driver.GetText(RaceListTxt, "RaceListTxt");
        }
        /// <summary>
        /// Gets the apprentice Hispanic Ethinicity
        /// </summary>
        public string HispanicEthnicityList_Txt()
        {
            return Selenium.Driver.GetText(HispanicEthnicityListTxt, "HispanicEthnicityListTxt");
        }
        /// <summary>
        /// Clicks on apprentice program histories expan '+' button
        /// </summary>
        public void ApprenticeProgramHistoryExpand_Btn(string n)
        {
            Selenium.Driver.Click(ApprenticeProgramHistoryExpandBtn[int.Parse(n)], "ApprenticeProgramHistoryExpandBtn [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Programs History
        /// </summary>
        public string ProgramHistory_Name_Txt(string n)
        {
            return Selenium.Driver.GetText(ProgramHistory_NameTxt[int.Parse(n)], "ProgramHistory_NameTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice Sub Program 
        /// </summary>
        public string ProgramHistory_SubProgrma_Txt(string n)
        {
            return Selenium.Driver.GetText(ProgramHistory_SubProgrmaTxt[int.Parse(n)], "ApprenticeProgramHistoryExpandBtn [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all occupations
        /// </summary>
        public string ProgramHistory_Occupation_Txt(string n)
        {
            return Selenium.Driver.GetText(ProgramHistory_OccupationTxt[int.Parse(n)], "ProgramHistory_OccupationTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Program Employers
        /// </summary>
        public string ProgramHistory_Employer_Txt(string n)
        {
            return Selenium.Driver.GetText(ProgramHistory_EmployerTxt[int.Parse(n)], "ProgramHistory_EmployerTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice All Statuses
        /// </summary>
        public string ProgramHistory_AlltStatus_Txt(string n)
        {
            return Selenium.Driver.GetText(ProgramHistory_AllStatusTxt[int.Parse(n)], "ProgramHistory_AllStatusTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all registrtation dates 
        /// </summary>
        public string ProgramHistory_RegistrationDate_Txt(string n)
        {
            return Selenium.Driver.GetText(ProgramHistory_RegistrationDateTxt[int.Parse(n)], "ProgramHistory_RegistrationDateTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Probation Start Dates
        /// </summary>
        public string ProgramHistory_ProbationStart_Txt(string n)
        {
            return Selenium.Driver.GetText(ProgramHistory_ProbationStartTxt[int.Parse(n)], "ProgramHistory_ProbationStartTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice Probation End Date
        /// </summary>
        public string ProgramHistory_ProbationEnd_Txt(string n)
        {
            return Selenium.Driver.GetText(ProgramHistory_ProbationEndTxt[int.Parse(n)], "ProgramHistory_ProbationEndTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all direct entries
        /// </summary>
        public string ProgramHistory_DirectEntry_Txt(string n)
        {
            return Selenium.Driver.GetText(ProgramHistory_DirectEntryTxt[int.Parse(n)], "ProgramHistory_DirectEntryTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Credited OJT Hours
        /// </summary>
        public string ProgramHistory_CreditOJT_Txt(string n)
        {
            return Selenium.Driver.GetText(ProgramHistory_CreditOJTTxt[int.Parse(n)], "ProgramHistory_CreditOJTTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Credited RSI Hours
        /// </summary>
        public string ProgramHistory_CreditRSI_Txt(string n)
        {
            return Selenium.Driver.GetText(ProgramHistory_CreditRSITxt[int.Parse(n)], "ProgramHistory_CreditRSITxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Final Hours
        /// </summary>
        public string ProgramHistory_FinalHours_Txt(string n)
        {
            return Selenium.Driver.GetText(ProgramHistory_FinalHoursTxt[int.Parse(n)], "ProgramHistory_FinalHoursTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Statuses from history table 
        /// </summary>
        public string StatusHistory_Status_Txt(string n)
        {
            return Selenium.Driver.GetText(StatusHistory_StatusTxt[int.Parse(n)], "StatusHistory_StatusTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all statuses effective date from history table 
        /// </summary>
        public string StatusHistory_EffectiveDate_Txt(string n)
        {
            return Selenium.Driver.GetText(StatusHistory_EffectiveDateTxt[int.Parse(n)], "StatusHistory_EffectiveDateTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all steps from history table
        /// </summary>
        public string StepHistory_Step_Txt(string n)
        {
            return Selenium.Driver.GetText(StepHistory_StepTxt[int.Parse(n)], "StepHistory_StepTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice Probation End Date
        /// </summary>
        public string StepHistory_EffectiveDate_Txt(string n)
        {
            return Selenium.Driver.GetText(StepHistory_EffectiveDateTxt[int.Parse(n)], "StepHistory_EffectiveDateTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all years of reported RSI Unpaid 
        /// </summary>
        public string RSIUnpaidHistory_Years_Txt(string n)
        {
            return Selenium.Driver.GetText(RSIUnpaidHistory_YearsTxt[int.Parse(n)], "RSIUnpaidHistory_YearsTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all quarters of reported RSI Unpaid 
        /// </summary>
        public string RSIUnpaidHistory_Quater_Txt(string n)
        {
            return Selenium.Driver.GetText(RSIUnpaidHistory_QuaterTxt[int.Parse(n)], "RSIUnpaidHistory_QuaterTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all created dates of reported RSI Unpaid 
        /// </summary>
        public string RSIUnpaidHistory_CreatedDate_Txt(string n)
        {
            return Selenium.Driver.GetText(RSIUnpaidHistory_CreatedDateTxt[int.Parse(n)], "RSIUnpaidHistory_CreatedDateTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all hours reported RSI Unpaid 
        /// </summary>
        public string RSIUnpaidHistory_Hours_Txt(string n)
        {
            return Selenium.Driver.GetText(RSIUnpaidHistory_HoursTxt[int.Parse(n)], "RSIUnpaidHistory_HoursTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Years reported RSI Paid 
        /// </summary>
        public string RSIPaidHistory_Years_Txt(string n)
        {
            return Selenium.Driver.GetText(RSIPaidHistory_YearsTxt[int.Parse(n)], "RSIPaidHistory_YearsTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Quaters reported RSI Paid 
        /// </summary>
        public string RSIPaidHistory_Quater_Txt(string n)
        {
            return Selenium.Driver.GetText(RSIPaidHistory_QuaterTxt[int.Parse(n)], "RSIPaidHistory_QuaterTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Created Date reported RSI Paid 
        /// </summary>
        public string RSIPaidHistory_CreatedDate_Txt(string n)
        {
            return Selenium.Driver.GetText(RSIPaidHistory_CreatedDateTxt[int.Parse(n)], "RSIPaidHistory_CreatedDateTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Hours reported RSI Paid  
        /// </summary>
        public string RSIPaidHistory_Hours_Txt(string n)
        {
            return Selenium.Driver.GetText(RSIPaidHistory_HoursTxt[int.Parse(n)], "RSIPaidHistory_HoursTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Years reported OJT 
        /// </summary>
        public string OJTHistory_Years_Txt(string n)
        {
            return Selenium.Driver.GetText(OJTHistory_YearsTxt[int.Parse(n)], "OJTHistory_YearTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Quater reported OJT 
        /// </summary>
        public string OJTHistory_Quater_Txt(string n)
        {
            return Selenium.Driver.GetText(OJTHistory_QuaterTxt[int.Parse(n)], "OJTHistory_QuaterTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Created Date reported OJT 
        /// </summary>
        public string OJTHistory_CreatedDate_Txt(string n)
        {
            return Selenium.Driver.GetText(OJTHistory_CreatedDateTxt[int.Parse(n)], "OJTHistory_CreatedDateTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Hours reported OJT 
        /// </summary>
        public string OJTHistory_Hours_Txt(string n)
        {
            return Selenium.Driver.GetText(OJTHistory_HoursTxt[int.Parse(n)], "OJTHistory_HoursTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Years reported Additional hours
        /// </summary>
        public string AdditionalHoursHistory_Years_Txt(string n)
        {
            return Selenium.Driver.GetText(AdditionalHoursHistory_YearsTxt[int.Parse(n)], "StatusHistory_EffectiveDateTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Quater reported Additional hours
        /// </summary>
        public string AdditionalHoursHistory_Quater_Txt(string n)
        {
            return Selenium.Driver.GetText(AdditionalHoursHistory_QuaterTxt[int.Parse(n)], "OJTHistory_QuaterTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Created Date reported Additional hours 
        /// </summary>
        public string AdditionalHoursHistory_CreatedDate_Txt(string n)
        {
            return Selenium.Driver.GetText(AdditionalHoursHistory_CreatedDateTxt[int.Parse(n)], "OJTHistory_CreatedDateTxt [" + n + "]");
        }
        /// <summary>
        /// Gets the apprentice all Hours reported Additional hours 
        /// </summary>
        public string AdditionalHoursHistory_Hours_Txt(string n)
        {
            return Selenium.Driver.GetText(AdditionalHoursHistory_HoursTxt[int.Parse(n)], "OJTHistory_HoursTxt [" + n + "]");
        }*/
    }
}


    