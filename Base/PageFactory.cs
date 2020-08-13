using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumFramework.Base
{
    public class PageFactory
    {
        private static Lazy<PageFactory> instance = new Lazy<PageFactory>(() => new PageFactory());

        public static PageFactory Instance
        {
            get
            {
                return instance.Value;
            }
        }

        private PageFactory()
        {

        }

        public BasePage CurrentPage = new BasePage();
    }
}
