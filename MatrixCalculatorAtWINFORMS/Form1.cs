using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalculatorAtWINFORMS
{
    public partial class Form1 : Form
    {
        static private int counterColumnsA = 5;
        static private int counterRowsA = 5;

        static private int counterColumnsB = 5;
        static private int counterRowsB = 5;

        static private int counterColumnsR = 5;
        static private int counterRowsR = 5;



        TextBox[,] arrСolumnsA;// массив столбцов матрицы А
        TextBox[,] arrRowsA;// массив строк матрицы А

        TextBox[,] arrСolumnsB;//массив столбцов матрицы В
        TextBox[,] arrRowsB;// массив строк матрицы B

        Panel panelForoneNum; // панель для степени и корня
        TextBox texboxForOneNum; // текст бокс для степени и корня;
        Label listboxForOneNum;// лист бокс для степени и корня

        double[,] MatrixA = new double[counterColumnsA, counterRowsA];
        double[,] MatrixB = new double[counterColumnsB, counterRowsB];
        double[,] MatrixR = new double[counterColumnsA, counterRowsA];

        TextBox[,] T_MatrixR = new TextBox[counterColumnsR, counterRowsR];





        public Form1()
        {
            InitializeComponent();
            //comboOperations.SelectedIndex = 0;



        }


        private void FillingMatrixA()
        {

            for (int i = 0; i < counterRowsA; i++)
            {
                for (int j = 0; j < counterColumnsA; j++)
                {
                    MatrixA[i, j] = Convert.ToDouble(arrRowsA[i, j].Text.Replace('.', ','));
                }
            }
        }
        private void FillingMatrixB()
        {

            for (int i = 0; i < counterRowsB; i++)
            {
                for (int j = 0; j < counterColumnsB; j++)
                {
                    MatrixB[i, j] = Convert.ToDouble(arrRowsB[i, j].Text.Replace('.', ',')); ;
                }
            }
        }

        private void OutMatrixR()
        {
            for (int i = 0; i < counterRowsB; i++)
            {
                for (int j = 0; j < counterColumnsB; j++)
                {
                    MatrixR[i, j] = MatrixB[i, j];
                }
            }
        }

        private void WriteMatrixR()
        {
            for (int i = 0; i < counterRowsA; i++)
            {
                for (int j = 0; j < counterColumnsA; j++)
                {
                    T_MatrixR[i, j].Text = Convert.ToString(MatrixR[i, j]);
                }
            }
        }

        private void WriteMatrixRForMult()
        {
            for (int i = 0; i < counterRowsA; i++)
            {
                for (int j = 0; j < counterColumnsB; j++)
                {
                    T_MatrixR[i, j].Text = Convert.ToString(MatrixR[i, j]);
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)//действия при загрузке формы
        {
            this.Size = new Size(850, 420);
            



            arrСolumnsA = new TextBox[,] { { textBoxA1_1, textBoxA2_1, textBoxA3_1, textBoxA4_1, textBoxA5_1 },// столбцы матрицы А
                                           { textBoxA1_2, textBoxA2_2, textBoxA3_2, textBoxA4_2, textBoxA5_2 },
                                           { textBoxA1_3, textBoxA2_3, textBoxA3_3, textBoxA4_3, textBoxA5_3 },
                                           { textBoxA1_4, textBoxA2_4, textBoxA3_4, textBoxA4_4, textBoxA5_4 },
                                           { textBoxA1_5, textBoxA2_5, textBoxA3_5, textBoxA4_5, textBoxA5_5 }};


            arrRowsA = new TextBox[,] { {textBoxA1_1, textBoxA1_2, textBoxA1_3, textBoxA1_4, textBoxA1_5},// строки матрицы А
                                        {textBoxA2_1, textBoxA2_2, textBoxA2_3, textBoxA2_4, textBoxA2_5},
                                        {textBoxA3_1, textBoxA3_2, textBoxA3_3, textBoxA3_4, textBoxA3_5},
                                        {textBoxA4_1, textBoxA4_2, textBoxA4_3, textBoxA4_4, textBoxA4_5},
                                        {textBoxA5_1, textBoxA5_2, textBoxA5_3, textBoxA5_4, textBoxA5_5 }};


            arrСolumnsB = new TextBox[,] { { textBoxB1_1, textBoxB2_1, textBoxB3_1, textBoxB4_1, textBoxB5_1 },// столбцы матрицы В
                                           { textBoxB1_2, textBoxB2_2, textBoxB3_2, textBoxB4_2, textBoxB5_2 },
                                           { textBoxB1_3, textBoxB2_3, textBoxB3_3, textBoxB4_3, textBoxB5_3 },
                                           { textBoxB1_4, textBoxB2_4, textBoxB3_4, textBoxB4_4, textBoxB5_4 },
                                           { textBoxB1_5, textBoxB2_5, textBoxB3_5, textBoxB4_5, textBoxB5_5 }};


            arrRowsB = new TextBox[,] { {textBoxB1_1, textBoxB1_2, textBoxB1_3, textBoxB1_4, textBoxB1_5},// строки матрицы А
                                        {textBoxB2_1, textBoxB2_2, textBoxB2_3, textBoxB2_4, textBoxB2_5},
                                        {textBoxB3_1, textBoxB3_2, textBoxB3_3, textBoxB3_4, textBoxB3_5},
                                        {textBoxB4_1, textBoxB4_2, textBoxB4_3, textBoxB4_4, textBoxB4_5},
                                        {textBoxB5_1, textBoxB5_2, textBoxB5_3, textBoxB5_4, textBoxB5_5 }};


            T_MatrixR = new TextBox[,] {{textBoxR1_1, textBoxR1_2, textBoxR1_3, textBoxR1_4, textBoxR1_5},// строки матрицы А
                                        {textBoxR2_1, textBoxR2_2, textBoxR2_3, textBoxR2_4, textBoxR2_5},
                                        {textBoxR3_1, textBoxR3_2, textBoxR3_3, textBoxR3_4, textBoxR3_5},
                                        {textBoxR4_1, textBoxR4_2, textBoxR4_3, textBoxR4_4, textBoxR4_5},
                                        {textBoxR5_1, textBoxR5_2, textBoxR5_3, textBoxR5_4, textBoxR5_5 }};

            labelMultiplicationType.Visible = false;// скрываем при загрузке тип операции
            panelMultiplicationType.Visible = false;


            panelForoneNum = new Panel // описываем панель для степени и корня
            {
                Location = new Point(420, 90),
                Size = new Size(64, 64),
                BackColor = Color.FromArgb(52, 198, 205),
                Visible = false,
                BorderStyle = BorderStyle.FixedSingle,

            };
            this.Controls.Add(panelForoneNum);

            texboxForOneNum = new TextBox// описываем текстбокс для степени и корня
            {
                Location = new Point(427, 106),
                Size = new Size(50, 50),
                Font = new Font("Segoe UI", 14.0f),
                BackColor = Color.White,
                Visible = false

            };
            this.Controls.Add(texboxForOneNum);
            texboxForOneNum.BringToFront();


            listboxForOneNum = new Label
            {
                Location = new Point(321, 90),
                Size = new Size(100, 64),
                Font = new Font("Segoe UI", 14.0f),
                BackColor = Color.FromArgb(52, 198, 205),
                Visible = false,
                BorderStyle = BorderStyle.FixedSingle,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            this.Controls.Add(listboxForOneNum);

            checkBoxHints.Checked = Properties.Settings.Default.checkBoxHints;
            checkBoxForDark.Checked = Properties.Settings.Default.checkBoxForDark;

        }

        private void comboOperations_SelectedIndexChanged(object sender, EventArgs e)// обработка действий при выборе знака
        {
            switch (comboOperations.SelectedIndex)// обработка действий при выборе знака
            {
                case 0:
                    {
                        labelMultiplicationType.Visible = false;// скрываем при сложении тип операции
                        panelMultiplicationType.Visible = false;
                        VisibleMatrixB();

                        panelForoneNum.Visible = false;
                        texboxForOneNum.Visible = false;
                        break;
                    }

                case 1:
                    {

                        labelMultiplicationType.Visible = false;// скрываем при вычитании тип операции
                        panelMultiplicationType.Visible = false;

                        panelForoneNum.Visible = false;
                        texboxForOneNum.Visible = false;
                        VisibleMatrixB();
                        break;
                    }

                case 2:
                    {
                        VisibleMatrixB();
                        labelMultiplicationType.Text = "Тип умножения";
                        radioButtonMultiplicationType1.Visible = true;
                        radioButtonMultiplicationType1.Text = "[A]×[B]";
                        radioButtonMultiplicationType2.Text = "[A]×[n]";
                        labelMultiplicationType.Visible = true;// показываем при умножении
                        panelMultiplicationType.Visible = true;

                        panelForoneNum.Visible = false;
                        texboxForOneNum.Visible = false;
                        break;
                    }

                case 3:
                    {
                        panel4.Visible = false;
                        label4.Visible = false;
                        buttonBMinusСolumn.Visible = false;
                        buttonBPlusСolumn.Visible = false;
                        buttonBMinusRows.Visible = false;
                        buttonBPlusRows.Visible = false;
                        refreshB.Visible = false;

                        panelForoneNum.Visible = true;
                        texboxForOneNum.Visible = true;

                        labelMultiplicationType.Visible = false;// показываем при делении
                        panelMultiplicationType.Visible = false;
                        break;

                    }

            }
        }
        private void onlineHelp_Click(object sender, EventArgs e)//открываем справку в интернете в соответсвии со знаком
        {

            switch (comboOperations.SelectedIndex)
            {
                case 0:
                    {
                        System.Diagnostics.Process.Start("https://telegra.ph/Summa-raznost-matric-11-08");
                        break;
                    }

                case 1:
                    {
                        System.Diagnostics.Process.Start("https://telegra.ph/Summa-raznost-matric-11-08");
                        break;
                    }

                case 2:
                    {
                        System.Diagnostics.Process.Start("https://telegra.ph/Umnozhenie-matric-11-08");
                        break;
                    }
                case 3:
                    {
                        System.Diagnostics.Process.Start("https://telegra.ph/Delenie-matric-11-08");
                        break;
                    }

                default:
                    {
                        MessageBox.Show("Выберите один из знаков операции", "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
            }


        }

        private void buttonAMinusСolumn_Click(object sender, EventArgs e)// уменьшение столбцов матрицы А
        {
            switch (counterColumnsA)
            {
                case 5:
                    {
                        textBoxA1_5.Visible = false;
                        textBoxA2_5.Visible = false;
                        textBoxA3_5.Visible = false;
                        textBoxA4_5.Visible = false;
                        textBoxA5_5.Visible = false;
                        counterColumnsA--;
                        break;
                    }
                case 4:
                    {
                        textBoxA1_4.Visible = false;
                        textBoxA2_4.Visible = false;
                        textBoxA3_4.Visible = false;
                        textBoxA4_4.Visible = false;
                        textBoxA5_4.Visible = false;
                        counterColumnsA--;
                        break;
                    }
                case 3:
                    {
                        textBoxA1_3.Visible = false;
                        textBoxA2_3.Visible = false;
                        textBoxA3_3.Visible = false;
                        textBoxA4_3.Visible = false;
                        textBoxA5_3.Visible = false;
                        counterColumnsA--;

                        break;
                    }
                case 2:
                    {
                        textBoxA1_2.Visible = false;
                        textBoxA2_2.Visible = false;
                        textBoxA3_2.Visible = false;
                        textBoxA4_2.Visible = false;
                        textBoxA5_2.Visible = false;
                        counterColumnsA--;

                        break;
                    }
                case 1:
                    {
                        if (checkBoxHints.Checked == false)
                        {
                            MessageBox.Show("Вы хотите убрать последний столбец. Операция невозможна.",
                                "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                        }


                        break;
                    }

            }
        }

        private void buttonAMinusRows_Click(object sender, EventArgs e)// уменьшение строк матрицы А
        {
            switch (counterRowsA)
            {
                case 5:
                    {
                        textBoxA5_1.Visible = false;
                        textBoxA5_2.Visible = false;
                        textBoxA5_3.Visible = false;
                        textBoxA5_4.Visible = false;
                        textBoxA5_5.Visible = false;
                        counterRowsA--;
                        break;
                    }
                case 4:
                    {
                        textBoxA4_1.Visible = false;
                        textBoxA4_2.Visible = false;
                        textBoxA4_3.Visible = false;
                        textBoxA4_4.Visible = false;
                        textBoxA4_5.Visible = false;
                        counterRowsA--;
                        break;
                    }
                case 3:
                    {
                        textBoxA3_1.Visible = false;
                        textBoxA3_2.Visible = false;
                        textBoxA3_3.Visible = false;
                        textBoxA3_4.Visible = false;
                        textBoxA3_5.Visible = false;
                        counterRowsA--;
                        break;
                    }
                case 2:
                    {
                        textBoxA2_1.Visible = false;
                        textBoxA2_2.Visible = false;
                        textBoxA2_3.Visible = false;
                        textBoxA2_4.Visible = false;
                        textBoxA2_5.Visible = false;
                        counterRowsA--;
                        break;
                    }
                case 1:
                    {
                        if (checkBoxHints.Checked == false)
                        {
                            MessageBox.Show("Вы хотите убрать последнюю строку. Операция невозможна.",
                                "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                        }

                        break;
                    }


            }
        }

        private void buttonAPlusСolumn_Click(object sender, EventArgs e)// прибавляем столбцы матрицы А
        {
            switch (counterColumnsA)
            {

                case 1:
                    {
                        for (int i = 0; i < counterRowsA; i++)
                        {
                            arrСolumnsA[1, i].Visible = true;

                        }
                        counterColumnsA++;
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < counterRowsA; i++)
                        {
                            arrСolumnsA[2, i].Visible = true;
                        }
                        counterColumnsA++;
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < counterRowsA; i++)
                        {
                            arrСolumnsA[3, i].Visible = true;
                        }
                        counterColumnsA++;
                        break;
                    }
                case 4:
                    {
                        for (int i = 0; i < counterRowsA; i++)
                        {
                            arrСolumnsA[4, i].Visible = true;
                        }
                        counterColumnsA++;
                        break;
                    }
                case 5:
                    {
                        if (checkBoxHints.Checked == false)
                        {
                            MessageBox.Show("Вы достигли максимального количества столбцов. Операция невозможна.",
                        "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                        }
                        break;
                    }

            }
        }

        private void buttonAPlusRows_Click(object sender, EventArgs e)// прибавляем строки матрицы А
        {
            switch (counterRowsA)
            {
                case 1:
                    {
                        for (int i = 0; i < counterColumnsA; i++)
                        {
                            arrRowsA[1, i].Visible = true;

                        }
                        counterRowsA++;
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < counterColumnsA; i++)
                        {
                            arrRowsA[2, i].Visible = true;

                        }
                        counterRowsA++;
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < counterColumnsA; i++)
                        {
                            arrRowsA[3, i].Visible = true;

                        }
                        counterRowsA++;
                        break;
                    }
                case 4:
                    {
                        for (int i = 0; i < counterColumnsA; i++)
                        {
                            arrRowsA[4, i].Visible = true;

                        }
                        counterRowsA++;
                        break;
                    }
                case 5:
                    {
                        if (checkBoxHints.Checked == false)
                        {
                            MessageBox.Show("Вы достигли максимального количества строк. Операция невозможна.",
                        "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                        }
                        break;
                    }





            }
        }

        private void buttonBMinusСolumn_Click(object sender, EventArgs e)// уменьшение столбцов матрицы B
        {
            switch (counterColumnsB)
            {
                case 5:
                    {
                        textBoxB1_5.Visible = false;
                        textBoxB2_5.Visible = false;
                        textBoxB3_5.Visible = false;
                        textBoxB4_5.Visible = false;
                        textBoxB5_5.Visible = false;
                        counterColumnsB--;
                        break;
                    }
                case 4:
                    {
                        textBoxB1_4.Visible = false;
                        textBoxB2_4.Visible = false;
                        textBoxB3_4.Visible = false;
                        textBoxB4_4.Visible = false;
                        textBoxB5_4.Visible = false;
                        counterColumnsB--;
                        break;
                    }
                case 3:
                    {
                        textBoxB1_3.Visible = false;
                        textBoxB2_3.Visible = false;
                        textBoxB3_3.Visible = false;
                        textBoxB4_3.Visible = false;
                        textBoxB5_3.Visible = false;
                        counterColumnsB--;

                        break;
                    }
                case 2:
                    {
                        textBoxB1_2.Visible = false;
                        textBoxB2_2.Visible = false;
                        textBoxB3_2.Visible = false;
                        textBoxB4_2.Visible = false;
                        textBoxB5_2.Visible = false;
                        counterColumnsB--;

                        break;
                    }
                case 1:
                    {
                        if (checkBoxHints.Checked == false)
                        {
                            MessageBox.Show("Вы хотите убрать последний столбец. Операция невозможна.",
                            "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                        }

                        break;
                    }

            }
        }

        private void buttonBMinusRows_Click(object sender, EventArgs e)// уменьшение строк матрицы В
        {
            switch (counterRowsB)
            {
                case 5:
                    {
                        textBoxB5_1.Visible = false;
                        textBoxB5_2.Visible = false;
                        textBoxB5_3.Visible = false;
                        textBoxB5_4.Visible = false;
                        textBoxB5_5.Visible = false;
                        counterRowsB--;
                        break;
                    }
                case 4:
                    {
                        textBoxB4_1.Visible = false;
                        textBoxB4_2.Visible = false;
                        textBoxB4_3.Visible = false;
                        textBoxB4_4.Visible = false;
                        textBoxB4_5.Visible = false;
                        counterRowsB--;
                        break;
                    }
                case 3:
                    {
                        textBoxB3_1.Visible = false;
                        textBoxB3_2.Visible = false;
                        textBoxB3_3.Visible = false;
                        textBoxB3_4.Visible = false;
                        textBoxB3_5.Visible = false;
                        counterRowsB--;
                        break;
                    }
                case 2:
                    {
                        textBoxB2_1.Visible = false;
                        textBoxB2_2.Visible = false;
                        textBoxB2_3.Visible = false;
                        textBoxB2_4.Visible = false;
                        textBoxB2_5.Visible = false;
                        counterRowsB--;
                        break;
                    }
                case 1:
                    {
                        if (checkBoxHints.Checked == false)
                        {
                            MessageBox.Show("Вы хотите убрать последнюю строку. Операция невозможна.",
                            "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                        }
                        break;
                    }


            }
        }

        private void buttonBPlusСolumn_Click(object sender, EventArgs e)// прибавляем столбцы матрицы В
        {
            switch (counterColumnsB)
            {

                case 1:
                    {
                        for (int i = 0; i < counterRowsB; i++)
                        {
                            arrСolumnsB[1, i].Visible = true;
                        }
                        counterColumnsB++;
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < counterRowsB; i++)
                        {
                            arrСolumnsB[2, i].Visible = true;
                        }
                        counterColumnsB++;
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < counterRowsB; i++)
                        {
                            arrСolumnsB[3, i].Visible = true;
                        }
                        counterColumnsB++;
                        break;
                    }
                case 4:
                    {
                        for (int i = 0; i < counterRowsB; i++)
                        {
                            arrСolumnsB[4, i].Visible = true;
                        }
                        counterColumnsB++;
                        break;
                    }
                case 5:
                    {
                        if (checkBoxHints.Checked == false)
                        {
                            MessageBox.Show("Вы достигли максимального количества столбцов. Операция невозможна.",
                        "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                        }
                        break;
                    }
            }
        }

        private void buttonBPlusRows_Click(object sender, EventArgs e)// прибавляем строки матрицы В
        {
            switch (counterRowsB)
            {
                case 1:
                    {
                        for (int i = 0; i < counterColumnsB; i++)
                        {
                            arrRowsB[1, i].Visible = true;

                        }
                        counterRowsB++;
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < counterColumnsB; i++)
                        {
                            arrRowsB[2, i].Visible = true;

                        }
                        counterRowsB++;
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < counterColumnsB; i++)
                        {
                            arrRowsB[3, i].Visible = true;

                        }
                        counterRowsB++;
                        break;
                    }
                case 4:
                    {
                        for (int i = 0; i < counterColumnsB; i++)
                        {
                            arrRowsB[4, i].Visible = true;

                        }
                        counterRowsB++;
                        break;
                    }
                case 5:
                    {
                        if (checkBoxHints.Checked == false)
                        {
                            MessageBox.Show("Вы достигли максимального количества строк. Операция невозможна.",
                        "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                        }
                        break;
                    }

            }
        }



        private void MultiplicationType(object sender, EventArgs e)// при умножении на число, матрица В пропадает
        {
            if (radioButtonMultiplicationType1.Checked == true)
            {
                VisibleMatrixB();
                panelForoneNum.Visible = false;
                texboxForOneNum.Visible = false;
            }
            else
            {
                FooForRefrashB();
                panel4.Visible = false;
                label4.Visible = false;
                buttonBMinusСolumn.Visible = false;
                buttonBPlusСolumn.Visible = false;
                buttonBMinusRows.Visible = false;
                buttonBPlusRows.Visible = false;
                refreshB.Visible = false;

                panelForoneNum.Visible = true;
                texboxForOneNum.Visible = true;

            }

        }
        private void VisibleMatrixB()// метод для отображения матрицы В
        {
            radioButtonMultiplicationType1.Checked = true;
            panel4.Visible = true;
            label4.Visible = true;
            buttonBMinusСolumn.Visible = true;
            buttonBPlusСolumn.Visible = true;
            buttonBMinusRows.Visible = true;
            buttonBPlusRows.Visible = true;
            refreshB.Visible = true;
        }

        private void OperationType(object sender, EventArgs e)// при возведении в степень и извлечения корня матрица B и выбор знака пропадает
        {
            if (radioButtonTypeOperation1.Checked == true)
            {
                VisibleMatrixB();
                comboOperations.Visible = true;
                panelForoneNum.Visible = false;
                texboxForOneNum.Visible = false;

                listboxForOneNum.Visible = false;
                comboOperations.SelectedIndex = 0;

            }
            if (radioButtonTypeOperation2.Checked == true)
            {
                labelMultiplicationType.Visible = false;// скрываем при сложении тип операции
                panelMultiplicationType.Visible = false;

                panel4.Visible = false;
                label4.Visible = false;
                buttonBMinusСolumn.Visible = false;
                buttonBPlusСolumn.Visible = false;
                buttonBMinusRows.Visible = false;
                buttonBPlusRows.Visible = false;
                comboOperations.Visible = false;
                refreshB.Visible = false;


                panelForoneNum.Visible = true;
                texboxForOneNum.Visible = true;
                listboxForOneNum.Visible = true;
                listboxForOneNum.Text = "в степени";

            }
            if (radioButtonTypeOperation3.Checked == true)
            {
                labelMultiplicationType.Visible = false;// скрываем при сложении тип операции
                panelMultiplicationType.Visible = false;


                panel4.Visible = false;
                label4.Visible = false;
                buttonBMinusСolumn.Visible = false;
                buttonBPlusСolumn.Visible = false;
                buttonBMinusRows.Visible = false;
                buttonBPlusRows.Visible = false;
                comboOperations.Visible = false;
                refreshB.Visible = false;

                panelForoneNum.Visible = true;
                texboxForOneNum.Visible = true;
                listboxForOneNum.Visible = true;
                listboxForOneNum.Text = "корень степени";
            }
        }

        private void refreshA_Click(object sender, EventArgs e) // рефреш матрицы А
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arrСolumnsA[i, j].Visible = true;
                    counterColumnsA = 5;
                    counterRowsA = 5;
                    arrСolumnsA[i, j].Text = "";
                }
            }
        }

        private void refreshB_Click(object sender, EventArgs e) // рефреш матрицы B
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arrСolumnsB[i, j].Visible = true;
                    counterColumnsB = 5;
                    counterRowsB = 5;
                    arrСolumnsB[i, j].Text = "";
                }
            }

            
        }
        
        private void FooForRefrashB()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arrСolumnsB[i, j].Visible = true;
                    counterColumnsB = 5;
                    counterRowsB = 5;
                    arrСolumnsB[i, j].Text = "";
                }
            }
        }


        private void ChangeOfZizeMatrixR() // меняем размер матрицы под результат
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (T_MatrixR[i, j].Text != "")
                    {
                        T_MatrixR[i, j].Visible = true;
                    }
                    else
                    {
                        T_MatrixR[i, j].Visible = false;
                    }
                }

            }

        }

        private void ClearMatrixR()
        {

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    //MatrixR[i, j] = 0.0;
                    T_MatrixR[i, j].Text = "";
                }

            }
        }
        private void result_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonTypeOperation1.Checked == true)
                {
                    switch (comboOperations.SelectedIndex)
                    {


                        case 0:
                            {
                                ClearMatrixR();
                                MatrixA_Plus_MatrixB();
                                ChangeOfZizeMatrixR();


                                break;
                            }
                        case 1:
                            {
                                ClearMatrixR();
                                MatrixA_Minus_MatrixB();
                                ChangeOfZizeMatrixR();

                                break;
                            }
                        case 2:
                            {
                                if (counterColumnsA == 1 && counterRowsA == 1)

                                {
                                    MessageBox.Show("Вижу у вас где-то одинокая циферка. Лучше воспользуйтесь типом умножения [A]×[n]",
                                                "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    if (counterColumnsB == 1 && counterRowsB == 1)
                                    {
                                        MessageBox.Show("Вижу у вас где-то одинокая циферка. Лучше воспользуйтесь типом умножения [A]×[n]",
                                                    "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        if (radioButtonMultiplicationType1.Checked == true)
                                        {
                                            ClearMatrixR();
                                            for(int i=0; i <5;i++)
                                            {
                                                for(int j = 0; j <5; j++)
                                                {
                                                    MatrixR[i, j] = 0;
                                                }
                                            }
                                            MatrixA_Multiplication_MatrixB();
                                            ChangeOfZizeMatrixR();
                                        }
                                        if (radioButtonMultiplicationType2.Checked == true)
                                        {
                                            ClearMatrixR();
                                            MatrixA_Multiplication_Nums();
                                            ChangeOfZizeMatrixR();
                                        }
                                    }
                                    
                                }
                                break;
                            }
                        case 3:
                            {

                                ClearMatrixR();
                                MatrixA_Division_Nums();
                                ChangeOfZizeMatrixR();

                                break;
                            }
                        default:
                            {

                                MessageBox.Show("Выберете знак операции",
                                    "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                    }
                }
                if (radioButtonTypeOperation2.Checked == true)
                {
                    ClearMatrixR();
                    Exponentiation_MatrixA();
                    ChangeOfZizeMatrixR();
                }
                if (radioButtonTypeOperation3.Checked == true)
                {
                    ClearMatrixR();
                    Extraction_MatrixA();
                    ChangeOfZizeMatrixR();

                }
            }
            catch
            {
                MessageBox.Show("Заполните все поля",
                                "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }

        private void MatrixA_Plus_MatrixB()//сложение мариц
        {
            if (counterRowsA == counterRowsB && counterColumnsA == counterColumnsB)
            {
                FillingMatrixA();
                FillingMatrixB();
                for (int i = 0; i < counterRowsA; i++)
                {
                    for (int j = 0; j < counterColumnsA; j++)
                    {
                        MatrixR[i, j] = MatrixA[i, j] + MatrixB[i, j];
                    }
                }
                WriteMatrixR();
            }
            else
            {
                MessageBox.Show("Размер матриц должен быть одинаковым. Вы можете освежить знания кликнув по кнопке «Открыть справку»",
                            "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MatrixA_Minus_MatrixB()//вычитание матриц
        {
            if (counterRowsA == counterRowsB && counterColumnsA == counterColumnsB)
            {
                FillingMatrixA();
                FillingMatrixB();
                for (int i = 0; i < counterRowsA; i++)
                {
                    for (int j = 0; j < counterColumnsA; j++)
                    {
                        MatrixR[i, j] = MatrixA[i, j] - MatrixB[i, j];
                    }
                }
                WriteMatrixR();
            }
            else
            {
                MessageBox.Show("Размер матриц должен быть одинаковым. Вы можете освежить знания кликнув по кнопке «Открыть справку»",
                            "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MatrixA_Multiplication_MatrixB()// умножение матрицы на матрицу
        {

            if (counterColumnsA == counterRowsB)
            {
                FillingMatrixA();
                FillingMatrixB();

                for (int i = 0; i < counterRowsA; i++)
                {
                    for (int j = 0; j < counterColumnsB; j++)
                    {

                        for (int k = 0; k < counterColumnsB; k++)
                        {
                            MatrixR[i, j] += MatrixA[i, k] * MatrixB[k, j];
                        }

                    }
                }

                WriteMatrixRForMult();


            }
            else
            {
                MessageBox.Show("Количество столбцов матрицы А должно равняться количеству столбцов матрицы В. Вы можете освежить знания кликнув по кнопке «Открыть справку»",
                            "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void MatrixA_Multiplication_Nums()//умножение на число
        {
            double num = Convert.ToDouble(texboxForOneNum.Text);
            FillingMatrixA();

            for (int i = 0; i < counterRowsA; i++)
            {
                for (int j = 0; j < counterColumnsA; j++)
                {

                    MatrixR[i, j] = MatrixA[i, j] * num;
                }
            }
            WriteMatrixR();

        }

        private void MatrixA_Division_Nums()// деление на число
        {
            double num = 1 / Convert.ToDouble(texboxForOneNum.Text);
            FillingMatrixA();

            for (int i = 0; i < counterRowsA; i++)
            {
                for (int j = 0; j < counterColumnsA; j++)
                {

                    MatrixR[i, j] = MatrixA[i, j] * num;
                }
            }
            WriteMatrixR();
        }

        private void Exponentiation_MatrixA()
        {
            double num = Convert.ToDouble(texboxForOneNum.Text);
            //int check = 1;
            FillingMatrixA();

            for (int i = 0; i < counterRowsA; i++)
            {
                for (int j = 0; j < counterColumnsA; j++)
                {

                    MatrixR[i, j] = Math.Pow(MatrixA[i, j], num);
                }
            }
            WriteMatrixR();
        }

        private void Extraction_MatrixA()
        {
            double num = 1 / Convert.ToDouble(texboxForOneNum.Text);
            //int check = 1;
            FillingMatrixA();

            for (int i = 0; i < counterRowsA; i++)
            {
                for (int j = 0; j < counterColumnsA; j++)
                {

                    MatrixR[i, j] = Math.Pow(MatrixA[i, j], num);
                }
            }
            WriteMatrixR();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (T_MatrixR[0, 0].Text == "")
            {
                MessageBox.Show("Результата нет. Что копировать то?",
                            "Калькулятор матриц", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string resultCopy = "";
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (T_MatrixR[i, j].Text != "")
                        {
                            resultCopy += $"{ T_MatrixR[i, j].Text} ";
                        }

                    }
                    resultCopy += "\n";
                }

                Clipboard.Clear();
                Clipboard.SetText(resultCopy);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (buttonSettings.Text == "Настройки")
            {
                this.Size = new Size(850, 455);
                buttonSettings.Text = "Скрыть настройки";
            }
            else
            {
                buttonSettings.Text = "Настройки";
                this.Size = new Size(850, 420);
            }





        }

        private void checkBoxHints_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.checkBoxHints = checkBoxHints.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBoxForDark_CheckedChanged(object sender, EventArgs e)// темная тема
        {
            Properties.Settings.Default.checkBoxForDark = checkBoxForDark.Checked;
            Properties.Settings.Default.Save();
            
            if (checkBoxForDark.Checked == true)
            {
                this.BackColor = Color.FromArgb(27, 27, 27);// форма
                

                panel3.BackColor = Color.FromArgb(49, 49, 49);// матрица а
                label3.BackColor = Color.FromArgb(49, 49, 49);
                buttonAMinusСolumn.BackColor = Color.FromArgb(60, 60, 60);
                buttonAMinusRows.BackColor = Color.FromArgb(60, 60, 60);
                buttonAPlusСolumn.BackColor = Color.FromArgb(98, 98, 98);
                buttonAPlusRows.BackColor = Color.FromArgb(98, 98, 98);
                refreshA.BackColor = Color.FromArgb(129, 129, 129);
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        arrRowsA[i, j].BackColor = Color.FromArgb(78, 78, 78);

                        arrRowsA[i, j].ForeColor = Color.FromArgb(226, 239, 234);
                    }
                }



                panel4.BackColor = Color.FromArgb(49, 49, 49);// матрица b
                label4.BackColor = Color.FromArgb(49, 49, 49);
                buttonBMinusСolumn.BackColor = Color.FromArgb(60, 60, 60);
                buttonBMinusRows.BackColor = Color.FromArgb(60, 60, 60);
                buttonBPlusСolumn.BackColor = Color.FromArgb(98, 98, 98);
                buttonBPlusRows.BackColor = Color.FromArgb(98, 98, 98);
                refreshB.BackColor = Color.FromArgb(69, 69, 69);
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        arrRowsB[i, j].BackColor = Color.FromArgb(78, 78, 78);
                        
                        arrRowsB[i, j].ForeColor = Color.FromArgb(226, 239, 234);
                    }
                }

                comboOperations.BackColor = Color.FromArgb(49, 49, 49);
                result.BackColor = Color.FromArgb(49, 49, 49);

                panel5.BackColor = Color.FromArgb(49, 49, 49);
                label5.BackColor = Color.FromArgb(49, 49, 49);
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        T_MatrixR[i, j].BackColor = Color.FromArgb(78, 78, 78);
                        
                        T_MatrixR[i, j].ForeColor = Color.FromArgb(226, 239, 234);
                    }
                }

                panelSettings.BackColor = Color.FromArgb(49, 49, 49);
                panelOperationType.BackColor = Color.FromArgb(49, 49, 49);
                labelOperationType.BackColor = Color.FromArgb(49, 49, 49);

                panel6.BackColor = Color.FromArgb(49, 49, 49);
                label6.BackColor = Color.FromArgb(49, 49, 49);

                button10.BackColor = Color.FromArgb(49, 49, 49);
                buttonSettings.BackColor = Color.FromArgb(49, 49, 49);
                onlineРelp.BackColor = Color.FromArgb(49, 49, 49);

                panelMultiplicationType.BackColor = Color.FromArgb(49, 49, 49);
                labelMultiplicationType.BackColor = Color.FromArgb(49, 49, 49);

                panelForoneNum.BackColor = Color.FromArgb(49, 49, 49);
                texboxForOneNum.BackColor = Color.FromArgb(78, 78, 78);
                texboxForOneNum.ForeColor = Color.FromArgb(226, 239, 234);
                listboxForOneNum.BackColor = Color.FromArgb(49, 49, 49);

            }




            else
            {

                this.BackColor = Color.FromArgb(1, 147, 154);// форма

                panel3.BackColor = Color.FromArgb(52, 198, 205);// матрица а
                label3.BackColor = Color.FromArgb(52, 198, 205);
                buttonAMinusСolumn.BackColor = Color.FromArgb(0, 96, 100);
                buttonAMinusRows.BackColor = Color.FromArgb(0, 96, 100);
                buttonAPlusСolumn.BackColor = Color.FromArgb(93, 200, 205);
                buttonAPlusRows.BackColor = Color.FromArgb(93, 200, 205);
                refreshA.BackColor = Color.FromArgb(29, 112, 116);
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        arrRowsA[i, j].BackColor = SystemColors.Window;
                       
                        arrRowsA[i, j].ForeColor = SystemColors.WindowText;
                    }
                }


                panel4.BackColor = Color.FromArgb(52, 198, 205);// матрица b
                label4.BackColor = Color.FromArgb(52, 198, 205);
                buttonBMinusСolumn.BackColor = Color.FromArgb(0, 96, 100);
                buttonBMinusRows.BackColor = Color.FromArgb(0, 96, 100);
                buttonBPlusСolumn.BackColor = Color.FromArgb(93, 200, 205);
                buttonBPlusRows.BackColor = Color.FromArgb(93, 200, 205);
                refreshB.BackColor = Color.FromArgb(29, 112, 116);
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        arrRowsB[i, j].BackColor = SystemColors.Window;
                        
                        arrRowsB[i, j].ForeColor = SystemColors.WindowText;
                    }
                }

                comboOperations.BackColor = Color.FromArgb(52, 198, 205);
                result.BackColor = Color.FromArgb(52, 198, 205);

                panel5.BackColor = Color.FromArgb(52, 198, 205);
                label5.BackColor = Color.FromArgb(52, 198, 205);
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        T_MatrixR[i, j].BackColor = SystemColors.Window;
                        
                        T_MatrixR[i, j].ForeColor = SystemColors.WindowText;
                    }
                }

                panelSettings.BackColor = Color.FromArgb(52, 198, 205);
                panelOperationType.BackColor = Color.FromArgb(52, 198, 205);
                labelOperationType.BackColor = Color.FromArgb(52, 198, 205);

                panel6.BackColor = Color.FromArgb(52, 198, 205);
                label6.BackColor = Color.FromArgb(52, 198, 205);
                button10.BackColor = Color.FromArgb(52, 198, 205);
                buttonSettings.BackColor =  Color.FromArgb(52, 198, 205);
                onlineРelp.BackColor = Color.FromArgb(52, 198, 205);

                panelMultiplicationType.BackColor = Color.FromArgb(52, 198, 205);
                labelMultiplicationType.BackColor = Color.FromArgb(52, 198, 205);

                panelForoneNum.BackColor = Color.FromArgb(52, 198, 205);
                texboxForOneNum.BackColor = SystemColors.Window;
                texboxForOneNum.ForeColor = SystemColors.WindowText;
                listboxForOneNum.BackColor = Color.FromArgb(52, 198, 205);


            }

        }

        
    }
            

}

    








