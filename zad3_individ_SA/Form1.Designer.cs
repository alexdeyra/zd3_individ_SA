namespace zad3_individ_SA
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddComputer = new System.Windows.Forms.Button();
            this.listBoxComputers = new System.Windows.Forms.ListBox();
            this.txtProcessorName = new System.Windows.Forms.TextBox();
            this.txtClockSpeed = new System.Windows.Forms.TextBox();
            this.txtMemory = new System.Windows.Forms.TextBox();
            this.txtHardDriveSize = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtGraphicsCard = new System.Windows.Forms.TextBox();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.txtBatteryLife = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteComputer = new System.Windows.Forms.Button();
            this.btnEditComputer = new System.Windows.Forms.Button();
            this.btnSaveComputer = new System.Windows.Forms.Button();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddComputer
            // 
            this.btnAddComputer.BackColor = System.Drawing.Color.Coral;
            this.btnAddComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddComputer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddComputer.Location = new System.Drawing.Point(152, 161);
            this.btnAddComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddComputer.Name = "btnAddComputer";
            this.btnAddComputer.Size = new System.Drawing.Size(145, 48);
            this.btnAddComputer.TabIndex = 0;
            this.btnAddComputer.Text = "Добавить";
            this.btnAddComputer.UseVisualStyleBackColor = false;
            this.btnAddComputer.Click += new System.EventHandler(this.btnAddComputer_Click);
            // 
            // listBoxComputers
            // 
            this.listBoxComputers.FormattingEnabled = true;
            this.listBoxComputers.ItemHeight = 16;
            this.listBoxComputers.Location = new System.Drawing.Point(0, 27);
            this.listBoxComputers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxComputers.Name = "listBoxComputers";
            this.listBoxComputers.Size = new System.Drawing.Size(2025, 180);
            this.listBoxComputers.TabIndex = 1;
            // 
            // txtProcessorName
            // 
            this.txtProcessorName.Location = new System.Drawing.Point(15, 28);
            this.txtProcessorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProcessorName.Name = "txtProcessorName";
            this.txtProcessorName.Size = new System.Drawing.Size(100, 22);
            this.txtProcessorName.TabIndex = 2;
            // 
            // txtClockSpeed
            // 
            this.txtClockSpeed.Location = new System.Drawing.Point(15, 89);
            this.txtClockSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClockSpeed.Name = "txtClockSpeed";
            this.txtClockSpeed.Size = new System.Drawing.Size(100, 22);
            this.txtClockSpeed.TabIndex = 3;
            // 
            // txtMemory
            // 
            this.txtMemory.Location = new System.Drawing.Point(197, 28);
            this.txtMemory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.Size = new System.Drawing.Size(100, 22);
            this.txtMemory.TabIndex = 4;
            // 
            // txtHardDriveSize
            // 
            this.txtHardDriveSize.Location = new System.Drawing.Point(197, 89);
            this.txtHardDriveSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHardDriveSize.Name = "txtHardDriveSize";
            this.txtHardDriveSize.Size = new System.Drawing.Size(100, 22);
            this.txtHardDriveSize.TabIndex = 5;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(371, 28);
            this.txtManufacturer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(100, 22);
            this.txtManufacturer.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(582, 89);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 7;
            // 
            // txtGraphicsCard
            // 
            this.txtGraphicsCard.Location = new System.Drawing.Point(371, 89);
            this.txtGraphicsCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGraphicsCard.Name = "txtGraphicsCard";
            this.txtGraphicsCard.Size = new System.Drawing.Size(100, 22);
            this.txtGraphicsCard.TabIndex = 8;
            // 
            // txtOS
            // 
            this.txtOS.Location = new System.Drawing.Point(586, 28);
            this.txtOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(100, 22);
            this.txtOS.TabIndex = 9;
            // 
            // txtBatteryLife
            // 
            this.txtBatteryLife.Location = new System.Drawing.Point(293, 138);
            this.txtBatteryLife.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBatteryLife.Name = "txtBatteryLife";
            this.txtBatteryLife.Size = new System.Drawing.Size(100, 22);
            this.txtBatteryLife.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название процессора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Частота процессора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(195, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Оперативаная память";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(195, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Объём жёсткого диска";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(368, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Название производителя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(368, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Название видеокарты";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(583, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Название ОС";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(583, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Год выпуска";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(295, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Время работы";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveComputer);
            this.panel1.Controls.Add(this.btnEditComputer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnAddComputer);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtProcessorName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtClockSpeed);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMemory);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtHardDriveSize);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtManufacturer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtYear);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtGraphicsCard);
            this.panel1.Controls.Add(this.txtOS);
            this.panel1.Controls.Add(this.txtBatteryLife);
            this.panel1.Location = new System.Drawing.Point(12, 213);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 212);
            this.panel1.TabIndex = 21;
            // 
            // btnDeleteComputer
            // 
            this.btnDeleteComputer.BackColor = System.Drawing.Color.Coral;
            this.btnDeleteComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteComputer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteComputer.Location = new System.Drawing.Point(787, 222);
            this.btnDeleteComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteComputer.Name = "btnDeleteComputer";
            this.btnDeleteComputer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteComputer.Size = new System.Drawing.Size(115, 41);
            this.btnDeleteComputer.TabIndex = 22;
            this.btnDeleteComputer.Text = "Удалить";
            this.btnDeleteComputer.UseVisualStyleBackColor = false;
            this.btnDeleteComputer.Click += new System.EventHandler(this.btnDeleteComputer_Click);
            // 
            // btnEditComputer
            // 
            this.btnEditComputer.BackColor = System.Drawing.Color.Coral;
            this.btnEditComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditComputer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditComputer.Location = new System.Drawing.Point(303, 161);
            this.btnEditComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditComputer.Name = "btnEditComputer";
            this.btnEditComputer.Size = new System.Drawing.Size(163, 48);
            this.btnEditComputer.TabIndex = 20;
            this.btnEditComputer.Text = "Редактировать";
            this.btnEditComputer.UseVisualStyleBackColor = false;
            this.btnEditComputer.Click += new System.EventHandler(this.btnEditComputer_Click);
            // 
            // btnSaveComputer
            // 
            this.btnSaveComputer.BackColor = System.Drawing.Color.Coral;
            this.btnSaveComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveComputer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveComputer.Location = new System.Drawing.Point(472, 161);
            this.btnSaveComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveComputer.Name = "btnSaveComputer";
            this.btnSaveComputer.Size = new System.Drawing.Size(163, 48);
            this.btnSaveComputer.TabIndex = 21;
            this.btnSaveComputer.Text = "Сохранить";
            this.btnSaveComputer.UseVisualStyleBackColor = false;
            this.btnSaveComputer.Click += new System.EventHandler(this.btnSaveComputer_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1924, 460);
            this.Controls.Add(this.btnDeleteComputer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxComputers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "DNS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddComputer;
        private System.Windows.Forms.ListBox listBoxComputers;
        private System.Windows.Forms.TextBox txtProcessorName;
        private System.Windows.Forms.TextBox txtClockSpeed;
        private System.Windows.Forms.TextBox txtMemory;
        private System.Windows.Forms.TextBox txtHardDriveSize;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtGraphicsCard;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.TextBox txtBatteryLife;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteComputer;
        private System.Windows.Forms.Button btnEditComputer;
        private System.Windows.Forms.Button btnSaveComputer;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
    }
}

