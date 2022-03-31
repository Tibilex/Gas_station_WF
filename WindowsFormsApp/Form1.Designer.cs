namespace WindowsFormsApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FuelGroupBox = new System.Windows.Forms.GroupBox();
            this.labelLiters = new System.Windows.Forms.Label();
            this.labelGrn2 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxLiters = new System.Windows.Forms.TextBox();
            this.labelGrn1 = new System.Windows.Forms.Label();
            this.textBoxFuelPrice = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.groupBoxChoise = new System.Windows.Forms.GroupBox();
            this.radioButtonSum = new System.Windows.Forms.RadioButton();
            this.radioButtonCount = new System.Windows.Forms.RadioButton();
            this.groupBoxSum1 = new System.Windows.Forms.GroupBox();
            this.labelGrn3 = new System.Windows.Forms.Label();
            this.labelFuelSum = new System.Windows.Forms.Label();
            this.CafeGroupBox = new System.Windows.Forms.GroupBox();
            this.labelCafeCount = new System.Windows.Forms.Label();
            this.labelCafePrice = new System.Windows.Forms.Label();
            this.textBoxColaCount = new System.Windows.Forms.TextBox();
            this.textBoxFriCount = new System.Windows.Forms.TextBox();
            this.textBoxBurgerCount = new System.Windows.Forms.TextBox();
            this.textBoxHotCount = new System.Windows.Forms.TextBox();
            this.textBoxColaPrice = new System.Windows.Forms.TextBox();
            this.textBoxFriPrice = new System.Windows.Forms.TextBox();
            this.textBoxBurgerPrice = new System.Windows.Forms.TextBox();
            this.textBoxHotPrice = new System.Windows.Forms.TextBox();
            this.checkBoxCola = new System.Windows.Forms.CheckBox();
            this.checkBoxFri = new System.Windows.Forms.CheckBox();
            this.checkBoxBurger = new System.Windows.Forms.CheckBox();
            this.checkBoxHotDog = new System.Windows.Forms.CheckBox();
            this.groupBoxSum2 = new System.Windows.Forms.GroupBox();
            this.labelGrn4 = new System.Windows.Forms.Label();
            this.labelCafeSum = new System.Windows.Forms.Label();
            this.groupBoxTotalSum = new System.Windows.Forms.GroupBox();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.checkBoxAllMode = new System.Windows.Forms.CheckBox();
            this.checkBoxCafeMode = new System.Windows.Forms.CheckBox();
            this.checkBoxFuelMode = new System.Windows.Forms.CheckBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelGrn5 = new System.Windows.Forms.Label();
            this.labelTotalSum = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FuelGroupBox.SuspendLayout();
            this.groupBoxChoise.SuspendLayout();
            this.groupBoxSum1.SuspendLayout();
            this.CafeGroupBox.SuspendLayout();
            this.groupBoxSum2.SuspendLayout();
            this.groupBoxTotalSum.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FuelGroupBox
            // 
            this.FuelGroupBox.Controls.Add(this.labelLiters);
            this.FuelGroupBox.Controls.Add(this.labelGrn2);
            this.FuelGroupBox.Controls.Add(this.textBoxSum);
            this.FuelGroupBox.Controls.Add(this.textBoxLiters);
            this.FuelGroupBox.Controls.Add(this.labelGrn1);
            this.FuelGroupBox.Controls.Add(this.textBoxFuelPrice);
            this.FuelGroupBox.Controls.Add(this.comboBox1);
            this.FuelGroupBox.Controls.Add(this.labelPrice);
            this.FuelGroupBox.Controls.Add(this.labelFuel);
            this.FuelGroupBox.Controls.Add(this.groupBoxChoise);
            this.FuelGroupBox.Controls.Add(this.groupBoxSum1);
            this.FuelGroupBox.Location = new System.Drawing.Point(12, 12);
            this.FuelGroupBox.Name = "FuelGroupBox";
            this.FuelGroupBox.Size = new System.Drawing.Size(250, 280);
            this.FuelGroupBox.TabIndex = 0;
            this.FuelGroupBox.TabStop = false;
            this.FuelGroupBox.Text = "Автозаправка";
            // 
            // labelLiters
            // 
            this.labelLiters.AutoSize = true;
            this.labelLiters.Location = new System.Drawing.Point(199, 120);
            this.labelLiters.Name = "labelLiters";
            this.labelLiters.Size = new System.Drawing.Size(35, 13);
            this.labelLiters.TabIndex = 11;
            this.labelLiters.Text = "Литр.";
            // 
            // labelGrn2
            // 
            this.labelGrn2.AutoSize = true;
            this.labelGrn2.Location = new System.Drawing.Point(199, 149);
            this.labelGrn2.Name = "labelGrn2";
            this.labelGrn2.Size = new System.Drawing.Size(27, 13);
            this.labelGrn2.TabIndex = 10;
            this.labelGrn2.Text = "грн.";
            // 
            // textBoxSum
            // 
            this.textBoxSum.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSum.Location = new System.Drawing.Point(133, 142);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(60, 20);
            this.textBoxSum.TabIndex = 9;
            this.textBoxSum.TextChanged += new System.EventHandler(this.textBoxSum_TextChanged);
            // 
            // textBoxLiters
            // 
            this.textBoxLiters.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxLiters.Location = new System.Drawing.Point(133, 113);
            this.textBoxLiters.Name = "textBoxLiters";
            this.textBoxLiters.Size = new System.Drawing.Size(60, 20);
            this.textBoxLiters.TabIndex = 8;
            this.textBoxLiters.TextChanged += new System.EventHandler(this.textBoxLiters_TextChanged);
            // 
            // labelGrn1
            // 
            this.labelGrn1.AutoSize = true;
            this.labelGrn1.Location = new System.Drawing.Point(189, 70);
            this.labelGrn1.Name = "labelGrn1";
            this.labelGrn1.Size = new System.Drawing.Size(27, 13);
            this.labelGrn1.TabIndex = 7;
            this.labelGrn1.Text = "грн.";
            // 
            // textBoxFuelPrice
            // 
            this.textBoxFuelPrice.Location = new System.Drawing.Point(62, 67);
            this.textBoxFuelPrice.Name = "textBoxFuelPrice";
            this.textBoxFuelPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxFuelPrice.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 70);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Цена";
            // 
            // labelFuel
            // 
            this.labelFuel.AutoSize = true;
            this.labelFuel.Location = new System.Drawing.Point(12, 40);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(44, 13);
            this.labelFuel.TabIndex = 3;
            this.labelFuel.Text = "Бензин";
            // 
            // groupBoxChoise
            // 
            this.groupBoxChoise.Controls.Add(this.radioButtonSum);
            this.groupBoxChoise.Controls.Add(this.radioButtonCount);
            this.groupBoxChoise.Location = new System.Drawing.Point(12, 101);
            this.groupBoxChoise.Name = "groupBoxChoise";
            this.groupBoxChoise.Size = new System.Drawing.Size(115, 70);
            this.groupBoxChoise.TabIndex = 2;
            this.groupBoxChoise.TabStop = false;
            // 
            // radioButtonSum
            // 
            this.radioButtonSum.AutoSize = true;
            this.radioButtonSum.Location = new System.Drawing.Point(12, 42);
            this.radioButtonSum.Name = "radioButtonSum";
            this.radioButtonSum.Size = new System.Drawing.Size(51, 17);
            this.radioButtonSum.TabIndex = 1;
            this.radioButtonSum.TabStop = true;
            this.radioButtonSum.Text = "Сума";
            this.radioButtonSum.UseVisualStyleBackColor = true;
            this.radioButtonSum.CheckedChanged += new System.EventHandler(this.radioButtonSum_CheckedChanged);
            // 
            // radioButtonCount
            // 
            this.radioButtonCount.AutoSize = true;
            this.radioButtonCount.Location = new System.Drawing.Point(12, 15);
            this.radioButtonCount.Name = "radioButtonCount";
            this.radioButtonCount.Size = new System.Drawing.Size(84, 17);
            this.radioButtonCount.TabIndex = 0;
            this.radioButtonCount.TabStop = true;
            this.radioButtonCount.Text = "Количество";
            this.radioButtonCount.UseVisualStyleBackColor = true;
            this.radioButtonCount.CheckedChanged += new System.EventHandler(this.radioButtonCount_CheckedChanged);
            // 
            // groupBoxSum1
            // 
            this.groupBoxSum1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBoxSum1.Controls.Add(this.labelGrn3);
            this.groupBoxSum1.Controls.Add(this.labelFuelSum);
            this.groupBoxSum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSum1.Location = new System.Drawing.Point(12, 177);
            this.groupBoxSum1.Name = "groupBoxSum1";
            this.groupBoxSum1.Size = new System.Drawing.Size(225, 90);
            this.groupBoxSum1.TabIndex = 1;
            this.groupBoxSum1.TabStop = false;
            this.groupBoxSum1.Text = "К оплате";
            // 
            // labelGrn3
            // 
            this.labelGrn3.AutoSize = true;
            this.labelGrn3.Location = new System.Drawing.Point(187, 50);
            this.labelGrn3.Name = "labelGrn3";
            this.labelGrn3.Size = new System.Drawing.Size(27, 13);
            this.labelGrn3.TabIndex = 13;
            this.labelGrn3.Text = "грн.";
            // 
            // labelFuelSum
            // 
            this.labelFuelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFuelSum.Location = new System.Drawing.Point(12, 32);
            this.labelFuelSum.Name = "labelFuelSum";
            this.labelFuelSum.Size = new System.Drawing.Size(169, 37);
            this.labelFuelSum.TabIndex = 12;
            this.labelFuelSum.Text = "0.00";
            // 
            // CafeGroupBox
            // 
            this.CafeGroupBox.Controls.Add(this.labelCafeCount);
            this.CafeGroupBox.Controls.Add(this.labelCafePrice);
            this.CafeGroupBox.Controls.Add(this.textBoxColaCount);
            this.CafeGroupBox.Controls.Add(this.textBoxFriCount);
            this.CafeGroupBox.Controls.Add(this.textBoxBurgerCount);
            this.CafeGroupBox.Controls.Add(this.textBoxHotCount);
            this.CafeGroupBox.Controls.Add(this.textBoxColaPrice);
            this.CafeGroupBox.Controls.Add(this.textBoxFriPrice);
            this.CafeGroupBox.Controls.Add(this.textBoxBurgerPrice);
            this.CafeGroupBox.Controls.Add(this.textBoxHotPrice);
            this.CafeGroupBox.Controls.Add(this.checkBoxCola);
            this.CafeGroupBox.Controls.Add(this.checkBoxFri);
            this.CafeGroupBox.Controls.Add(this.checkBoxBurger);
            this.CafeGroupBox.Controls.Add(this.checkBoxHotDog);
            this.CafeGroupBox.Controls.Add(this.groupBoxSum2);
            this.CafeGroupBox.Location = new System.Drawing.Point(292, 12);
            this.CafeGroupBox.Name = "CafeGroupBox";
            this.CafeGroupBox.Size = new System.Drawing.Size(250, 280);
            this.CafeGroupBox.TabIndex = 1;
            this.CafeGroupBox.TabStop = false;
            this.CafeGroupBox.Text = "Мини-Кафе";
            // 
            // labelCafeCount
            // 
            this.labelCafeCount.AutoSize = true;
            this.labelCafeCount.Location = new System.Drawing.Point(193, 18);
            this.labelCafeCount.Name = "labelCafeCount";
            this.labelCafeCount.Size = new System.Drawing.Size(41, 13);
            this.labelCafeCount.TabIndex = 15;
            this.labelCafeCount.Text = "Кол-во";
            // 
            // labelCafePrice
            // 
            this.labelCafePrice.AutoSize = true;
            this.labelCafePrice.Location = new System.Drawing.Point(131, 18);
            this.labelCafePrice.Name = "labelCafePrice";
            this.labelCafePrice.Size = new System.Drawing.Size(33, 13);
            this.labelCafePrice.TabIndex = 14;
            this.labelCafePrice.Text = "Цена";
            // 
            // textBoxColaCount
            // 
            this.textBoxColaCount.Enabled = false;
            this.textBoxColaCount.Location = new System.Drawing.Point(186, 124);
            this.textBoxColaCount.Name = "textBoxColaCount";
            this.textBoxColaCount.Size = new System.Drawing.Size(55, 20);
            this.textBoxColaCount.TabIndex = 13;
            this.textBoxColaCount.Text = "0";
            this.textBoxColaCount.TextChanged += new System.EventHandler(this.textBoxColaCount_TextChanged);
            // 
            // textBoxFriCount
            // 
            this.textBoxFriCount.Enabled = false;
            this.textBoxFriCount.Location = new System.Drawing.Point(186, 97);
            this.textBoxFriCount.Name = "textBoxFriCount";
            this.textBoxFriCount.Size = new System.Drawing.Size(55, 20);
            this.textBoxFriCount.TabIndex = 12;
            this.textBoxFriCount.Text = "0";
            this.textBoxFriCount.TextChanged += new System.EventHandler(this.textBoxFriCount_TextChanged);
            // 
            // textBoxBurgerCount
            // 
            this.textBoxBurgerCount.Enabled = false;
            this.textBoxBurgerCount.Location = new System.Drawing.Point(186, 70);
            this.textBoxBurgerCount.Name = "textBoxBurgerCount";
            this.textBoxBurgerCount.Size = new System.Drawing.Size(55, 20);
            this.textBoxBurgerCount.TabIndex = 11;
            this.textBoxBurgerCount.Text = "0";
            this.textBoxBurgerCount.TextChanged += new System.EventHandler(this.textBoxBurgerCount_TextChanged);
            // 
            // textBoxHotCount
            // 
            this.textBoxHotCount.Enabled = false;
            this.textBoxHotCount.Location = new System.Drawing.Point(186, 41);
            this.textBoxHotCount.Name = "textBoxHotCount";
            this.textBoxHotCount.Size = new System.Drawing.Size(55, 20);
            this.textBoxHotCount.TabIndex = 10;
            this.textBoxHotCount.Text = "0";
            this.textBoxHotCount.TextChanged += new System.EventHandler(this.textBoxHotCount_TextChanged);
            // 
            // textBoxColaPrice
            // 
            this.textBoxColaPrice.Enabled = false;
            this.textBoxColaPrice.Location = new System.Drawing.Point(120, 124);
            this.textBoxColaPrice.Name = "textBoxColaPrice";
            this.textBoxColaPrice.Size = new System.Drawing.Size(55, 20);
            this.textBoxColaPrice.TabIndex = 9;
            this.textBoxColaPrice.Text = "18,50";
            // 
            // textBoxFriPrice
            // 
            this.textBoxFriPrice.Enabled = false;
            this.textBoxFriPrice.Location = new System.Drawing.Point(120, 97);
            this.textBoxFriPrice.Name = "textBoxFriPrice";
            this.textBoxFriPrice.Size = new System.Drawing.Size(55, 20);
            this.textBoxFriPrice.TabIndex = 8;
            this.textBoxFriPrice.Text = "22,40";
            // 
            // textBoxBurgerPrice
            // 
            this.textBoxBurgerPrice.Enabled = false;
            this.textBoxBurgerPrice.Location = new System.Drawing.Point(120, 70);
            this.textBoxBurgerPrice.Name = "textBoxBurgerPrice";
            this.textBoxBurgerPrice.Size = new System.Drawing.Size(55, 20);
            this.textBoxBurgerPrice.TabIndex = 7;
            this.textBoxBurgerPrice.Text = "25,50";
            // 
            // textBoxHotPrice
            // 
            this.textBoxHotPrice.Enabled = false;
            this.textBoxHotPrice.Location = new System.Drawing.Point(120, 41);
            this.textBoxHotPrice.Name = "textBoxHotPrice";
            this.textBoxHotPrice.Size = new System.Drawing.Size(55, 20);
            this.textBoxHotPrice.TabIndex = 6;
            this.textBoxHotPrice.Text = "20,00";
            // 
            // checkBoxCola
            // 
            this.checkBoxCola.AutoSize = true;
            this.checkBoxCola.Location = new System.Drawing.Point(12, 124);
            this.checkBoxCola.Name = "checkBoxCola";
            this.checkBoxCola.Size = new System.Drawing.Size(79, 17);
            this.checkBoxCola.TabIndex = 5;
            this.checkBoxCola.Text = "Кока-Кола";
            this.checkBoxCola.UseVisualStyleBackColor = true;
            this.checkBoxCola.CheckedChanged += new System.EventHandler(this.checkBoxCola_CheckedChanged);
            // 
            // checkBoxFri
            // 
            this.checkBoxFri.AutoSize = true;
            this.checkBoxFri.Location = new System.Drawing.Point(12, 97);
            this.checkBoxFri.Name = "checkBoxFri";
            this.checkBoxFri.Size = new System.Drawing.Size(108, 17);
            this.checkBoxFri.TabIndex = 4;
            this.checkBoxFri.Text = "Картофель-Фри";
            this.checkBoxFri.UseVisualStyleBackColor = true;
            this.checkBoxFri.CheckedChanged += new System.EventHandler(this.checkBoxFri_CheckedChanged);
            // 
            // checkBoxBurger
            // 
            this.checkBoxBurger.AutoSize = true;
            this.checkBoxBurger.Location = new System.Drawing.Point(12, 70);
            this.checkBoxBurger.Name = "checkBoxBurger";
            this.checkBoxBurger.Size = new System.Drawing.Size(80, 17);
            this.checkBoxBurger.TabIndex = 3;
            this.checkBoxBurger.Text = "Гамбургер";
            this.checkBoxBurger.UseVisualStyleBackColor = true;
            this.checkBoxBurger.CheckedChanged += new System.EventHandler(this.checkBoxBurger_CheckedChanged);
            // 
            // checkBoxHotDog
            // 
            this.checkBoxHotDog.AutoSize = true;
            this.checkBoxHotDog.Location = new System.Drawing.Point(12, 43);
            this.checkBoxHotDog.Name = "checkBoxHotDog";
            this.checkBoxHotDog.Size = new System.Drawing.Size(67, 17);
            this.checkBoxHotDog.TabIndex = 2;
            this.checkBoxHotDog.Text = "Хот-Дог";
            this.checkBoxHotDog.UseVisualStyleBackColor = true;
            this.checkBoxHotDog.CheckedChanged += new System.EventHandler(this.checkBoxHotDog_CheckedChanged);
            // 
            // groupBoxSum2
            // 
            this.groupBoxSum2.Controls.Add(this.labelGrn4);
            this.groupBoxSum2.Controls.Add(this.labelCafeSum);
            this.groupBoxSum2.Location = new System.Drawing.Point(12, 177);
            this.groupBoxSum2.Name = "groupBoxSum2";
            this.groupBoxSum2.Size = new System.Drawing.Size(225, 90);
            this.groupBoxSum2.TabIndex = 1;
            this.groupBoxSum2.TabStop = false;
            this.groupBoxSum2.Text = "К оплате";
            // 
            // labelGrn4
            // 
            this.labelGrn4.AutoSize = true;
            this.labelGrn4.Location = new System.Drawing.Point(187, 50);
            this.labelGrn4.Name = "labelGrn4";
            this.labelGrn4.Size = new System.Drawing.Size(27, 13);
            this.labelGrn4.TabIndex = 14;
            this.labelGrn4.Text = "грн.";
            // 
            // labelCafeSum
            // 
            this.labelCafeSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCafeSum.Location = new System.Drawing.Point(12, 32);
            this.labelCafeSum.Name = "labelCafeSum";
            this.labelCafeSum.Size = new System.Drawing.Size(169, 37);
            this.labelCafeSum.TabIndex = 13;
            this.labelCafeSum.Text = "0.00";
            // 
            // groupBoxTotalSum
            // 
            this.groupBoxTotalSum.Controls.Add(this.groupBoxMode);
            this.groupBoxTotalSum.Controls.Add(this.buttonCalculate);
            this.groupBoxTotalSum.Controls.Add(this.pictureBox1);
            this.groupBoxTotalSum.Controls.Add(this.labelGrn5);
            this.groupBoxTotalSum.Controls.Add(this.labelTotalSum);
            this.groupBoxTotalSum.Location = new System.Drawing.Point(12, 312);
            this.groupBoxTotalSum.Name = "groupBoxTotalSum";
            this.groupBoxTotalSum.Size = new System.Drawing.Size(530, 80);
            this.groupBoxTotalSum.TabIndex = 2;
            this.groupBoxTotalSum.TabStop = false;
            this.groupBoxTotalSum.Text = "Всего к оплате";
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.checkBoxAllMode);
            this.groupBoxMode.Controls.Add(this.checkBoxCafeMode);
            this.groupBoxMode.Controls.Add(this.checkBoxFuelMode);
            this.groupBoxMode.Location = new System.Drawing.Point(202, 9);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(111, 65);
            this.groupBoxMode.TabIndex = 18;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Режим работы";
            // 
            // checkBoxAllMode
            // 
            this.checkBoxAllMode.AutoSize = true;
            this.checkBoxAllMode.Checked = true;
            this.checkBoxAllMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAllMode.Location = new System.Drawing.Point(12, 45);
            this.checkBoxAllMode.Name = "checkBoxAllMode";
            this.checkBoxAllMode.Size = new System.Drawing.Size(45, 17);
            this.checkBoxAllMode.TabIndex = 6;
            this.checkBoxAllMode.Text = "Все";
            this.checkBoxAllMode.UseVisualStyleBackColor = true;
            this.checkBoxAllMode.CheckedChanged += new System.EventHandler(this.checkBoxAllMode_CheckedChanged);
            // 
            // checkBoxCafeMode
            // 
            this.checkBoxCafeMode.AutoSize = true;
            this.checkBoxCafeMode.Location = new System.Drawing.Point(12, 29);
            this.checkBoxCafeMode.Name = "checkBoxCafeMode";
            this.checkBoxCafeMode.Size = new System.Drawing.Size(83, 17);
            this.checkBoxCafeMode.TabIndex = 5;
            this.checkBoxCafeMode.Text = "Мини-Кафе";
            this.checkBoxCafeMode.UseVisualStyleBackColor = true;
            this.checkBoxCafeMode.CheckedChanged += new System.EventHandler(this.checkBoxCafeMode_CheckedChanged);
            // 
            // checkBoxFuelMode
            // 
            this.checkBoxFuelMode.AutoSize = true;
            this.checkBoxFuelMode.Location = new System.Drawing.Point(12, 13);
            this.checkBoxFuelMode.Name = "checkBoxFuelMode";
            this.checkBoxFuelMode.Size = new System.Drawing.Size(75, 17);
            this.checkBoxFuelMode.TabIndex = 4;
            this.checkBoxFuelMode.Text = "Заправка";
            this.checkBoxFuelMode.UseVisualStyleBackColor = true;
            this.checkBoxFuelMode.CheckedChanged += new System.EventHandler(this.checkBoxFuelMode_CheckedChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(95, 15);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 55);
            this.buttonCalculate.TabIndex = 17;
            this.buttonCalculate.Text = "Посчитать";
            this.toolTip1.SetToolTip(this.buttonCalculate, "\r\n       Задержка таймера сброса 5 сек\r\n                                         " +
        "                             \r\n");
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // labelGrn5
            // 
            this.labelGrn5.AutoSize = true;
            this.labelGrn5.Location = new System.Drawing.Point(494, 44);
            this.labelGrn5.Name = "labelGrn5";
            this.labelGrn5.Size = new System.Drawing.Size(27, 13);
            this.labelGrn5.TabIndex = 15;
            this.labelGrn5.Text = "грн.";
            // 
            // labelTotalSum
            // 
            this.labelTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalSum.Location = new System.Drawing.Point(319, 26);
            this.labelTotalSum.Name = "labelTotalSum";
            this.labelTotalSum.Size = new System.Drawing.Size(169, 37);
            this.labelTotalSum.TabIndex = 14;
            this.labelTotalSum.Text = "0.00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(554, 401);
            this.Controls.Add(this.groupBoxTotalSum);
            this.Controls.Add(this.CafeGroupBox);
            this.Controls.Add(this.FuelGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BestOil";
            this.FuelGroupBox.ResumeLayout(false);
            this.FuelGroupBox.PerformLayout();
            this.groupBoxChoise.ResumeLayout(false);
            this.groupBoxChoise.PerformLayout();
            this.groupBoxSum1.ResumeLayout(false);
            this.groupBoxSum1.PerformLayout();
            this.CafeGroupBox.ResumeLayout(false);
            this.CafeGroupBox.PerformLayout();
            this.groupBoxSum2.ResumeLayout(false);
            this.groupBoxSum2.PerformLayout();
            this.groupBoxTotalSum.ResumeLayout(false);
            this.groupBoxTotalSum.PerformLayout();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FuelGroupBox;
        private System.Windows.Forms.GroupBox groupBoxChoise;
        private System.Windows.Forms.GroupBox groupBoxSum1;
        private System.Windows.Forms.GroupBox CafeGroupBox;
        private System.Windows.Forms.GroupBox groupBoxSum2;
        private System.Windows.Forms.GroupBox groupBoxTotalSum;
        private System.Windows.Forms.Label labelGrn1;
        private System.Windows.Forms.TextBox textBoxFuelPrice;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.Label labelLiters;
        private System.Windows.Forms.Label labelGrn2;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxLiters;
        private System.Windows.Forms.RadioButton radioButtonSum;
        private System.Windows.Forms.RadioButton radioButtonCount;
        private System.Windows.Forms.Label labelFuelSum;
        private System.Windows.Forms.Label labelGrn3;
        private System.Windows.Forms.Label labelGrn4;
        private System.Windows.Forms.Label labelCafeSum;
        private System.Windows.Forms.Label labelGrn5;
        private System.Windows.Forms.Label labelTotalSum;
        private System.Windows.Forms.TextBox textBoxColaCount;
        private System.Windows.Forms.TextBox textBoxFriCount;
        private System.Windows.Forms.TextBox textBoxBurgerCount;
        private System.Windows.Forms.TextBox textBoxHotCount;
        private System.Windows.Forms.TextBox textBoxColaPrice;
        private System.Windows.Forms.TextBox textBoxFriPrice;
        private System.Windows.Forms.TextBox textBoxBurgerPrice;
        private System.Windows.Forms.TextBox textBoxHotPrice;
        private System.Windows.Forms.CheckBox checkBoxCola;
        private System.Windows.Forms.CheckBox checkBoxFri;
        private System.Windows.Forms.CheckBox checkBoxBurger;
        private System.Windows.Forms.CheckBox checkBoxHotDog;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCafeCount;
        private System.Windows.Forms.Label labelCafePrice;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.CheckBox checkBoxAllMode;
        private System.Windows.Forms.CheckBox checkBoxCafeMode;
        private System.Windows.Forms.CheckBox checkBoxFuelMode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

