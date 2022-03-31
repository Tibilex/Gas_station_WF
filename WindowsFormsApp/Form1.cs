using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Заполнение комбобокса из колекции и выбор его нулевого индекса
            comboBox1.DataSource = FuelType;
            comboBox1.SelectedIndex = 0;
        }

        // переменные для подсчета сумм
        double TotalSum;
        double sumFuel;
        double sum1;
        double sum2;
        double sum3;
        double sum4;

        // Колекция хранения марок топлива
        List<string> FuelType = new List<string>()
        {
            {"AИ-92"},
            {"AИ-95"},
            {"AИ-98"},
            {"ДТ"},
            {"Газ"}
        };

        // Колекция цен для марок топлива
        List<string> FuelPrice = new List<string>()
        {
            {"23,99"},
            {"24,99"},
            {"25,99"},
            {"21,99"},
            {"11,99"}
        };

        // Обработка выбора элемента в комбобоксе по умолчанию
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFuelPrice.Text = FuelPrice[comboBox1.SelectedIndex];
        }

        // Событие изменения в поле текстбокс "Литры"
        private void textBoxLiters_TextChanged(object sender, EventArgs e)
        {
            FuelCalculate();
        }

        // Событие обработки выбора флага "Количество"
        private void radioButtonCount_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSum.Enabled = false;     // Текстбокс с "Цена" отключен
            textBoxLiters.Enabled = true;   // Текстбокс с "Литры" включен
        }

        // Событие обработки выбора флага "Цена"
        private void radioButtonSum_CheckedChanged(object sender, EventArgs e)
        {
            textBoxLiters.Enabled = false;  // Текстбокс с "Литры" отключен
            textBoxSum.Enabled = true;      // Текстбокс с "Цена" включен
        }

        // Событие изменения в поле текстбокс "Сумма"
        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            FuelCalculate();
        }

        //
        private void checkBoxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHotDog.Checked)
                textBoxHotCount.Enabled = true;
            if (!checkBoxHotDog.Checked)
                textBoxHotCount.Enabled = false;
        }

        //
        private void checkBoxBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBurger.Checked)
                textBoxBurgerCount.Enabled = true;
            if (!checkBoxBurger.Checked)
                textBoxBurgerCount.Enabled = false;
        }

        //
        private void checkBoxFri_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFri.Checked)
                textBoxFriCount.Enabled = true;
            if (!checkBoxFri.Checked)
                textBoxFriCount.Enabled = false;
        }

        //
        private void checkBoxCola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCola.Checked)
                textBoxColaCount.Enabled = true;
            if (!checkBoxCola.Checked)
                textBoxColaCount.Enabled = false;
        }

        // Метод Обработки цены топлива
        private double FuelCalculate()
        {
            // переменные для подсчета сумм
            double count;
            double price;

            // Если строка "Литры" пуста ставим 0
            if (textBoxLiters.Text == string.Empty)
                textBoxLiters.Text = "0";
            // Если строка "грн" пуста ставим 0
            if (textBoxSum.Text == string.Empty)
                textBoxSum.Text = "0";


            // Если выбран варинат расчета в "Литрах"
            if (radioButtonCount.Checked)
            {
                count = Convert.ToDouble(textBoxLiters.Text);                   // Конвертируем поле "Литры" в тип Double
                price = Convert.ToDouble(FuelPrice[comboBox1.SelectedIndex]);   // Конвертируем поле "Цена" в тип Double
                sumFuel = count * price;                                        // Сумма подсчета цены
                labelFuelSum.Text = Convert.ToString(sumFuel);                  // Конвертируем сумму в строку и выводим в поле "К оплате"
                return sumFuel;
            }

            // Если выбран варинат расчета с "Сумой"
            if (radioButtonSum.Checked)
            {
                count = Convert.ToDouble(textBoxSum.Text);                      // Конвертируем поле "Сума" в тип Double
                price = Convert.ToDouble(FuelPrice[comboBox1.SelectedIndex]);   // Конвертируем поле "Литры" в тип Double
                sumFuel = Math.Round(count / price, 2);                         // Сумма литров за вписаную сумму округленая до 2 знака по ","
                textBoxLiters.Text = Convert.ToString(sumFuel);                 // Вывод суммы литров в поле "Литры"
                labelFuelSum.Text = textBoxSum.Text;                            // Сумма в поле "К оплате"
                return count;
            }
            return sumFuel = 0;
        }

        // Метод обработки цен "Мини-Кафе"
        private void CafeCalculate()
        {
            // Флаг "Хот-дог" активен
            if (checkBoxHotDog.Checked) 
            {
                double HotDogPrice = Convert.ToDouble(textBoxHotPrice.Text);    // Конвертируем поле "Цена" в тип double
                double HotDogSum = Convert.ToDouble(textBoxHotCount.Text);      // Конвертируем поле "Количество" в тип double
                sum1 = Math.Round(HotDogPrice * HotDogSum, 2);                  // Подсчет суммы
            }
            // Флаг "Бургер" активен
            if (checkBoxBurger.Checked)
            {
                double BurgerPrice = Convert.ToDouble(textBoxBurgerPrice.Text);
                double BurgerSum = Convert.ToDouble(textBoxBurgerCount.Text);
                sum2 = Math.Round(BurgerPrice * BurgerSum, 2);
            }
            // Флаг "Картофель-фри" активен
            if (checkBoxFri.Checked)
            {
                double FriPrice = Convert.ToDouble(textBoxFriPrice.Text);
                double FriSum = Convert.ToDouble(textBoxFriCount.Text);
                sum3 = Math.Round(FriPrice * FriSum, 2);
            }
            // Флаг "Кока-Кола" активен
            if (checkBoxCola.Checked)
            {
                double ColaPrice = Convert.ToDouble(textBoxColaPrice.Text);
                double ColaSum = Convert.ToDouble(textBoxColaCount.Text);
                sum4 = Math.Round(ColaPrice * ColaSum, 2);
            }
            labelCafeSum.Text = Convert.ToString(sum1 + sum2 + sum3 + sum4);    // Вывод общей суммы в поле "К оплате"
        }

        // Обработка кнопки "Подсчитать"
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            TotalSum = Math.Round(FuelCalculate() + sum1 + sum2 + sum3 + sum4, 2);  // Общая сумма 
            labelTotalSum.Text = Convert.ToString(TotalSum);                        // Конвертация числа в строку и вывод
            timer1.Enabled = true; 
        }

        // Обработка изменений в поле "количество хот-догов"
        private void textBoxHotCount_TextChanged(object sender, EventArgs e)
        {
            CafeCalculate();
        }

        // Обработка изменений в поле "количество бургеров"
        private void textBoxBurgerCount_TextChanged(object sender, EventArgs e)
        {
            CafeCalculate();
        }

        // Обработка изменений в поле "количество картофеля-фри"
        private void textBoxFriCount_TextChanged(object sender, EventArgs e)
        {
            CafeCalculate();
        }

        // Обработка изменений в поле "количество кока-колы"
        private void textBoxColaCount_TextChanged(object sender, EventArgs e)
        {
            CafeCalculate();
        }

        // таймер кнопки
        int timerTick;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerTick++;
            timer1.Interval = 1000;
            if (timerTick == 5)
            {
                timer1.Stop();
                DialogResult select = MessageBox.Show("Сбросить Подсчеты?", "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (select == DialogResult.Yes) { AllReset(); }
                if (select == DialogResult.No) { timerTick = 0; timer1.Start(); }
            }
        }

        // Общий сброс
        private void AllReset()
        {
            textBoxLiters.Text = "0";
            textBoxSum.Text = "0";
            textBoxHotCount.Text = "0";
            textBoxBurgerCount.Text = "0";
            textBoxFriCount.Text = "0";
            textBoxColaCount.Text = "0";

            radioButtonCount.Checked = true;
            checkBoxHotDog.Checked = false;
            checkBoxBurger.Checked = false;
            checkBoxFri.Checked = false;
            checkBoxCola.Checked = false;

            labelFuelSum.Text = "0,00";
            labelCafeSum.Text = "0,00";
            labelTotalSum.Text = "0,00";
        }

        // Режим работы "Заправка"
        private void checkBoxFuelMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFuelMode.Checked)
            {
                FuelGroupBox.Enabled = true;
                CafeGroupBox.Enabled = false;
                checkBoxAllMode.Checked = false;
                checkBoxCafeMode.Checked = false;
                AllReset();
            }
        }

        // Режим работы "Кафе"
        private void checkBoxCafeMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCafeMode.Checked)
            {
                CafeGroupBox.Enabled = true;
                FuelGroupBox.Enabled = false;
                checkBoxAllMode.Checked = false;
                checkBoxFuelMode.Checked = false;
                AllReset();
            }
        }

        // Режим работы "Всё"
        private void checkBoxAllMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAllMode.Checked)
            {
                CafeGroupBox.Enabled = true;
                FuelGroupBox.Enabled = true;
                checkBoxCafeMode.Checked = false;
                checkBoxFuelMode.Checked = false;
                AllReset();
            }
        }
    }
}
