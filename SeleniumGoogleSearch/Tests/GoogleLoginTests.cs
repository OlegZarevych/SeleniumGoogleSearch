using NUnit.Framework;
using SeleniumGoogleSearch.Core;
using SeleniumGoogleSearch.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGoogleSearch.Tests
{
    [TestFixture]
    public class GoogleLoginTests : TestBase
    {
        [Test]
        public void OpenSignUpPage()
        {
            GoogleLoginPage login = Page.GoogleMain.OpenLoginPage();
            GoogleRegisterPage signUp = login.MoreAndSignUp();
            
            ///TODO - problems with clicking
        }
    }
}
