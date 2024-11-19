using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_individ_SA
{
    public class AdvancedComputer : Computer // Класс AdvancedComputer наследует от класса Computer
    {
        // Дополнительное поле для хранения объема винчестера в гигабайтах
        public double HardDriveSize { get; set; } // Объем винчестера в Гб

        // Дополнительные свойства для хранения информации о графической карте и операционной системе
        public string GraphicsCard { get; set; } // Видеокарта
        public string OS { get; set; } // Операционная система
        public double BatteryLife { get; set; } // Время работы от батареи в часах

        // Конструктор класса AdvancedComputer
        public AdvancedComputer(string processorName, double clockSpeed, double memory, double hardDriveSize, string graphicsCard, string manufacturer, int yearOfManufacture, string os, double batteryLife)
            : base(processorName, clockSpeed, memory, (int)hardDriveSize, graphicsCard, manufacturer, yearOfManufacture, os, (int)batteryLife) // Вызов конструктора базового класса Computer
        {
            // Инициализация дополнительных полей
            HardDriveSize = hardDriveSize; // Установка размера жесткого диска
            GraphicsCard = graphicsCard; // Установка названия видеокарты
            OS = os; // Установка операционной системы
            BatteryLife = batteryLife; // Установка времени работы от батареи
        }

        // Метод для расчета качества объекта класса AdvancedComputer
        public double CalculateAdvancedQuality()
        {
            // Расчет качества на основе качества базового класса и размера жесткого диска
            return CalculateQuality() + (0.5 * HardDriveSize); // Qp = Q + 0.5 * P
        }

        // Переопределение метода DisplayInfo для отображения информации о компьютере
        public override string DisplayInfo()
        {
            // Вызываем метод базового класса для получения основной информации и добавляем дополнительную информацию
            return base.DisplayInfo() +
                   $", Объем винчестера: {HardDriveSize} Гб, Видеокарта: {GraphicsCard}, Операционная система: {OS}, Время работы от батареи: {BatteryLife} часов";
        }
    }
}
