using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FedorenkoKS.Sprint0.Task2.V0.Lib;

namespace Tyuiu.FedorenkoKS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiseTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            //область создания методов тестирования, методов из библиотеки
            var name = "Кирилл";
            var res = DataService.GetMessage(name);

            //вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет, Кирилл", res);
        }
    }
}
