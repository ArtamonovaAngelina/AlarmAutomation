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
        public void FindAllElementsOnStartScreen()
        {
            
            var allElements = driver.FindElementsByClassName("TextBlock");
            Console.WriteLine($"\n=== Найдено элементов: {allElements.Count} ===\n");
            
            foreach (var element in allElements)
            {
                try
                {
                    string text = element.Text;
                    if (!string.IsNullOrEmpty(text))
                    {
                        Console.WriteLine($"- {text}");
                    }
                }
                catch { }
            }
        }
        
        [Test]
        public void FindMenuItems()
        {
            try
            {
                var burgerButton = driver.FindElementByAccessibilityId("NavigationToggleButton");
                burgerButton.Click();
            }
            catch
            {
                var burgerButton = driver.FindElementByName("Переключение способа навигации");
                burgerButton.Click();
            }
            
            var allElements = driver.FindElementsByClassName("TextBlock");
            Console.WriteLine($"\n=== Элементы после открытия меню: ===\n");
            
            foreach (var element in allElements)
            {
                try
                {
                    string text = element.Text;
                    if (!string.IsNullOrEmpty(text))
                    {
                        Console.WriteLine($"- {text}");
                    }
                }
                catch { }
            }
        }
    }
}