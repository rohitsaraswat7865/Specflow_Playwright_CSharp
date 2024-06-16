using Microsoft.Playwright;

namespace Playwright_BaseFramework.Support
{
    public class PageObject
    {
        //represents tab#1 in browser
        private IPage page;
        public IPage Page
        {
            get
            {
                return this.page;
            }
            set
            {
                this.page ??= value;
            }
        } 
    }
}
