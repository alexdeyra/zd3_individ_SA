using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace zad3_individ_SA
{
    [TestClass] // Указывает, что этот класс содержит тесты
    public class ComputerTests
    {
        [TestMethod] // Тест для проверки расчета качества компьютера
        public void TestCalculateQuality()
        {
            // Arrange: Подготовка данных для теста
            Computer computer = new Computer("Intel i5", 2400, 8, 256, "Integrated", "Dell", 2020, "Windows 10", 5);
            double expectedQuality = (0.3 * 2400) + 8; // Ожидаемое качество, рассчитываемое по формуле

            // Act: Выполнение действия, которое мы тестируем
            double actualQuality = computer.CalculateQuality();

            // Assert: Проверка, что результат соответствует ожиданиям
            Assert.AreEqual(expectedQuality, actualQuality, "Качество компьютера рассчитано неверно.");
        }

        [TestMethod] // Тест для проверки расчета качества продвинутого компьютера
        public void TestAdvancedQuality()
        {
            // Arrange: Подготовка данных для теста
            AdvancedComputer advancedComputer = new AdvancedComputer("Intel i7", 3200, 16, 512, "NVIDIA GTX 1660", "Dell", 2021, "Windows 10", 5);
            double expectedQuality = ((0.3 * 3200) + 16) + (0.5 * 512); // Ожидаемое качество для продвинутого компьютера

            // Act: Выполнение действия, которое мы тестируем
            double actualQuality = advancedComputer.CalculateAdvancedQuality();

            // Assert: Проверка, что результат соответствует ожиданиям
            Assert.AreEqual(expectedQuality, actualQuality, "Качество продвинутого компьютера рассчитано неверно.");
        }

        [TestMethod] // Тест для проверки добавления компьютера в менеджер
        public void TestAddComputer()
        {
            // Arrange: Подготовка данных для теста
            ComputerManager manager = new ComputerManager();
            Computer computer = new Computer("Intel i5", 2400, 8, 256, "Integrated", "Dell", 2020, "Windows 10", 5);

            // Act: Добавление компьютера в менеджер
            manager.AddComputer(computer);
            var computers = manager.GetComputers(); // Получение списка компьютеров

            // Assert: Проверка, что компьютер был добавлен
            Assert.AreEqual(1, computers.Count, "Компьютер не был добавлен.");
            Assert.AreEqual(computer.ProcessorName, computers[0].ProcessorName, "Добавленный компьютер не совпадает.");
        }

        [TestMethod] // Тест для проверки добавления дубликата компьютера
        public void TestAddDuplicateComputer()
        {
            // Arrange: Подготовка данных для теста
            ComputerManager manager = new ComputerManager();
            Computer computer1 = new Computer("Intel i5", 2400, 8, 256, "Integrated", "Dell", 2020, "Windows 10", 5);
            Computer computer2 = new Computer("Intel i5", 2600, 16, 512, "Integrated", "HP", 2021, "Windows 10", 6);

            // Act: Добавление первого компьютера
            manager.AddComputer(computer1);

            // Assert: Проверка, что добавление дубликата вызывает исключение
            var exception = Assert.ThrowsException<InvalidOperationException>(() => manager.AddComputer(computer2));
            Assert.AreEqual("Компьютер с таким процессором уже существует.", exception.Message);
        }

        [TestMethod] // Тест для проверки удаления компьютера
        public void TestRemoveComputer()
        {
            // Arrange: Подготовка данных для теста
            ComputerManager manager = new ComputerManager();
            Computer computer = new Computer("Intel i5", 2400, 8, 256, "Integrated", "Dell", 2020, "Windows 10", 5);
            manager.AddComputer(computer); // Добавление компьютера

            // Act: Удаление компьютера
            bool isRemoved = manager.RemoveComputer("Intel i5");

            // Assert: Проверка, что компьютер был удален
            Assert.IsTrue(isRemoved, "Компьютер не был удален.");
            Assert.AreEqual(0, manager.GetComputers().Count, "Список компьютеров не пуст.");
        }

        [TestMethod] // Тест для проверки удаления несуществующего компьютера
        public void TestRemoveNonExistentComputer()
        {
            // Arrange: Подготовка данных для теста
            ComputerManager manager = new ComputerManager();
            Computer computer = new Computer("Intel i5", 2400, 8, 256, "Integrated", "Dell", 2020, "Windows 10", 5);
            manager.AddComputer(computer); // Добавление компьютера

            // Act: Попытка удалить несуществующий компьютер
            bool isRemoved = manager.RemoveComputer("Intel i7");

            // Assert: Проверка, что удаление несуществующего компьютера возвращает false
            Assert.IsFalse(isRemoved, "Удаление несуществующего компьютера должно вернуть false.");
            Assert.AreEqual(1, manager.GetComputers().Count, "Список компьютеров должен содержать один элемент.");
        }
    }
}
