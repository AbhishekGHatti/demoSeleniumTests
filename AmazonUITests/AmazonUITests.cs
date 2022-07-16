
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AmazonUITests
{
    public class AmazonUITests
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {

            }

        }
    }
}
