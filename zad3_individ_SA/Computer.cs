using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_individ_SA
{
    public class Computer // Определение класса Computer
    {
        // Поля класса для хранения характеристик компьютера
        public string ProcessorName { get; set; } // Название процессора
        public double ClockSpeed { get; set; } // Тактовая частота в МГц
        public double Memory { get; set; } // Объем оперативной памяти в Мб
        public int HardDriveSize { get; set; } // Объем жесткого диска в Гб
        public string GraphicsCard { get; set; } // Название видеокарты
        public string Manufacturer { get; set; } // Название производителя
        public int YearOfManufacture { get; set; } // Год производства компьютера
        public string OperatingSystem { get; set; } // Операционная система, установленная на компьютере
        public int BatteryLife { get; set; } // Время работы от батареи в часах

        // Конструктор класса Computer
        public Computer(string processorName, double clockSpeed, double memory,
                         int hardDriveSize, string graphicsCard, string manufacturer,
                         int yearOfManufacture, string operatingSystem, int batteryLife)
        {
            // Инициализация полей класса с использованием параметров конструктора
            ProcessorName = processorName; // Установка названия процессора
            ClockSpeed = clockSpeed; // Установка тактовой частоты
            Memory = memory; // Установка объема оперативной памяти
            HardDriveSize = hardDriveSize; // Установка объема жесткого диска
            GraphicsCard = graphicsCard; // Установка названия видеокарты
            Manufacturer = manufacturer; // Установка названия производителя
            YearOfManufacture = yearOfManufacture; // Установка года производства
            OperatingSystem = operatingSystem; // Установка операционной системы
            BatteryLife = batteryLife; // Инициализация времени работы от батареи
        }

        // Функция для определения качества объекта
        public double CalculateQuality()
        {
            // Расчет качества на основе тактовой частоты и объема оперативной памяти
            return (0.3 * ClockSpeed) + Memory; // Формула: Q = (0.3 * ClockSpeed) + Memory
        }

        // Метод для вывода информации об объекте
        public virtual string DisplayInfo()
        {
            // Формирование строки с информацией о компьютере, включая все его характеристики
            return $"Процессор: {ProcessorName}, Тактовая частота: {ClockSpeed} МГц, Оперативная память: {Memory} Мб, " +
                   $"Жесткий диск: {HardDriveSize} Гб, Видеокарта: {GraphicsCard}, Производитель: {Manufacturer}, " +
                   $"Год производства: {YearOfManufacture}, Операционная система: {OperatingSystem}, " +
                   $"Время работы от батареи: {BatteryLife} часов";
        }
    }
}
