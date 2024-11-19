using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_individ_SA
{
    public class ComputerManager // Определение класса ComputerManager для управления списком компьютеров
    {
        // Список для хранения объектов класса Computer
        private List<Computer> computers = new List<Computer>();

        // Метод для добавления одного компьютера в список
        public void AddComputer(Computer computer)
        {
            // Проверка, что переданный объект не равен null
            if (computer == null)
            {
                throw new ArgumentNullException(nameof(computer), "Компьютер не может быть null."); // Исключение, если объект равен null
            }

            // Проверка на дубликаты по имени процессора перед добавлением
            if (computers.Any(c => c.ProcessorName.Equals(computer.ProcessorName, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("Компьютер с таким процессором уже существует."); // Исключение, если дубликат найден
            }

            computers.Add(computer); // Добавление компьютера в список
        }

        // Перегрузка метода для добавления нескольких компьютеров
        public void AddComputer(IEnumerable<Computer> newComputers)
        {
            // Проверка, что список не равен null
            if (newComputers == null)
            {
                throw new ArgumentNullException(nameof(newComputers), "Список компьютеров не может быть null."); // Исключение, если список равен null
            }

            // Добавление каждого компьютера в список с проверкой на дубликаты
            foreach (var computer in newComputers)
            {
                AddComputer(computer); // Используем метод добавления с проверкой на дубликаты
            }
        }

        // Метод для удаления компьютера из списка по имени процессора
        public bool RemoveComputer(string processorName)
        {
            // Проверка, что имя процессора не пустое и не состоит только из пробелов
            if (string.IsNullOrWhiteSpace(processorName))
            {
                throw new ArgumentException("Имя процессора не может быть пустым.", nameof(processorName)); // Исключение, если имя пустое
            }

            // Поиск компьютера с указанным именем процессора
            var computerToRemove = computers.FirstOrDefault(c =>
                string.Equals(c.ProcessorName, processorName, StringComparison.OrdinalIgnoreCase));

            // Если компьютер найден, удаляем его из списка и возвращаем true
            if (computerToRemove != null)
            {
                computers.Remove(computerToRemove);
                return true;
            }
            return false; // Возвращаем false, если компьютер не найден
        }

        // Метод для получения списка всех компьютеров
        public List<Computer> GetComputers()
        {
            return computers.ToList(); // Возвращаем новый список компьютеров
        }
    }
}
