using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using System.Threading;

namespace Trade_Desktop.Tests
{
    [TestClass]
    public class DesktopTests
    {
        public static WindowsDriver<WindowsElement> winDriver;
        public static WindowsElement tb_article, tb_name, tb_price,
            status, btn_insert, btn_delete, btn_update, moveEnd;

        [TestInitialize]
        public void TestInit()
        {
            var desiredCapabilities = new AppiumOptions();

            //Задание пути к тестируемому приложению
            desiredCapabilities.AddAdditionalCapability(
                "app", @"D:\7 семестр\Нестеренко ПИ\Курсовая\CourseWork\Trade_Desktop\bin\Debug\Trade_Desktop.exe");
            //Инициализация билиотеки Апиум ВинАпДрайвер
            //Установка соединения с утилитой ВинАпДрайвер
            //Запуск тестируемого приложения
            winDriver = new WindowsDriver<WindowsElement>(
                new Uri("http://127.0.0.1:4723"), desiredCapabilities);

            //Приостановка на 1 секунду для уверенности,
            //что тестируемое приложение успело запуститься
            Thread.Sleep(1000);

            tb_article = winDriver.FindElementByAccessibilityId("АртикулTB");
            tb_name = winDriver.FindElementByAccessibilityId("НаименованиеTB");
            tb_price = winDriver.FindElementByAccessibilityId("ЦенаTB");
            status = winDriver.FindElementByAccessibilityId("Result");
            btn_insert = winDriver.FindElementByAccessibilityId("ButtonAdd");
            btn_delete = winDriver.FindElementByAccessibilityId("ButtonDelete");
            btn_update = winDriver.FindElementByAccessibilityId("ButtonUpdate");
            moveEnd = winDriver.FindElementByAccessibilityId("Next");            
        }

        [TestCleanup]
        public void TestClean()
        {//По завершению теста, закрыть тестируемое приложение
            winDriver.Quit();
        }

        [TestMethod]
        public void InsertEmptyCommodity()
        {
            btn_insert.Click();
            btn_update.Click();
            Assert.AreEqual("ОШИБКА: Не все данные о товаре не заполнены верно!", status.Text);
        }

        [TestMethod]
        public void InsertWrongCommodity()
        {//Указали только цену и наименование
            btn_insert.Click();
            tb_name.SendKeys("Новый улучшенный товар");
            tb_price.SendKeys("670");
            btn_update.Click();
            Assert.AreEqual("ОШИБКА: Не все данные о товаре не заполнены верно!", status.Text);
        }

        [TestMethod]
        public void InsertCorrectCommodity()
        {
            try
            {
                btn_insert.Click();
                tb_article.SendKeys("999999");
                tb_name.SendKeys("Самый лучший товар, чтобы потом удалить");
                tb_price.SendKeys("670");
                btn_update.Click();
                Assert.AreEqual("Добавление товара прошло успешно", status.Text);
            }
            catch
            {//Если артикул совпадет
                Assert.AreEqual("ОШИБКА: Не все данные о товаре не заполнены верно!", status.Text);
            }
        }

        [TestMethod]
        public void UpdateCurrentCommodityCorrect()
        {
            tb_name.SendKeys("Новый улучшенный товар");
            btn_update.Click();
            Assert.AreEqual("Обновление данных о товаре прошло успешно", status.Text);
        }

        [TestMethod]
        public void UpdateCurrentCommodityIncorrect()
        {
            tb_price.SendKeys("0");
            btn_update.Click();
            Assert.AreEqual("ОШИБКА: Не все данные о товаре не заполнены!", status.Text);
        }

        [TestMethod]
        public void DeleteCurrentCommodityCorrect()
        {
            for (int i = 0; i < 9; i++)
            {
                moveEnd.Click();
            }
            btn_delete.Click();
            Assert.AreEqual("Удаление товара прошло успешно", status.Text);
        }

        [TestMethod]
        public void DeleteCurrentCommodityInCorrect()
        {
            btn_delete.Click();
            Assert.AreEqual("Невозможно удалить элемент, нарушение целостности данных", status.Text);
        }
    }
}
