using System;
using System.Collections.Generic;
using System.Text;

namespace MessageAppTestFrame.PageObjects
{
    public static class LoginPage
    {
        public static string EmailTextBoxID = "Input_Email";
        public static string PasswordTextBoxID = "Input_Password";
        public static string LoginButtonID = "login-submit";
        public static string LogOutButtonCCSs = "body > header > nav > div > div > ul:nth-child(1) > li:nth-child(2) > form > button";
        public static string ForgotPasswordButtonID = "forgot-password";

    }

    public static class IdentifierForAssert
    {
        public static string SucceesLogin = "Logout";
        public static string SuccessLogout = "Login";
        public static string InvalidLogin = "Invalid login attempt.";
        public static string EmptyEmail = "The Email field is required.";
        public static string EmptyPassword = "The Password field is required.";
        public static string ForgotPasswPage = "Enter your email.";
        public static string InvalidEmail = "The Email field is not a valid e-mail address.";


    }
}
