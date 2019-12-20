using System;
using System.Collections.Generic;
using System.Text;

namespace MessageAppTestFrame.TestData
{
    public static class LoginCredentials
    {
        public static string ValidEmail = "ellenatalpalaru@gmail.com";
        public static string ValidPassword = "Blackboa1984$";
        public static string InValidEmail = "ellenatalpalaru@gmail.ceva";
        public static string InValidPassword = "ceva";
        public static string EmptyPassword = string.Empty;
        public static string EmptyEmail = string.Empty;
        public static string SQLInjectionEmail = "'or 1 = 1--";
        public static string SQLInjectionPassword = "'or 1 = 1--";
      
        
    }

   
}
