using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad3_individ_SA
{
    public partial class Form1 : Form
    {
        private ComputerManager computerManager = new ComputerManager(); // Создание экземпляра ComputerManager для управления компьютерами

        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            btnDeleteComputer.Visible = false;
            btnEditComputer.Visible = false;
            btnSaveComputer.Visible = false;
        }


        private void btnAddComputer_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "Добавить компьютер"
        {
            try
            {
                // Проверка на заполнение всех обязательных полей
                if (string.IsNullOrWhiteSpace(txtProcessorName.Text) || // Проверка поля для имени процессора
                    string.IsNullOrWhiteSpace(txtClockSpeed.Text) || // Проверка поля для тактовой частоты
                    string.IsNullOrWhiteSpace(txtMemory.Text) || // Проверка поля для объема оперативной памяти
                    string.IsNullOrWhiteSpace(txtManufacturer.Text) || // Проверка поля для имени производителя
                    string.IsNullOrWhiteSpace(txtYear.Text) || // Проверка поля для года выпуска
                    string.IsNullOrWhiteSpace(txtOS.Text)) // Проверка поля для операционной системы
                {
                    // Если хотя бы одно поле не заполнено, показываем предупреждение
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Выход из метода
                }

                // Валидация тактовой частоты
                if (!int.TryParse(txtClockSpeed.Text, out int clockSpeed) || clockSpeed < 1000 || clockSpeed > 9999)
                    throw new ArgumentException("Тактовая частота должна быть числом от 1000 до 9999 МГц."); // Исключение, если невалидное значение

                // Валидация объема оперативной памяти
                if (!int.TryParse(txtMemory.Text, out int memory) || memory < 1000 || memory > 999999)
                    throw new ArgumentException("Объем оперативной памяти должен быть числом от 1000 до 999999 Мб."); // Исключение, если невалидное значение

                // Валидация объема жесткого диска
                if (!int.TryParse(txtHardDriveSize.Text, out int hardDriveSize) || hardDriveSize < 1 || hardDriveSize > 999999)
                    throw new ArgumentException("Объем жесткого диска должен быть числом от 1 до 999999 Гб."); // Исключение, если невалидное значение

                // Валидация года выпуска
                if (!int.TryParse(txtYear.Text, out int year) || year < 2010 || year > DateTime.Now.Year)
                    throw new ArgumentException("Год выпуска должен быть числом от 2010 до текущего года."); // Исключение, если невалидное значение

                // Валидация имени производителя (только буквы)
                string manufacturer = txtManufacturer.Text; // Получение имени производителя
                if (!Regex.IsMatch(manufacturer, @"^[a-zA-Zа-яА-ЯёЁ\s]+$")) // Проверка, что имя состоит только из букв
                {
                    MessageBox.Show("Имя производителя должно содержать только буквы.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Выход из метода
                }

                // Валидация операционной системы
                string os = txtOS.Text.ToLower(); // Преобразование операционной системы в нижний регистр
                if (os != "windows" && os != "linux") // Проверка допустимых значений
                    throw new ArgumentException("Операционная система должна быть либо 'Windows', либо 'Linux'."); // Исключение, если невалидное значение

                // Валидация времени работы от батареи
                if (!int.TryParse(txtBatteryLife.Text, out int batteryLife) || batteryLife < 1 || batteryLife > 99)
                    throw new ArgumentException("Время работы от батареи должно быть числом от 1 до 99 часов."); // Исключение, если невалидное значение

                // Создание нового объекта Computer с введенными данными
                Computer newComputer = new Computer(
                    txtProcessorName.Text, // Имя процессора
                    double.Parse(txtClockSpeed.Text), // Тактовая частота
                    double.Parse(txtMemory.Text), // Объем оперативной памяти
                    int.Parse(txtHardDriveSize.Text), // Объем жесткого диска
                    txtGraphicsCard.Text, // Название видеокарты
                    txtManufacturer.Text, // Имя производителя
                    int.Parse(txtYear.Text), // Год выпуска
                    txtOS.Text, // Операционная система
                    int.Parse(txtBatteryLife.Text) // Время работы от батареи
                );

                // Добавление нового компьютера в менеджер
                computerManager.AddComputer(newComputer);

                // Обновление списка компьютеров на форме
                UpdateComputerList();

                // Очистка текстовых полей после успешного добавления
                ClearTextBoxes();

                // Показ сообщения об успешном добавлении
                MessageBox.Show("Компьютер успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                // Обработка исключений, связанных с аргументами
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                // Обработка исключений формата
                MessageBox.Show("Пожалуйста, убедитесь, что все числовые поля заполнены корректно.", "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Обработка всех остальных исключений
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteComputer_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "Удалить компьютер"
        {
            // Проверка, выбран ли элемент в ListBox
            if (listBoxComputers.SelectedItem == null) // Если ничего не выбрано
            {
                MessageBox.Show("Пожалуйста, выберите компьютер для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Показать предупреждение
                return; // Выход из метода
            }

            // Получение индекса выбранного элемента
            int selectedIndex = listBoxComputers.SelectedIndex; // Индекс выбранного компьютера в списке

            // Удаление компьютера по индексу
            var computerList = computerManager.GetComputers(); // Получение списка всех компьютеров
            if (selectedIndex >= 0 && selectedIndex < computerList.Count) // Проверка, что индекс в пределах допустимого диапазона
            {
                computerManager.RemoveComputer(computerList[selectedIndex].ProcessorName); // Удаление компьютера по имени процессора
                UpdateComputerList(); // Обновление отображаемого списка компьютеров
                MessageBox.Show("Компьютер успешно удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information); // Показать сообщение об успехе
            }
            else
            {
                MessageBox.Show("Не удалось удалить компьютер. Проверьте, что он существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); // Показать сообщение об ошибке
            }

            // Сброс выделения в ListBox
            listBoxComputers.SelectedIndex = -1; // Удаление выделения элемента в списке
        }

        private void btnEditComputer_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "Редактировать компьютер"
        {
            // Проверка, выбран ли элемент в ListBox
            if (listBoxComputers.SelectedItem == null) // Если ничего не выбрано
            {
                MessageBox.Show("Пожалуйста, выберите компьютер для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Показать предупреждение
                return; // Выход из метода
            }

            // Получение информации о выбранном компьютере
            string selectedComputerInfo = listBoxComputers.SelectedItem.ToString(); // Получение строки с информацией о выбранном компьютере

            // Здесь вам нужно извлечь данные из строки, чтобы заполнить соответствующие текстовые поля
            var computerData = selectedComputerInfo.Split(','); // Разделение строки на массив данных по запятой

            // Заполнение текстовых полей
            txtProcessorName.Text = computerData[0].Split(':')[1].Trim(); // Установка имени процессора
            txtClockSpeed.Text = computerData[1].Split(':')[1].Trim(); // Установка тактовой частоты
            txtMemory.Text = computerData[2].Split(':')[1].Trim(); // Установка объема оперативной памяти
            txtHardDriveSize.Text = computerData[3].Split(':')[1].Trim(); // Установка объема жесткого диска
            txtManufacturer.Text = computerData[5].Split(':')[1].Trim(); // Установка имени производителя
            txtYear.Text = computerData[6].Split(':')[1].Trim(); // Установка года выпуска
            txtGraphicsCard.Text = computerData[4].Split(':')[1].Trim(); // Установка названия видеокарты
            txtOS.Text = computerData[7].Split(':')[1].Trim(); // Установка операционной системы
            txtBatteryLife.Text = computerData[8].Split(':')[1].Trim(); // Установка времени работы от батареи
        }

        private void btnSaveComputer_Click(object sender, EventArgs e) // Обработчик события нажатия кнопки "Сохранить изменения"
        {
            // Проверка, выбран ли элемент в ListBox
            if (listBoxComputers.SelectedItem == null) // Если ничего не выбрано
            {
                MessageBox.Show("Пожалуйста, выберите компьютер для сохранения изменений.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Показать предупреждение
                return; // Выход из метода
            }

            // Получение индекса выбранного элемента
            int selectedIndex = listBoxComputers.SelectedIndex; // Индекс выбранного компьютера в списке

            // Проверка на пустые поля
            var inputFields = new[]
            {
        txtProcessorName.Text, // Имя процессора
        txtClockSpeed.Text, // Тактовая частота
        txtMemory.Text, // Объем оперативной памяти
        txtHardDriveSize.Text, // Объем жесткого диска
        txtManufacturer.Text, // Имя производителя
        txtYear.Text, // Год выпуска
        txtGraphicsCard.Text, // Название видеокарты
        txtOS.Text, // Операционная система
        txtBatteryLife.Text // Время работы от батареи
    };

            // Проверка на наличие пустых полей
            if (inputFields.Any(string.IsNullOrWhiteSpace)) // Если хотя бы одно поле пустое
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Показать предупреждение
                return; // Выход из метода
            }

            // Валидация полей
            if (!int.TryParse(txtClockSpeed.Text, out int clockSpeed) || clockSpeed < 1000 || clockSpeed > 9999 ||
                !int.TryParse(txtMemory.Text, out int memory) || memory < 1000 || memory > 999999 ||
                !int.TryParse(txtHardDriveSize.Text, out int hardDriveSize) || hardDriveSize < 1 || hardDriveSize > 999999 ||
                !int.TryParse(txtYear.Text, out int year) || year < 2010 || year > DateTime.Now.Year ||
                !int.TryParse(txtBatteryLife.Text, out int batteryLife) || batteryLife < 1 || batteryLife > 99)
            {
                MessageBox.Show("Пожалуйста, убедитесь, что все числовые поля заполнены корректно.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Показать предупреждение
                return; // Выход из метода
            }

            // Валидация имени производителя
            string manufacturer = txtManufacturer.Text; // Получаем имя производителя
            if (!Regex.IsMatch(manufacturer, @"^[a-zA-Zа-яА-ЯёЁ\s]+$")) // Проверка, что имя состоит только из букв
            {
                MessageBox.Show("Имя производителя должно содержать только буквы.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Показать предупреждение
                return; // Выход из метода
            }

            // Валидация операционной системы
            string os = txtOS.Text.ToLower(); // Преобразование названия ОС в нижний регистр
            if (os != "windows" && os != "linux") // Проверка на допустимые значения
            {
                MessageBox.Show("Операционная система должна быть либо 'Windows', либо 'Linux'.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Показать предупреждение
                return; // Выход из метода
            }

            // Получение списка компьютеров
            var computerList = computerManager.GetComputers(); // Получение списка всех компьютеров
            string newProcessorName = txtProcessorName.Text; // Сохранение нового имени процессора

            // Получение компьютера из списка по индексу
            var computer = computerManager.GetComputers()[selectedIndex]; // Получение объекта компьютера для редактирования

            // Обновление данных компьютера
            computer.ProcessorName = txtProcessorName.Text; // Обновление имени процессора
            computer.ClockSpeed = clockSpeed; // Обновление тактовой частоты
            computer.Memory = memory; // Обновление объема оперативной памяти
            computer.HardDriveSize = hardDriveSize; // Обновление объема жесткого диска
            computer.GraphicsCard = txtGraphicsCard.Text; // Обновление названия видеокарты
            computer.Manufacturer = manufacturer; // Обновление имени производителя
            computer.YearOfManufacture = year; // Обновление года выпуска
            computer.OperatingSystem = os; // Обновление операционной системы
            computer.BatteryLife = batteryLife; // Обновление времени работы от батареи

            // Обновление списка компьютеров
            UpdateComputerList(); // Обновление отображаемого списка компьютеров

            // Очистка текстовых полей
            ClearTextBoxes(); // Очистка всех текстовых полей для ввода

            // Проверка на дубликат имени процессора
            if (computerList.Any(c => c.ProcessorName.Equals(newProcessorName, StringComparison.OrdinalIgnoreCase) && c != computerList[selectedIndex])) // Если уже есть компьютер с таким именем процессора
            {
                MessageBox.Show("Компьютер с таким именем процессора уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Показать предупреждение
                return; // Выход из метода
            }
            else
            {
                MessageBox.Show("Изменения успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information); // Показать сообщение об успехе
            }

            // Сброс выделения в ListBox
            listBoxComputers.SelectedIndex = -1; // Удаление выделения элемента в списке
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnDeleteComputer.Visible = false;
            btnEditComputer.Visible = false;
            btnSaveComputer.Visible = false;
            btnAddComputer.Visible = true;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            btnDeleteComputer.Visible = true;
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddComputer.Visible = false;
            panel1.Visible = true;
            btnEditComputer.Visible = true;
            btnSaveComputer.Visible = true;
            btnDeleteComputer.Visible = false;
        }
        private void ClearTextBoxes()
        {
            txtProcessorName.Clear();
            txtClockSpeed.Clear();
            txtMemory.Clear();
            txtHardDriveSize.Clear();
            txtManufacturer.Clear();
            txtYear.Clear();
            txtGraphicsCard.Clear();
            txtOS.Clear();
            txtBatteryLife.Clear();
        }
        private void InitializeMenuStrip() // Метод для инициализации MenuStrip
        {
            // Создание MenuStrip
            MenuStrip menuStrip = new MenuStrip(); // Создание нового экземпляра MenuStrip для формы

            // Создание элементов меню
            var addComputerMenuItem = new ToolStripMenuItem("Добавить"); // Элемент меню для добавления компьютера
            var deleteComputerMenuItem = new ToolStripMenuItem("Удалить"); // Элемент меню для удаления компьютера
            var editComputerMenuItem = new ToolStripMenuItem("Редактировать"); // Элемент меню для редактирования компьютера

            // Добавление обработчиков событий
            addComputerMenuItem.Click += btnAddComputer_Click; // Привязка обработчика события нажатия для добавления компьютера
            deleteComputerMenuItem.Click += btnDeleteComputer_Click; // Привязка обработчика события нажатия для удаления компьютера
            editComputerMenuItem.Click += btnEditComputer_Click; // Привязка обработчика события нажатия для редактирования компьютера

            // Добавление элементов в MenuStrip
            menuStrip.Items.AddRange(new ToolStripItem[] { addComputerMenuItem, deleteComputerMenuItem, editComputerMenuItem }); // Добавление всех элементов меню в MenuStrip

            // Добавление MenuStrip на форму
            this.MainMenuStrip = menuStrip; // Установка созданного MenuStrip как основного для формы
            this.Controls.Add(menuStrip); // Добавление MenuStrip в коллекцию элементов управления формы
        }

        private void UpdateComputerList() // Метод для обновления списка компьютеров в ListBox
        {
            listBoxComputers.Items.Clear(); // Очистка текущих элементов в ListBox
            foreach (var computer in computerManager.GetComputers()) // Перебор всех компьютеров из менеджера
            {
                listBoxComputers.Items.Add(computer.DisplayInfo()); // Добавление информации о каждом компьютере в ListBox
            }
        }
    }
}
