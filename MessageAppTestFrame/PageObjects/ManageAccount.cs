using System;
using System.Collections.Generic;
using System.Text;

namespace MessageAppTestFrame.PageObjects
{
    public static class ManageAccount
    {
        public static string goToMyAccountCss = "body > header > nav > div > div > ul:nth-child(1) > li:nth-child(1) > a";
        public static string personalDataID = "personal-data";
        public static string deleteButtonID = "delete";
        public static string casutadeletePassdID = "Input_Password";
        public static string confDeleteAccButtonCss = "#delete-user > button";

    }
}
