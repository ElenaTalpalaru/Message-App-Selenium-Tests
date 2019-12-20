using System;
using System.Collections.Generic;
using System.Text;

namespace MessageAppTestFrame.PageObjects
{
    public static class RegistrationPage
    {
        public static string emailBoxID = "Input_Email";
        public static string passwordBoxCSS = "#Input_Password";
        public static string confirmPaswwBoxId = "Input_ConfirmPassword";
        public static string registerButtonID = "registerSubmit";
        public static string confirmAccountLinkCSS = "#confirm-link";
        public static string loginLinkCSS = "body > header > nav > div > div > ul:nth-child(1) > li:nth-child(2) > a";

    }

    public static class AssertIdeRegister
    {
        public static string RegisterConf = "Register confirmation";
        public static string InvalidLoginAttempt = "Invalid login attempt.";
    }
}


