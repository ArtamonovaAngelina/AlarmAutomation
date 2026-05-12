using NUnit.Framework;
using AlarmAutomation.Core;

namespace AlarmAutomation.Tests
{
    [TestFixture]
    public class AlarmTests : WinAppDriverBase
    {
        [Test]
        public void OpenAppTest()
        {
            var clockElement = driver.FindElementByName("Часы");
            Assert.IsNotNull(clockElement, "Приложение не открылось");
            Console.WriteLine("Приложение 'Часы' успешно открыто!");
        }
        
        [Test]
        public void CreateAlarmTest()
        {
            var burgerButton = driver.FindElementByAccessibilityId("MenuButton");
            burgerButton.Click();
            System.Threading.Thread.Sleep(1000);
            
            var alarmTab = driver.FindElementByName("Будильник");
            alarmTab.Click();
            System.Threading.Thread.Sleep(1000);
            
            var addButton = driver.FindElementByAccessibilityId("AddAlarmButton");
            addButton.Click();
            System.Threading.Thread.Sleep(1000);
            
            var saveButton = driver.FindElementByAccessibilityId("PrimaryButton");
            saveButton.Click();
            System.Threading.Thread.Sleep(1000);
            
            Console.WriteLine("Будильник создан");
        }
    }
}