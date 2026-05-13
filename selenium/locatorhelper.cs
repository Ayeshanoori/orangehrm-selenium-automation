using System;

namespace selenium
{
    public static class locatorhelper
    {

        // =========================
        // LOGIN PAGE
        // =========================

        public const string UserName = "username";

        public const string Password = "password";

        public const string LoginButton = "//button[@type='submit']";

        public const string DashboardText = "//h6[text()='Dashboard']";

        public const string InvalidLoginText =
     "//p[contains(@class,'oxd-alert-content-text')]";



        // =========================
        // SIDEBAR MENUS
        // =========================

        public const string AdminMenu =
            "//span[text()='Admin']";

        public const string PIMMenu =
            "//span[text()='PIM']";

        public const string LeaveMenu =
            "//span[text()='Leave']";

        public const string RecruitmentMenu =
            "//span[text()='Recruitment']";

        public const string MyInfoMenu =
            "//span[text()='My Info']";

        // ADMIN MODULE
        // =========================
        public const string AdminUserNameSearch =
            "//input[@placeholder='Username']";

        // =========================
        // PIM / ADD EMPLOYEE
        // =========================

        public const string AddEmployeeButton =
            "//button[normalize-space()='Add']";

        public const string FirstName = "firstName";

        public const string MiddleName = "middleName";

        public const string LastName = "lastName";

        public const string EmployeeId =
            "//label[text()='Employee Id']/following::input[1]";

        public const string SaveButton =
            "//button[@type='submit']";

        public const string EmployeeSuccessMessage =
            "//p[contains(@class,'toast-message')]";



        // =========================
        // SEARCH EMPLOYEE
        // =========================

        public const string EmployeeSearchName =
            "//input[@placeholder='Type for hints...']";

        public const string EmployeeSearchId =
            "//label[text()='Employee Id']/following::input[1]";

        public const string SearchButton =
            "//button[normalize-space()='Search']";



        // =========================
        // DELETE EMPLOYEE
        // =========================

        public const string DeleteButton =
            "//i[contains(@class,'bi-trash')]";

        public const string ConfirmDeleteButton =
            "//button[normalize-space()='Yes, Delete']";



        // =========================
        // LEAVE MODULE
        // =========================

        public const string ApplyLeaveButton =
            "//a[text()='Apply']";

        public const string FromDate =
            "(//input[@placeholder='yyyy-dd-mm'])[1]";

        public const string ToDate =
            "(//input[@placeholder='yyyy-dd-mm'])[2]";

        public const string LeaveComment =
            "//textarea";

        // LEAVE MODULE KA APPLY BUTTON
        public const string ApplyButton =
            "//button[normalize-space()='Apply']";



        // =========================
        // RECRUITMENT MODULE
        // =========================

        public const string AddCandidateButton =
            "//button[normalize-space()='Add']";

        public const string CandidateFirstName =
            "//input[@name='firstName']";

        public const string CandidateLastName =
            "//input[@name='lastName']";

        public const string CandidateEmail =
            "(//input[@placeholder='Type here'])[1]";

        public const string CandidateContact =
            "(//input[@placeholder='Type here'])[2]";

        public const string CandidateKeywords =
            "//input[@placeholder='Enter comma seperated words...']";



        // =========================
        // MY INFO MODULE
        // =========================

        public const string NickName =
            "//label[text()='Nickname']/following::input[1]";

        public const string SaveMyInfoButton =
            "(//button[@type='submit'])[1]";



        // =========================
        // LOGOUT
        // =========================

        public const string ProfileDropdown =
            "//span[@class='oxd-userdropdown-tab']";

        public const string LogoutButton =
            "//a[text()='Logout']";



        // =========================
        // COMMON SUCCESS MESSAGE
        // =========================

        public const string SuccessMessage =
            "//p[contains(@class,'toast-message')]";

    }
}
