using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace BDD_Test_Framework.utility
{
    public class hooks
    {
        private static reusableMethods wrapper = new reusableMethods();
        [Before]
        public void setUp()
        {
            wrapper.loadRepositories();
        }
        [After]
        public void tearDown()
        {
            wrapper.quitBrowser();
        }
    }
}
