using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.ComponentModel.Design;

namespace Udemy_Krestik
{
    public partial class Form1 : Form
    {
        public Button button1_1;

        public Button button2_1;

        public Button button3_1;

        public System.Windows.Forms.Label labelLarS;
        
        public Form1()
        {
            
            InitializeComponent();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            buttonsM.Add(button1);
            buttonsM.Add(button3);
            buttonsM.Add(button7);
            buttonsM.Add(button9);
        }
        
        public void ResetForm()
        {
            // Очистка всех динамически добавленных элементов
            this.Controls.Clear();
            /*for(int i = 0; i<buttons.Count; i++)
            {
                buttons[i].Text="";
            }*/
            buttons.Clear();
            buttonsM.Clear();
            krestik =null;
            nol=null;
            turn=0;
            labelLar.Text=null;
            labelLarS.Text=null;
            Lar_button=null;
            // Повторный вызов InitializeComponent для возврата к исходному состоянию
            InitializeComponent();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            buttonsM.Add(button1);
            buttonsM.Add(button3);
            buttonsM.Add(button7);
            buttonsM.Add(button9);
            // Повторная привязка обработчиков событий, если необходимо
        }

        // Обработчик события Click для кнопки

        
        public void buttons_Clear()
        {
            buttons.Clear();
            buttonsM.Clear();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            buttonsM.Add(button1);
            buttonsM.Add(button3);
            buttonsM.Add(button7);
            buttonsM.Add(button9);
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
        public string krestik;
        private void button12_Click(object sender, EventArgs e)
        {
            if(krestik==null) krestik="X";
            // Создание кнопки
            button1_1 = new Button();
            // Настройка свойств кнопки
            int x = 80, y = 80;
            button1_1.Location = new System.Drawing.Point(x, y); // Устанавливаем координаты (x, y)
            button1_1.Size = new System.Drawing.Size(90, 45); // Устанавливаем размер кнопки (ширина, высота)
            button1_1.Text = "Difficulty 1"; // Устанавливаем текст кнопки
            // Подписка на событие Click
            button1_1.Click += new EventHandler(button1_1_Click);
            // Добавление кнопки на форму
            this.Controls.Add(button1_1);

            // Создание кнопки
            button2_1 = new Button();
            // Настройка свойств кнопки
            
            
            button2_1.Location = new System.Drawing.Point(x, y+84); // Устанавливаем координаты (x, y)
            button2_1.Size = new System.Drawing.Size(90, 45); // Устанавливаем размер кнопки (ширина, высота)
            button2_1.Text = "Difficulty 2"; // Устанавливаем текст кнопки
            // Подписка на событие Click
            button2_1.Click += new EventHandler(button2_1_Click);
            // Добавление кнопки на форму
            this.Controls.Add(button2_1);

            // Создание кнопки
            button3_1 = new Button();
            // Настройка свойств кнопки
            button3_1.Location = new System.Drawing.Point(80, y+168); // Устанавливаем координаты (x, y)
            button3_1.Size = new System.Drawing.Size(90, 45); // Устанавливаем размер кнопки (ширина, высота)
            button3_1.Text = "Difficulty 3"; // Устанавливаем текст кнопки
            // Подписка на событие Click
            button3_1.Click += new EventHandler(button3_1_Click);
            // Добавление кнопки на форму
            this.Controls.Add(button3_1);

            // Создание кнопки
            labelLarS = new System.Windows.Forms.Label();
            // Настройка свойств кнопки
            labelLarS.Location = new System.Drawing.Point(80, 20); // Устанавливаем координаты (x, y)
            labelLarS.Size = new System.Drawing.Size(120, 100); // Устанавливаем размер кнопки (ширина, высота)
            labelLarS.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold | FontStyle.Italic);
            labelLarS.Text = "I am Largenom\nYour opponent\nChoose my power level"; // Устанавливаем текст кнопки
            // Подписка на событие Click
            labelLarS.Click += new EventHandler(labelLar_Click);
            // Добавление кнопки на форму
            this.Controls.Add(labelLarS);
            buttons_Clear();
        }
        public enum Difficulty
        {
            notset,
            easy,
            medium,
            impossible
        }
       
        public Difficulty difficult = Difficulty.notset;
        private void button1_1_Click(object sender, EventArgs e)
        {
            difficult = Difficulty.easy;
            buttons_Clear();
        }
        private void button2_1_Click(object sender, EventArgs e)
        {
            difficult = Difficulty.medium;
            Random random = new Random();
            Largenom2number = random.Next(1, 100);
            buttons_Clear();
        }
        public int Largenom2number;
        private void button3_1_Click(object sender, EventArgs e)
        {
            difficult = Difficulty.impossible;
            buttons_Clear();
        }
        private void labelLar_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (krestik==null)  krestik="O";
            // Создание кнопки
            button1_1 = new Button();
            // Настройка свойств кнопки
            int x = 80, y = 80;
            button1_1.Location = new System.Drawing.Point(x, y); // Устанавливаем координаты (x, y)
            button1_1.Size = new System.Drawing.Size(90, 45); // Устанавливаем размер кнопки (ширина, высота)
            button1_1.Text = "Difficulty 1"; // Устанавливаем текст кнопки
            // Подписка на событие Click
            button1_1.Click += new EventHandler(button1_1_Click);
            // Добавление кнопки на форму
            this.Controls.Add(button1_1);

            // Создание кнопки
            button2_1 = new Button();
            // Настройка свойств кнопки


            button2_1.Location = new System.Drawing.Point(x, y+84); // Устанавливаем координаты (x, y)
            button2_1.Size = new System.Drawing.Size(90, 45); // Устанавливаем размер кнопки (ширина, высота)
            button2_1.Text = "Difficulty 2"; // Устанавливаем текст кнопки
            // Подписка на событие Click
            button2_1.Click += new EventHandler(button2_1_Click);
            // Добавление кнопки на форму
            this.Controls.Add(button2_1);

            // Создание кнопки
            button3_1 = new Button();
            // Настройка свойств кнопки
            button3_1.Location = new System.Drawing.Point(80, y+168); // Устанавливаем координаты (x, y)
            button3_1.Size = new System.Drawing.Size(90, 45); // Устанавливаем размер кнопки (ширина, высота)
            button3_1.Text = "Difficulty 3"; // Устанавливаем текст кнопки
            // Подписка на событие Click
            button3_1.Click += new EventHandler(button3_1_Click);
            // Добавление кнопки на форму
            this.Controls.Add(button3_1);
            
                // Создание Label
                labelLarS = new System.Windows.Forms.Label();
                // Настройка свойств кнопки
                labelLarS.Location = new System.Drawing.Point(80, 20); // Устанавливаем координаты (x, y)
                labelLarS.Size = new System.Drawing.Size(120, 100); // Устанавливаем размер кнопки (ширина, высота)
                labelLarS.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold | FontStyle.Italic);
                labelLarS.Text = "I am Largenom\nYour opponent\nChoose my power level"; // Устанавливаем текст кнопки
                                                                                        // Подписка на событие Click
                labelLarS.Click += new EventHandler(labelLar_Click);
                // Добавление кнопки на форму
                this.Controls.Add(labelLarS);
            
            buttons_Clear();
        }
        public List<Button> buttons = new List<Button>();
        public List<Button> buttonsM = new List<Button>();
        public void crLabel()
        {
            if (labelLar.Text == null || labelLar.Text=="")
            {
                //labelLar = new System.Windows.Forms.Label();
                // Настройка свойств кнопки
                labelLar.Location = new System.Drawing.Point(600, 72); // Устанавливаем координаты (x, y)
                labelLar.Size = new System.Drawing.Size(150, 100); // Устанавливаем размер кнопки (ширина, высота)
                labelLar.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold | FontStyle.Italic);
                String win = "You beat me, human";
                this.Controls.Add(labelLar);
                labelLar.Click += new EventHandler(labelLar_Click);
                foreach (char w in win)
                {
                    labelLar.Text+= w;

                    //Thread.Sleep(10);
                    buttons_Clear();
                }
            }
        }
        public System.Windows.Forms.Label labelLar = new System.Windows.Forms.Label();
        public void larLabel()
        {
            if (labelLar.Text == null || labelLar.Text=="")
            {
                //labelLar = new System.Windows.Forms.Label();
                // Настройка свойств кнопки
                labelLar.Location = new System.Drawing.Point(600, 72); // Устанавливаем координаты (x, y)
                labelLar.Size = new System.Drawing.Size(150, 100); // Устанавливаем размер кнопки (ширина, высота)
                labelLar.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold | FontStyle.Italic);
                String win = "I won, weakling";
                this.Controls.Add(labelLar);
                labelLar.Click += new EventHandler(labelLar_Click);
                foreach (char w in win)
                {
                    labelLar.Text+= w;

                    //Thread.Sleep(10);
                    buttons_Clear();
                }
            }
        }
        public void larNLabel()
        {
            if (labelLar.Text == null || labelLar.Text=="")
            {
                labelLar = new System.Windows.Forms.Label();
                // Настройка свойств кнопки
                labelLar.Location = new System.Drawing.Point(600, 72); // Устанавливаем координаты (x, y)
                labelLar.Size = new System.Drawing.Size(150, 100); // Устанавливаем размер кнопки (ширина, высота)
                labelLar.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold | FontStyle.Italic);
                String win = "Draw, bag of bones";
                this.Controls.Add(labelLar);
                labelLar.Click += new EventHandler(labelLar_Click);
                foreach (char w in win)
                {
                    labelLar.Text+= w;

                    //Thread.Sleep(10);
                    buttons_Clear();
                }
            }
        }
        public String nol;
        public void Largenom()
        {
            if (difficult==Difficulty.easy) Largenom1();
            else if (difficult==Difficulty.medium) Largenom2();
            else if (difficult==Difficulty.impossible) Largenom3();
            else
            {
                MessageBox.Show("Choose a difficulty, organic trash");
                ResetForm();
            }
            buttons_Clear();
        }
        public void Largenom1()
        {
            Random random = new Random();
            int i = random.Next(1, 10);
            for (int j = 0; j<=999; j++)
            {
                /*buttons[0].Text="O";
                InvokeMethodByName(buttons[j].Name);
                buttons[1].Text="O";
                InvokeMethodByName(buttons[j].Name);
                buttons[2].Text="O";
                InvokeMethodByName(buttons[j].Name);
                j=999;*/

                if (buttons[i-1].Text=="")
                {
                    buttons[i-1].Text=nol;
                    InvokeMethodByName(buttons[i-1].Name);
                    j=999;
                }
                else i = random.Next(1, 10);
            }
            buttons_Clear();
        }
        public void Largenom2()
        {
            Random random = new Random();
            if (turn==5) Largenom3_5();
            int j = random.Next(1, 100);
            if (j>Largenom2number)
            {

                int a = random.Next(1, 10);
                for (int b = 0; b<=999; b++)
                {
                    /*buttons[0].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    buttons[1].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    buttons[2].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    j=999;*/

                    if (buttons[a-1].Text=="")
                    {
                        if (turn==2 && (buttons[a-1]==button1 || buttons[a-1]==button3 || buttons[a-1]==button7 || buttons[a-1]==button9)) Lar_button=buttons[a-1];
                        buttons[a-1].Text=nol;
                        InvokeMethodByName(buttons[a-1].Name);
                        b=999;
                    }
                    else a = random.Next(1, 10);
                }
            }
            else if (j<Largenom2number)
            {
                Largenom3();
            }
            buttons_Clear();
        }
        public bool Larbutton;
        public void Largenom3()
        {
            if (turn==1) Largenom3_1();
            else if (turn==2) Largenom3_2();
            else if (turn==3) Largenom3_3();
            else if (turn==4) Largenom3_4();
            else if (turn==5) Largenom3_5();
            buttons_Clear();
        }
        public void Largenom3_1()
        {
            if (buttons[4].Text=="") buttons[4].Text=nol;
            else Largenom3_2();
            buttons_Clear();
        }
        public Button Lar_button;
        public void Largenom3_2()
        {
            HashSet<int> generatedNumbers = new HashSet<int>();
            label3.Text=null;
            for (int i = 0; i<9999; i++)
            {
                
                Random random = new Random();
                int j = random.Next(0, 4);
                label3.Text+="";
                if (!generatedNumbers.Contains(j))
                {
                    InvokeMethodByNameCheck1(buttonsM[j].Name);
                    if (Larbutton==true)
                    {
                        InvokeMethodByName(buttonsM[j].Name);
                        Lar_button=buttonsM[j];
                        buttonsM[j].Text=nol;
                        break;
                    }
                    generatedNumbers.Add(j);
                    if (generatedNumbers.Count>=4)
                    {
                        generatedNumbers.Clear();
                        break;
                    }
                }
            }
            for (int i = 0; i<9999; i++)
            {
                if (Lar_button!=null) break;
                Random random = new Random();
                int j = random.Next(0, 4);
                label3.Text+="";
                if (!generatedNumbers.Contains(j))
                {
                    InvokeMethodByNameCheck2(buttonsM[j].Name);
                    if (Larbutton==true)
                    {
                        InvokeMethodByName(buttonsM[j].Name);
                        Lar_button=buttonsM[j];
                        buttonsM[j].Text=nol;
                        break;
                    }
                    generatedNumbers.Add(j);
                    if (generatedNumbers.Count>=4)
                    {
                        generatedNumbers.Clear();
                        break;
                    }
                }
            }
            for (int i = 0; i<9999; i++)
            {
                if (Lar_button!=null) break;
                Random random = new Random();
                int j = random.Next(0, 4);
               label3.Text+="";
                if (!generatedNumbers.Contains(j))
                {
                    InvokeMethodByNameCheck3(buttonsM[j].Name);
                    if (Larbutton==true)
                    {
                        InvokeMethodByName(buttonsM[j].Name);
                        Lar_button=buttonsM[j];
                        buttonsM[j].Text=nol;
                        break;
                    }
                    generatedNumbers.Add(j);
                    if (generatedNumbers.Count>=4)
                    {
                        generatedNumbers.Clear();
                        break;
                    }
                }
            }
            for (int i = 0; i<9999; i++)
            {
                if (Lar_button!=null) break;
                Random random = new Random();
                int j = random.Next(0, 4);
                label3.Text+=" ";
                if (!generatedNumbers.Contains(j))
                {
                    InvokeMethodByNameCheck4(buttonsM[j].Name);
                    if (Larbutton==true)
                    {
                        InvokeMethodByName(buttonsM[j].Name);
                        Lar_button=buttonsM[j];
                        buttonsM[j].Text=nol;
                        break;
                    }
                    generatedNumbers.Add(j);
                    if (generatedNumbers.Count>=4)
                    {
                        generatedNumbers.Clear();
                        break;
                    }
                }
            }
            if (Lar_button==null)
            {
                Random random = new Random();
                int i = random.Next(1, 5);
                for (int j = 0; j<=999; j++)
                {
                    /*buttons[0].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    buttons[1].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    buttons[2].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    j=999;*/

                    if (buttons[i-1].Text=="" && (i==7 || i==1 || i==3 || i==9))
                    {
                        buttons[i-1].Text=nol;
                        InvokeMethodByName(buttons[i-1].Name);
                        Lar_button =buttons[i-1];
                        j=999;
                    }
                    else i = random.Next(1, 10);
                }
                buttons_Clear();
            }
        }
        public void Largenom3_3()
        {
            if (Lar_button!=null) InvokeMethodByNameLar_Button(Lar_button.Name);
            else Largenom3_2();
            buttons_Clear();
        }
        public void Largenom3_4()
        {
            if (Lar_button!=null) InvokeMethodByNameLar_Button(Lar_button.Name);
            else Largenom3_2();
            buttons_Clear();
        }
        public void Largenom3_5()
        {
            larNLabel();
        }
        public int turn=0;
        public void InvokeMethodByName(string buttonName)
        {
            string methodName = buttonName + "Lar_Click";

            // Используем рефлексию для поиска и вызова метода по имени
            MethodInfo method = this.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            if (method != null)
            {
                method.Invoke(this, null); // Вызов метода
            }
            else
            {
                MessageBox.Show($"Method {methodName} not found.");
            }
            buttons_Clear();
        }
        public void InvokeMethodByNameCheck1(string buttonName)
        {
            string methodName = buttonName + "Lar_Check1";

            // Используем рефлексию для поиска и вызова метода по имени
            MethodInfo method = this.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            if (method != null)
            {
                method.Invoke(this, null); // Вызов метода
            }
            else
            {
                MessageBox.Show($"Method {methodName} not found.");
            }
            buttons_Clear();
        }
        public void InvokeMethodByNameCheck2(string buttonName)
        {
            string methodName = buttonName + "Lar_Check2";

            // Используем рефлексию для поиска и вызова метода по имени
            MethodInfo method = this.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            if (method != null)
            {
                method.Invoke(this, null); // Вызов метода
            }
            else
            {
                MessageBox.Show($"Method {methodName} not found.");
            }
            buttons_Clear();
        }
        public void InvokeMethodByNameCheck3(string buttonName)
        {
            string methodName = buttonName + "Lar_Check3";

            // Используем рефлексию для поиска и вызова метода по имени
            MethodInfo method = this.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            if (method != null)
            {
                method.Invoke(this, null); // Вызов метода
            }
            else
            {
                MessageBox.Show($"Method {methodName} not found.");
            }
            buttons_Clear();
        }
        public void InvokeMethodByNameCheck4(string buttonName)
        {
            string methodName = buttonName + "Lar_Check4";

            // Используем рефлексию для поиска и вызова метода по имени
            MethodInfo method = this.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            if (method != null)
            {
                method.Invoke(this, null); // Вызов метода
            }
            else
            {
                MessageBox.Show($"Method {methodName} not found.");
            }
            buttons_Clear();
        }
        public void InvokeMethodByNameLar_Button(string buttonName)
        {
            string methodName = buttonName + "Lar_Button";

            // Используем рефлексию для поиска и вызова метода по имени
            MethodInfo method = this.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            if (method != null)
            {
                method.Invoke(this, null); // Вызов метода
            }
            else
            {
                MessageBox.Show($"Method {methodName} not found.");
            }
            buttons_Clear();
        }
        public void button1Lar_Click()
        {
            if (((button1.Text==button2.Text && button2.Text==button3.Text) || (button1.Text==button4.Text && button4.Text==button7.Text) || (button1.Text==button5.Text && button5.Text==button9.Text)) && button1.Text!="")
            {
                larLabel();
                
            }
            buttons_Clear();
        }
        public void button1Lar_Button()
        {
            
            if ((button5.Text=="" || button5.Text==nol) && (button9.Text=="" || button9.Text==nol))
            {
                if (button9.Text=="") { button9.Text=nol;InvokeMethodByName(button9.Name); }
                else { button5.Text=nol; InvokeMethodByName(button5.Name); }
            }
            else if ((button2.Text=="" || button2.Text==nol) && (button3.Text=="" || button3.Text==nol)) {
                if (button3.Text=="") { button3.Text=nol; InvokeMethodByName(button3.Name); }
                else { button2.Text=nol; InvokeMethodByName(button2.Name); }
            }
            else if ((button4.Text=="" || button4.Text==nol) && (button7.Text=="" || button7.Text==nol))
            {
                if (button7.Text=="") { button7.Text=nol; InvokeMethodByName(button7.Name); }
                else { button4.Text=nol; InvokeMethodByName(button4.Name); }
            }
            else
            {
                Random random = new Random();
                int i = random.Next(1, 10);
                for (int j = 0; j<=999; j++)
                {
                    /*buttons[0].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    buttons[1].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    buttons[2].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    j=999;*/

                    if (buttons[i-1].Text=="")
                    {
                        buttons[i-1].Text=nol;
                        InvokeMethodByName(buttons[i-1].Name);
                        j=999;
                    }
                    else i = random.Next(1, 10);
                }
            }

            buttons_Clear();
        }
        public void button1Lar_Check1()
        {
            Larbutton=false;
            if (((button1.Text==button2.Text && button2.Text==button3.Text) && (button1.Text==button4.Text && button4.Text==button7.Text) && (button1.Text==button5.Text && button5.Text==button9.Text)) && button1.Text=="")
            {
                Larbutton=true;

            }

            buttons_Clear();
        }
        public void button1Lar_Check2()
        {
            Larbutton=false;
            if (((button1.Text==button2.Text && button2.Text==button3.Text) && (button1.Text==button4.Text && button4.Text==button7.Text) || (button1.Text==button5.Text && button5.Text==button9.Text)) && button1.Text=="")
            {
                Larbutton=true;

            }

            buttons_Clear();
        }
        public void button1Lar_Check3()
        {
            Larbutton=false;
            if (((button1.Text==button2.Text && button2.Text==button3.Text) || (button1.Text==button4.Text && button4.Text==button7.Text) && (button1.Text==button5.Text && button5.Text==button9.Text)) && button1.Text=="")
            {
                Larbutton=true;

            }

            buttons_Clear();
        }
        public void button1Lar_Check4()
        {
            Larbutton=false;
            if (((button1.Text==button2.Text && button2.Text==button3.Text) || (button1.Text==button4.Text && button4.Text==button7.Text) || (button1.Text==button5.Text && button5.Text==button9.Text)) && button1.Text=="")
            {
                Larbutton=true;

            }

            buttons_Clear();
        }
        private void button1_Click(object sender, EventArgs e)
            {

                if (button1.Text=="" && (krestik=="X" || krestik=="O"))
                {
                    button1.Text=krestik;
                    if (krestik=="X") nol="O";
                    else nol="X";
                turn++;
                
                }
                if (((button1.Text==button2.Text && button2.Text==button3.Text) || (button1.Text==button4.Text && button4.Text==button7.Text) || (button1.Text==button5.Text && button5.Text==button9.Text)) && button1.Text!="")
                {
                    crLabel();
                    // Добавление кнопки на форму
                    //this.Controls.Add(labelLar);
                }
            Largenom();
            buttons_Clear();
        }
        public void button2Lar_Click()
        {
            if (((button1.Text==button2.Text && button2.Text==button3.Text) || (button2.Text==button5.Text && button5.Text==button8.Text)) && button2.Text!="")
            {

                larLabel();
                // Добавление кнопки на форму
                //this.Controls.Add(labelLar);
            }
            buttons_Clear();
        }
        private void button2_Click(object sender, EventArgs e)
            {
            if (button2.Text=="" && (krestik=="X" || krestik=="O"))
                {
                    button2.Text=krestik;
                    if (krestik=="X") nol="O";
                    else nol="X";
                turn++; 
                
                }
                if (((button1.Text==button2.Text && button2.Text==button3.Text) || (button2.Text==button5.Text && button5.Text==button8.Text)) && button2.Text!="")
                {

                    crLabel();
                    // Добавление кнопки на форму
                    //this.Controls.Add(labelLar);
                }
            Largenom();
            buttons_Clear();
        }
        public void button3Lar_Click()
        {

            if (((button3.Text==button2.Text && button2.Text==button1.Text) || (button3.Text==button6.Text && button6.Text==button9.Text) || (button3.Text==button5.Text && button5.Text==button7.Text)) && button3.Text!="")
            {
                larLabel();
                // Добавление кнопки на форму
                //this.Controls.Add(labelLar);
            }
            buttons_Clear();
        }
        public void button3Lar_Check1()
        {
            Larbutton=false;
            if (((button3.Text==button2.Text && button2.Text==button1.Text) && (button3.Text==button6.Text && button6.Text==button9.Text) && (button3.Text==button5.Text && button5.Text==button7.Text)) && button3.Text=="")
            {
                Larbutton=true;
            }

            buttons_Clear();
        }
        public void button3Lar_Check2()
        {
            Larbutton=false;
            if (((button3.Text==button2.Text && button2.Text==button1.Text) && (button3.Text==button6.Text && button6.Text==button9.Text) || (button3.Text==button5.Text && button5.Text==button7.Text)) && button3.Text=="")
            {
                Larbutton=true;
            }

            buttons_Clear();
        }
        public void button3Lar_Check3()
        {
            Larbutton=false;
            if (((button3.Text==button2.Text && button2.Text==button1.Text) || (button3.Text==button6.Text && button6.Text==button9.Text) && (button3.Text==button5.Text && button5.Text==button7.Text)) && button3.Text=="")
            {
                Larbutton=true;
            }

            buttons_Clear();
        }
        public void button3Lar_Check4()
        {
            Larbutton=false;
            if (((button3.Text==button2.Text && button2.Text==button1.Text) || (button3.Text==button6.Text && button6.Text==button9.Text) || (button3.Text==button5.Text && button5.Text==button7.Text)) && button3.Text=="")
            {
                Larbutton=true;
            }

            buttons_Clear();
        }
        public void button3Lar_Button()
        {

            if ((button5.Text=="" || button5.Text==nol) && (button7.Text=="" || button7.Text==nol))
            {
                if (button7.Text=="") { button7.Text=nol; InvokeMethodByName(button7.Name); }
                else { button5.Text=nol; InvokeMethodByName(button5.Name); }
            }
            else if ((button2.Text=="" || button2.Text==nol) && (button1.Text=="" || button1.Text==nol))
            {
                if (button1.Text=="") { button1.Text=nol; InvokeMethodByName(button1.Name); }
                else { button2.Text=nol; InvokeMethodByName(button2.Name); }
            }
            else if ((button6.Text=="" || button6.Text==nol) && (button9.Text=="" || button9.Text==nol))
            {
                if (button9.Text=="") { button9.Text=nol; InvokeMethodByName(button9.Name); }
                else { button6.Text=nol; InvokeMethodByName(button6.Name); }
            }
            else
            {
                Random random = new Random();
                int i = random.Next(1, 10);
                for (int j = 0; j<=999; j++)
                {
                    /*buttons[0].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    buttons[1].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    buttons[2].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    j=999;*/

                    if (buttons[i-1].Text=="")
                    {
                        buttons[i-1].Text=nol;
                        InvokeMethodByName(buttons[i-1].Name);
                        j=999;
                    }
                    else i = random.Next(1, 10);
                }
            }
            buttons_Clear();
        }
        private void button3_Click(object sender, EventArgs e)
            {
            if (button3.Text=="" && (krestik=="X" || krestik=="O"))
                {
                    button3.Text=krestik;
                    if (krestik=="X") nol="O";
                    else nol="X";
                turn++;
                
                }
                if (((button3.Text==button2.Text && button2.Text==button1.Text) || (button3.Text==button6.Text && button6.Text==button9.Text) || (button3.Text==button5.Text && button5.Text==button7.Text)) && button3.Text!="")
                {
                    crLabel();
                    // Добавление кнопки на форму
                    //this.Controls.Add(labelLar);
                }
            Largenom();
            buttons_Clear();
        }
        public void button4Lar_Click()
        {
            if (((button4.Text==button5.Text && button5.Text==button6.Text) || (button4.Text==button7.Text && button7.Text==button1.Text)) && button4.Text!="")
            {
                larLabel();
                // Добавление кнопки на форму
                //this.Controls.Add(labelLar);
            }
            buttons_Clear();
        }
        private void button4_Click(object sender, EventArgs e)
            {
            if (button4.Text=="" && (krestik=="X" || krestik=="O"))
                {
                    button4.Text=krestik;
                    if (krestik=="X") nol="O";
                    else nol="X";
                turn++;
                
                }
                if (((button4.Text==button5.Text && button5.Text==button6.Text) || (button4.Text==button7.Text && button7.Text==button1.Text)) && button4.Text!="")
                {
                    crLabel();
                    // Добавление кнопки на форму
                    //this.Controls.Add(labelLar);
                }
            Largenom();
            buttons_Clear();
        }
        public void button5Lar_Click()
        {
            if (((button5.Text==button6.Text && button5.Text == button4.Text) || (button5.Text==button8.Text && button8.Text==button2.Text) || (button5.Text==button1.Text && button1.Text==button9.Text)|| (button5.Text==button7.Text && button7.Text==button3.Text)) && button5.Text!="")
            {
                larLabel();
                // Добавление кнопки на форму
                //this.Controls.Add(labelLar);
            }
            buttons_Clear();
        }
        private void button5_Click(object sender, EventArgs e)
            {
            if (button5.Text=="" && (krestik=="X" || krestik=="O"))
                {
                    button5.Text=krestik;
                    if (krestik=="X") nol="O";
                    else nol="X";
                turn++;
                
                }
                if (((button5.Text==button6.Text && button5.Text == button4.Text) || (button5.Text==button8.Text && button8.Text==button2.Text) || (button5.Text==button1.Text && button1.Text==button9.Text)|| (button5.Text==button7.Text && button7.Text==button3.Text)) && button5.Text!="")
                {
                    crLabel();
                    // Добавление кнопки на форму
                    //this.Controls.Add(labelLar);
                }
            Largenom();
            buttons_Clear();
        }
        public void button6Lar_Click()
        {
            if (((button6.Text==button5.Text && button5.Text==button4.Text) || (button6.Text==button3.Text && button3.Text==button9.Text)) && button6.Text!="")
            {
                larLabel();
                // Добавление кнопки на форму
                //this.Controls.Add(labelLar);
            }
            buttons_Clear();
        }
        private void button6_Click(object sender, EventArgs e)
            {
            if (button6.Text=="" && (krestik=="X" || krestik=="O"))
                {
                    button6.Text=krestik;
                    if (krestik=="X") nol="O";
                    else nol="X";
                turn++;
                
                }
                if (((button6.Text==button5.Text && button5.Text==button4.Text) || (button6.Text==button3.Text && button3.Text==button9.Text)) && button6.Text!="")
                {
                    crLabel();
                    // Добавление кнопки на форму
                    //this.Controls.Add(labelLar);
                }
            Largenom();
            buttons_Clear();
        }
        public void button7Lar_Click()
        {
            if (((button7.Text==button8.Text && button8.Text==button9.Text) || (button7.Text==button4.Text && button4.Text==button1.Text) || (button7.Text==button5.Text && button5.Text==button3.Text)) && button7.Text!="")
            {
                larLabel();
                // Добавление кнопки на форму
                //this.Controls.Add(labelLar);
            }
            buttons_Clear();
        }
        public void button7Lar_Check1()
        {
            Larbutton=false;
            if (((button7.Text==button8.Text && button8.Text==button9.Text) && (button7.Text==button4.Text && button4.Text==button1.Text) && (button7.Text==button5.Text && button5.Text==button2.Text)) && button7.Text=="")
            {
                Larbutton=true;
            }

            buttons_Clear();
        }
        public void button7Lar_Check2()
        {
            Larbutton=false;
            if (((button7.Text==button8.Text && button8.Text==button9.Text) && (button7.Text==button4.Text && button4.Text==button1.Text) || (button7.Text==button5.Text && button5.Text==button2.Text)) && button7.Text=="")
            {
                Larbutton=true;
            }

            buttons_Clear();
        }
        public void button7Lar_Check3()
        {
            Larbutton=false;
            if (((button7.Text==button8.Text && button8.Text==button9.Text) || (button7.Text==button4.Text && button4.Text==button1.Text) && (button7.Text==button5.Text && button5.Text==button2.Text)) && button7.Text=="")
            {
                Larbutton=true;
            }

            buttons_Clear();
        }
        public void button7Lar_Check4()
        {
            Larbutton=false;
            if (((button7.Text==button8.Text && button8.Text==button9.Text) || (button7.Text==button4.Text && button4.Text==button1.Text) || (button7.Text==button5.Text && button5.Text==button2.Text)) && button7.Text=="")
            {
                Larbutton=true;
            }

            buttons_Clear();
        }
        public void button7Lar_Button()
        {
            if ((button5.Text=="" || button5.Text==nol) && (button3.Text=="" || button3.Text==nol))
            {
                if (button3.Text=="") { button3.Text=nol; InvokeMethodByName(button3.Name); }
                else { button5.Text=nol; InvokeMethodByName(button5.Name); }
            }
            else if ((button4.Text=="" || button4.Text==nol) && (button1.Text=="" || button1.Text==nol))
            {
                if (button1.Text=="") { button1.Text=nol; InvokeMethodByName(button1.Name); }
                else { button4.Text=nol; InvokeMethodByName(button4.Name); }
            }
            else if ((button8.Text=="" || button8.Text==nol) && (button9.Text=="" || button9.Text==nol))
            {
                if (button8.Text=="") { button8.Text=nol; InvokeMethodByName(button8.Name); }
                else { button9.Text=nol; InvokeMethodByName(button9.Name); }
            }
            else
            {
                Random random = new Random();
                int i = random.Next(1, 10);
                for (int j = 0; j<=999; j++)
                {
                    /*buttons[0].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    buttons[1].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    buttons[2].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    j=999;*/

                    if (buttons[i-1].Text=="")
                    {
                        buttons[i-1].Text=nol;
                        InvokeMethodByName(buttons[i-1].Name);
                        j=999;
                    }
                    else i = random.Next(1, 10);
                }
            }
            buttons_Clear();
        }
        private void button7_Click(object sender, EventArgs e)
            {
            
            if (button7.Text=="" && (krestik=="X" || krestik=="O"))
                {
                    button7.Text=krestik;
                    if (krestik=="X") nol="O";
                    else nol="X";
                turn++;
                
                }
                if (((button7.Text==button8.Text && button8.Text==button9.Text) || (button7.Text==button4.Text && button4.Text==button1.Text) || (button7.Text==button5.Text && button5.Text==button2.Text)) && button7.Text!="")
                {
                    crLabel();
                    // Добавление кнопки на форму
                    //this.Controls.Add(labelLar);
                }
            Largenom();
            buttons_Clear();
        }
        public void button8Lar_Click()
        {
            if (((button8.Text==button7.Text && button7.Text==button9.Text) || (button8.Text==button5.Text && button5.Text==button2.Text)) && button8.Text!="")
            {
                larLabel();
                // Добавление кнопки на форму
                //this.Controls.Add(labelLar);
            }
            buttons_Clear();
        }
        private void button8_Click(object sender, EventArgs e)
            {
            if (button8.Text=="" && (krestik=="X" || krestik=="O"))
                {
                    button8.Text=krestik;
                    if (krestik=="X") nol="O";
                    else nol="X";
                turn++;
                
                }
                if (((button8.Text==button7.Text && button7.Text==button9.Text) || (button8.Text==button5.Text && button5.Text==button2.Text)) && button8.Text!="")
                {
                    crLabel();
                    // Добавление кнопки на форму
                    //this.Controls.Add(labelLar);
                }
            Largenom();
            buttons_Clear();
        }
        public void button9Lar_Click()
        {
            if (((button9.Text==button8.Text && button8.Text==button7.Text) || (button9.Text==button6.Text && button6.Text==button3.Text) || (button9.Text==button5.Text && button5.Text==button1.Text)) && button9.Text!="")
            {
                larLabel();
                // Добавление кнопки на форму
                //this.Controls.Add(labelLar);
            }
            buttons_Clear();
        }
        public void button9Lar_Check1()
        {
            Larbutton=false;
            if (((button9.Text==button8.Text && button8.Text==button7.Text) && (button9.Text==button6.Text && button6.Text==button3.Text) && (button9.Text==button5.Text && button5.Text==button1.Text)) && button9.Text=="")
            {
                Larbutton=true;
            }

            buttons_Clear();
        }
        public void button9Lar_Check2()
        {
            Larbutton=false;
            if (((button9.Text==button8.Text && button8.Text==button7.Text) && (button9.Text==button6.Text && button6.Text==button3.Text) || (button9.Text==button5.Text && button5.Text==button1.Text)) && button9.Text=="")
            {
                Larbutton=true;
            }

            buttons_Clear();
        }
        public void button9Lar_Check3()
        {
            Larbutton=false;
            if (((button9.Text==button8.Text && button8.Text==button7.Text) || (button9.Text==button6.Text && button6.Text==button3.Text) && (button9.Text==button5.Text && button5.Text==button1.Text)) && button9.Text=="")
            {
                Larbutton=true;
            }

            buttons_Clear();
        }
        public void button9Lar_Check4()
        {
            Larbutton=false;
            if (((button9.Text==button8.Text && button8.Text==button7.Text) || (button9.Text==button6.Text && button6.Text==button3.Text) || (button9.Text==button5.Text && button5.Text==button1.Text)) && button9.Text=="")
            {
                Larbutton=true;
            }

            buttons_Clear();
        }
        public void button9Lar_Button()
        {
            if ((button5.Text=="" || button5.Text==nol) && (button1.Text=="" || button1.Text==nol))
            {
                if (button5.Text=="") { button5.Text=nol; InvokeMethodByName(button5.Name); }
                else { button1.Text=nol; InvokeMethodByName(button1.Name); }
            }
            else if ((button6.Text=="" || button6.Text==nol) && (button3.Text=="" || button3.Text==nol))
            {
                if (button3.Text=="") { button3.Text=nol; InvokeMethodByName(button3.Name); }
                else button6.Text=nol;
            }
            else if ((button7.Text=="" || button7.Text==nol) && (button8.Text=="" || button8.Text==nol))
            {
                if (button7.Text=="") { button7.Text=nol; InvokeMethodByName(button7.Name); }
                else { button8.Text=nol; InvokeMethodByName(button8.Name); }
            }
            else
            {
                Random random = new Random();
                int i = random.Next(1, 10);
                for (int j = 0; j<=999; j++)
                {
                    /*buttons[0].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    buttons[1].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    buttons[2].Text="O";
                    InvokeMethodByName(buttons[j].Name);
                    j=999;*/

                    if (buttons[i-1].Text=="")
                    {
                        buttons[i-1].Text=nol;
                        InvokeMethodByName(buttons[i-1].Name);
                        j=999;
                    }
                    else i = random.Next(1, 10);
                }
            }
            buttons_Clear();
        }
        private void button9_Click(object sender, EventArgs e)
            {
            if (button9.Text=="" && (krestik=="X" || krestik=="O"))
                {
                    button9.Text=krestik;
                    if (krestik=="X") nol="O";
                    else nol="X";
                turn++;
                
                }
                if (((button9.Text==button8.Text && button8.Text==button7.Text) || (button9.Text==button6.Text && button6.Text==button3.Text) || (button9.Text==button5.Text && button5.Text==button1.Text)) && button9.Text!="")
                {
                    crLabel();
                    // Добавление кнопки на форму
                    //this.Controls.Add(labelLar);
                }
            Largenom();
            buttons_Clear();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
