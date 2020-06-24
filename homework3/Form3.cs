using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework3
{
    public partial class Form3 : Form
    {
        Panel panel;
        Button btn, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn10, btn11, btn12;
        Form form;
        ListBox lbox2, lbox3;
        RichTextBox rtbox, rtbox2;
        public int i = 0;
        public int ii = 0;

        public Form3()
        {
            this.Text = "Расписание";
            this.Size = new Size(650, 350);
            this.BackColor = Color.NavajoWhite;
            this.Font = new Font("Arial", 12);

            lbox2 = new ListBox();
            lbox2.Width = 100;

            lbox2.Items.Add("Понедельник");
            lbox2.Items.Add("Вторник");
            lbox2.Items.Add("Среда");
            lbox2.Items.Add("Четверг");
            lbox2.Items.Add("Пятница");
            lbox2.Items.Add("Суббота");
            lbox2.Items.Add("Воскресенье");

            lbox2.Location = new Point(135, 10);
            lbox2.Height = 160;
            lbox2.Width = 110;
            lbox2.BorderStyle = BorderStyle.Fixed3D;

            lbox3 = new ListBox();
            lbox3.Location = new Point(325, 10);
            lbox3.Height = 160;
            lbox3.Width = 160;
            lbox3.BorderStyle = BorderStyle.Fixed3D;
            lbox3.Width = 100;
            panel = new Panel();
            panel.Dock = DockStyle.Right;
            panel.BackColor = Color.GhostWhite;
            panel.Width = 635;
            panel.Height = 400;

            rtbox = new RichTextBox();

            rtbox.WordWrap = true;
            rtbox.BorderStyle = BorderStyle.Fixed3D;

            rtbox.Size = new Size(200, 130);
            rtbox.Location = new Point(310, 170);


            rtbox2 = new RichTextBox();

            rtbox2.WordWrap = true;
            rtbox2.BorderStyle = BorderStyle.Fixed3D;

            rtbox2.Size = new Size(200, 130);
            rtbox2.Location = new Point(105, 170);

            Button btn5 = new Button();
            btn5.Text = "Очистить";
            btn5.Location = new Point(515, 170);
            btn5.ForeColor = Color.Navy;
            btn5.BackColor = Color.NavajoWhite;
            btn5.Width = 100;
            btn5.Height = 30;


            Button btn6 = new Button();
            btn6.Text = "Открыть";
            btn6.Location = new Point(515, 200);
            btn6.ForeColor = Color.Navy;
            btn6.BackColor = Color.NavajoWhite;
            btn6.Width = 100;
            btn6.Height = 30;

            Button btn7 = new Button();
            btn7.Text = "Сохранить";
            btn7.Location = new Point(515, 230);
            btn7.ForeColor = Color.Navy;
            btn7.BackColor = Color.NavajoWhite;
            btn7.Width = 100;
            btn7.Height = 30;



            Button btn10 = new Button();
            btn10.Text = "Очистить";
            btn10.Location = new Point(5, 170);
            btn10.ForeColor = Color.Navy;
            btn10.BackColor = Color.NavajoWhite;
            btn10.Width = 100;
            btn10.Height = 30;


            Button btn11 = new Button();
            btn11.Text = "Открыть";
            btn11.Location = new Point(5, 200);
            btn11.ForeColor = Color.Navy;
            btn11.BackColor = Color.NavajoWhite;
            btn11.Width = 100;
            btn11.Height = 30;

            Button btn12 = new Button();
            btn12.Text = "Сохранить";
            btn12.Location = new Point(5, 230);
            btn12.ForeColor = Color.Navy;
            btn12.BackColor = Color.NavajoWhite;
            btn12.Width = 100;
            btn12.Height = 30;



            Button btn8 = new Button();
            btn8.Text = "Добавить";
            btn8.Location = new Point(515, 50);
            btn8.ForeColor = Color.Navy;
            btn8.BackColor = Color.NavajoWhite;
            btn8.Width = 100;
            btn8.Height = 30;

            Button btn9 = new Button();
            btn9.Text = "Удалить";
            btn9.Location = new Point(515, 85);
            btn9.ForeColor = Color.Navy;
            btn9.BackColor = Color.NavajoWhite;
            btn9.Width = 100;
            btn9.Height = 30;


            btn5.Click += Btn5_Click;
            btn7.Click += Btn7_Click;
            btn6.Click += Btn6_Click;
            btn8.Click += Btn8_Click;
            btn9.Click += Btn9_Click;
            btn10.Click += Btn10_Click;
            btn11.Click += Btn11_Click;
            btn12.Click += Btn12_Click;

            lbox2.DoubleClick += LBox2_DoubleClick;
            lbox3.SelectedIndexChanged += Lbox3_SelectedIndexChanged;
            lbox3.DoubleClick += Lbox3_DoubleClick;
            lbox2.SelectedIndexChanged += LBox2_SelectedIndexChanged;



            Controls.Add(panel);
            panel.Controls.Add(lbox2);
            panel.Controls.Add(lbox3);
            panel.Controls.Add(rtbox);
            panel.Controls.Add(rtbox2);
            panel.Controls.Add(btn5);
            panel.Controls.Add(btn6);
            panel.Controls.Add(btn7);
            panel.Controls.Add(btn8);
            panel.Controls.Add(btn9);
            panel.Controls.Add(btn10);
            panel.Controls.Add(btn11);
            panel.Controls.Add(btn12);
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            rtbox2.SaveFile("..//..//Resources/text4.txt", RichTextBoxStreamType.PlainText);
            File.WriteAllText("..//..//Resources/text4.txt", rtbox2.Text, Encoding.UTF8);
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            rtbox2.LoadFile("..//..//Resources/text4.txt", RichTextBoxStreamType.PlainText);
        }
        private void Btn10_Click(object sender, EventArgs e)
        {
            rtbox2.Clear();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {

            lbox3.Items.Remove(lbox3.SelectedItem.ToString());
            rtbox.Clear();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            lbox3.Items.Add(rtbox.Text.ToString());
            // понедельник
            if (rtbox.Text == "Эстонский язык - язык эстонцев,  относящийся к прибалтийско-финской ветви финно-угорской семьи языков." +
                    " Официальный язык Эстонии и Европейского союза.  Письменность — на основе латинского алфавита. ")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Эстонский");

            }
            if (rtbox.Text == "Мультимедиа - данные, или содержание, которое одновременно передаётся в разных формах: " +
                    "звук, анимированная компьютерная графика, видеоряд. Например," +
                    " в одном объекте-контейнере может содержаться текстовая, звуковая, графическая и видеоинформация," +
                    " а также, возможно, способ интерактивного взаимодействия с ней. Это достигается использованием определённого набора аппаратных и программных средств.")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Мультимедиа");

            }
            if (rtbox.Text == "Английский язык - язык англо-фризской подгруппы западной группы германской ветви индоевропейской языковой семьи." +
                    " Английский язык — важнейший международный язык," +
                    " что является следствием колониальной политики Британской империи в XIX веке " +
                    "и мирового влияния США в XX—XXI веках. Существует значительное разнообразие диалектов и говоров английского языка.")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Английский");
            }

            if (rtbox.Text == "Физика- область естествознания: наука о простейших и вместе с тем наиболее общих законах природы, " +
                    "о материи, её структуре и движении. Законы физики лежат в основе всего естествознания")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Физика");
            }

            if (rtbox.Text == "Программирование - процесс создания компьютерных программ," +
                    " Программирование основывается на использовании языков программирования, на которых записываются исходные тексты программ.")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Программирование");
            }
            if (rtbox.Text == "Биология -  наука о живых существах и их взаимодействии со средой обитания." +
                    " Изучает все аспекты жизни, в частности, структуру, функционирование, рост, происхождение, " +
                    "эволюцию и распределение живых организмов на Земле. Классифицирует и описывает живые существа," +
                    " происхождение их видов, взаимодействие между собой и с окружающей средой.")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Биология");
            }
            if (rtbox.Text == "Русский язык - один из восточнославянских языков, национальный язык русского народа." +
                    " Является одним из наиболее распространённых языков мира — " +
                    "шестым среди всех языков мира по общей численности говорящих и восьмым по численности владеющих им как родным")

            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Русский язык");
            }
            if (rtbox.Text == "Математика наука об отношениях между объектами, о которых ничего не известно, кроме описывающих их некоторых свойств," +
                    " — именно тех, которые в качестве аксиом положены в основание той или иной математической теории.")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Математика");
            }
            if (rtbox.Text == "Веб программирование - раздел программирования, ориентированный на разработку веб-приложений" +
                    " (программ, обеспечивающих функционирование динамических сайтов Всемирной паутины).")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Веб программирование");
            }
            if (rtbox.Text == "История - область знаний, а также гуманитарная наука, занимающаяся изучением " +
                    "человека (его деятельности, состояния, мировоззрения, социальных связей, организаций и так далее) в прошлом")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("История");
            }
            if (rtbox.Text == "Химия -одна из важнейших и обширных областей естествознания, наука о веществах, их составе и строении," +
                    " их свойствах, зависящих от состава и строения," +
                    " их превращениях, ведущих к изменению состава — химических реакциях, а также о законах и закономерностях, которым эти превращения подчиняются.")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Химия");
            }



            ///////////  2 функция ////////////////////
            //понедельник
            if (rtbox.Text == "Эстонский - 10:10-10:55")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Эстонский");
            }
            if (rtbox.Text == "Мультимедиа - 11:00-12:35")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Мультимедиа");
            }
            if (rtbox.Text == "Английский - 12:40-13:25")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Английский");
            }
            if (rtbox.Text == "Физика - 13:30-14:15")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Физика");
            }


            //вторник 
            if (rtbox.Text == "Программирование - 8:30-11:45")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Программирование");
            }
            if (rtbox.Text == "Биология - 11:50-12:35")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Биология");
            }
            if (rtbox.Text == "Русский язык - 12:40-13:25")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Русский язык");
            }
            if (rtbox.Text == "Английский язык - 14:20-15:05")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Английский язык");
            }


            // среда
            if (rtbox.Text == "Мультимедиа - 10:10-11:45")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Мультимедиа");
            }
            if (rtbox.Text == "Биология - 11:50-12:35")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Биология");
            }
            if (rtbox.Text == "Математика - 12:40-14:15")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Математика");
            }
            if (rtbox.Text == "Веб программирование - 15:10-16:45")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Веб программирование");
            }

            // четверг
            if (rtbox.Text == "История - 8:30-9:15")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("История");
            }
            if (rtbox.Text == "Химия - 9:20-10:05")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Химия");
            }
            if (rtbox.Text == "Эстонский язык - 11:00-11:45")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Эстонский язык");
            }
            if (rtbox.Text == "Английский язык - 11:50-12:35")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Английский язык");
            }

            if (rtbox.Text == "Программирование - 12:40-15:55")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Программирование");
            }

            // пятница

            if (rtbox.Text == "Физика - 8:30-9:15")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Физика");
            }
            if (rtbox.Text == "Эстонский язык - 9:20-10:05")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Эстонский язык");
            }
            if (rtbox.Text == "Химия - 10:10-10:55")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Химия");
            }
            if (rtbox.Text == "История - 11:50-12:35")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("История");
            }

            if (rtbox.Text == "Веб программирование - 12:40-15:55")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Веб программирование");
            }

            // суббота

            if (rtbox.Text == "Отдых - 11:00-23:00")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Отдых");
            }

            // воскресенье
            if (rtbox.Text == "Отдых - 11:00-15:00")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Отдых");
            }
            if (rtbox.Text == "Автошкола - 16:00-18:00")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Автошкола");
            }

            if (rtbox.Text == "Программирование - 19:00-23:00")
            {
                lbox3.Items.Remove(rtbox.Text.ToString());
                lbox3.Items.Add("Программирование");
            }

        }

        private void Lbox3_DoubleClick(object sender, EventArgs e)
        {
            // понедельник
            if (lbox2.SelectedIndex == 0 && lbox3.SelectedIndex == 0)
            {
                i = 1;
                rtbox.Text = "Эстонский язык - язык эстонцев,  относящийся к прибалтийско-финской ветви финно-угорской семьи языков." +
                    " Официальный язык Эстонии и Европейского союза.  Письменность — на основе латинского алфавита. ";
            }
            if (lbox2.SelectedIndex == 0 && lbox3.SelectedIndex == 1)
            {
                i = 2;
                rtbox.Text = "Мультимедиа - данные, или содержание, которое одновременно передаётся в разных формах: " +
                    "звук, анимированная компьютерная графика, видеоряд. Например," +
                    " в одном объекте-контейнере может содержаться текстовая, звуковая, графическая и видеоинформация," +
                    " а также, возможно, способ интерактивного взаимодействия с ней. Это достигается использованием определённого набора аппаратных и программных средств.";
            }
            if (lbox2.SelectedIndex == 0 && lbox3.SelectedIndex == 2)
            {
                i = 3;
                rtbox.Text = "Английский язык - язык англо-фризской подгруппы западной группы германской ветви индоевропейской языковой семьи." +
                    " Английский язык — важнейший международный язык," +
                    " что является следствием колониальной политики Британской империи в XIX веке " +
                    "и мирового влияния США в XX—XXI веках. Существует значительное разнообразие диалектов и говоров английского языка.";
            }
            if (lbox2.SelectedIndex == 0 && lbox3.SelectedIndex == 3)
            {
                i = 4;
                rtbox.Text = "Физика- область естествознания: наука о простейших и вместе с тем наиболее общих законах природы, " +
                    "о материи, её структуре и движении. Законы физики лежат в основе всего естествознания";
            }

            // вторник
            if (lbox2.SelectedIndex == 1 && lbox3.SelectedIndex == 0)
            {
                i = 21;
                rtbox.Text = "Программирование - процесс создания компьютерных программ," +
                    " Программирование основывается на использовании языков программирования, на которых записываются исходные тексты программ.";
            }
            if (lbox2.SelectedIndex == 1 && lbox3.SelectedIndex == 1)
            {
                i = 22;
                rtbox.Text = "Биология -  наука о живых существах и их взаимодействии со средой обитания." +
                    " Изучает все аспекты жизни, в частности, структуру, функционирование, рост, происхождение, " +
                    "эволюцию и распределение живых организмов на Земле. Классифицирует и описывает живые существа," +
                    " происхождение их видов, взаимодействие между собой и с окружающей средой.";
            }
            if (lbox2.SelectedIndex == 1 && lbox3.SelectedIndex == 2)
            {
                i = 23;
                rtbox.Text = "Русский язык - один из восточнославянских языков, национальный язык русского народа." +
                    " Является одним из наиболее распространённых языков мира — " +
                    "шестым среди всех языков мира по общей численности говорящих и восьмым по численности владеющих им как родным";
            }
            if (lbox2.SelectedIndex == 1 && lbox3.SelectedIndex == 3)
            {
                i = 24;
                rtbox.Text = "Английский язык - язык англо-фризской подгруппы западной группы германской ветви индоевропейской языковой семьи." +
                      " Английский язык — важнейший международный язык," +
                      " что является следствием колониальной политики Британской империи в XIX веке " +
                      "и мирового влияния США в XX—XXI веках. Существует значительное разнообразие диалектов и говоров английского языка.";
            }

            // среда
            if (lbox2.SelectedIndex == 2 && lbox3.SelectedIndex == 0)
            {
                i = 31;
                rtbox.Text = "Мультимедиа - данные, или содержание, которое одновременно передаётся в разных формах: " +
                      "звук, анимированная компьютерная графика, видеоряд. Например," +
                      " в одном объекте-контейнере может содержаться текстовая, звуковая, графическая и видеоинформация," +
                      " а также, возможно, способ интерактивного взаимодействия с ней. Это достигается использованием определённого набора аппаратных и программных средств.";
            }
            if (lbox2.SelectedIndex == 2 && lbox3.SelectedIndex == 1)
            {
                i = 32;
                rtbox.Text = "Биология -  наука о живых существах и их взаимодействии со средой обитания." +
                 " Изучает все аспекты жизни, в частности, структуру, функционирование, рост, происхождение, " +
                 "эволюцию и распределение живых организмов на Земле. Классифицирует и описывает живые существа," +
                 " происхождение их видов, взаимодействие между собой и с окружающей средой.";
            }
            if (lbox2.SelectedIndex == 2 && lbox3.SelectedIndex == 2)
            {
                i = 33;
                rtbox.Text = "Математика наука об отношениях между объектами, о которых ничего не известно, кроме описывающих их некоторых свойств," +
                    " — именно тех, которые в качестве аксиом положены в основание той или иной математической теории.";
            }
            if (lbox2.SelectedIndex == 2 && lbox3.SelectedIndex == 3)
            {
                i = 34;
                rtbox.Text = "Веб программирование - раздел программирования, ориентированный на разработку веб-приложений" +
                    " (программ, обеспечивающих функционирование динамических сайтов Всемирной паутины).";

            }

            // четверг
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 0)
            {
                i = 41;
                rtbox.Text = "История - область знаний, а также гуманитарная наука, занимающаяся изучением " +
                    "человека (его деятельности, состояния, мировоззрения, социальных связей, организаций и так далее) в прошлом";
            }
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 1)
            {
                i = 42;
                rtbox.Text = "Химия -одна из важнейших и обширных областей естествознания, наука о веществах, их составе и строении, их свойствах, зависящих от состава и строения," +
                    " их превращениях, ведущих к изменению состава — химических реакциях, а также о законах и закономерностях, которым эти превращения подчиняются.";
            }
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 2)
            {
                i = 43;
                rtbox.Text = "Эстонский язык - язык эстонцев,  относящийся к прибалтийско-финской ветви финно-угорской семьи языков." +
                              " Официальный язык Эстонии и Европейского союза.  Письменность — на основе латинского алфавита. ";
            }
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 3)
            {
                i = 44;
                rtbox.Text = "Английский язык - язык англо-фризской подгруппы западной группы германской ветви индоевропейской языковой семьи." +
                      " Английский язык — важнейший международный язык," +
                      " что является следствием колониальной политики Британской империи в XIX веке " +
                      "и мирового влияния США в XX—XXI веках. Существует значительное разнообразие диалектов и говоров английского языка.";
            }
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 4)
            {
                i = 45;
                rtbox.Text = "Программирование - процесс создания компьютерных программ," +
                    " Программирование основывается на использовании языков программирования, на которых записываются исходные тексты программ.";
            }


            // пятница
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 0)
            {
                i = 51;
                rtbox.Text = "Физика- область естествознания: наука о простейших и вместе с тем наиболее общих законах природы, " +
                            "о материи, её структуре и движении. Законы физики лежат в основе всего естествознания";
            }
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 1)
            {
                i = 52;
                rtbox.Text = "Эстонский язык - язык эстонцев,  относящийся к прибалтийско-финской ветви финно-угорской семьи языков." +
                        " Официальный язык Эстонии и Европейского союза.  Письменность — на основе латинского алфавита. ";
            }
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 2)
            {
                i = 53;
                rtbox.Text = "Химия -одна из важнейших и обширных областей естествознания, наука о веществах, их составе и строении," +
                    " их свойствах, зависящих от состава и строения," +
                    " их превращениях, ведущих к изменению состава — химических реакциях, а также о законах и закономерностях, которым эти превращения подчиняются.";
            }
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 3)
            {
                i = 54;
                rtbox.Text = "История - область знаний, а также гуманитарная наука, занимающаяся изучением " +
                    "человека (его деятельности, состояния, мировоззрения, социальных связей, организаций и так далее) в прошлом";
            }
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 4)
            {
                i = 55;
                rtbox.Text = "Веб программирование - раздел программирования, ориентированный на разработку веб-приложений" +
                    " (программ, обеспечивающих функционирование динамических сайтов Всемирной паутины).";
            }

            //суббота
            if (lbox2.SelectedIndex == 5 && lbox3.SelectedIndex == 0)
            {
                i = 61;
                rtbox.Text = "О́тдых — состояние покоя, либо времяпрепровождение, целью которого является восстановление" +
                    " сил, достижение работоспособного состояния организма; время, свободное от работы. ";
            }

            //воскресенье
            if (lbox2.SelectedIndex == 6 && lbox3.SelectedIndex == 0)
            {
                i = 71;
                rtbox.Text = "О́тдых — состояние покоя, либо времяпрепровождение, целью которого является восстановление" +
                    " сил, достижение работоспособного состояния организма; время, свободное от работы. ";
            }
            if (lbox2.SelectedIndex == 6 && lbox3.SelectedIndex == 1)
            {
                i = 72;
                rtbox.Text = "Автошкола - учреждение, в котором происходит обучение вождению транспортных средств. Они делятся на категории: А — мотоциклы;" +
                    " В — автомобили, трициклы и квадроциклы, масса которых не превышает 3,5 тонны; С — грузовые автомобили массой свыше 3,5 тонн;" +
                    " D — 9-16-местные автомобили и автобусы с прицепом, а также автобусы с двумя салонами; " +
                    "Е — эта буква используется для дополнения и уточнения транспортного средства. ";
            }
            if (lbox2.SelectedIndex == 6 && lbox3.SelectedIndex == 2)
            {
                i = 73;
                rtbox.Text = "Программирование - процесс создания компьютерных программ," +
           " Программирование основывается на использовании языков программирования, на которых записываются исходные тексты программ.";
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            rtbox.LoadFile("..//..//Resources/text3.txt", RichTextBoxStreamType.PlainText);

        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            rtbox.SaveFile("..//..//Resources/text3.txt", RichTextBoxStreamType.PlainText);
            File.WriteAllText("..//..//Resources/text3.txt", rtbox.Text, Encoding.UTF8);

        }

        private void Lbox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // понедельник
            if (lbox2.SelectedIndex == 0 && lbox3.SelectedIndex == 0)
            {
                ii = 1;
                rtbox.Text = "Эстонский - 10:10-10:55";
            }
            if (lbox2.SelectedIndex == 0 && lbox3.SelectedIndex == 1)
            {
                ii = 2;
                rtbox.Text = "Мультимедиа - 11:00-12:35";
            }
            if (lbox2.SelectedIndex == 0 && lbox3.SelectedIndex == 2)
            {
                ii = 3;
                rtbox.Text = "Английский - 12:40-13:25";
            }
            if (lbox2.SelectedIndex == 0 && lbox3.SelectedIndex == 3)
            {
                ii = 4;
                rtbox.Text = "Физика - 13:30-14:15";
            }

            // вторник
            if (lbox2.SelectedIndex == 1 && lbox3.SelectedIndex == 0)
            {
                ii = 21;
                rtbox.Text = "Программирование - 8:30-11:45";
            }
            if (lbox2.SelectedIndex == 1 && lbox3.SelectedIndex == 1)
            {
                ii = 22;
                rtbox.Text = "Биология - 11:50-12:35";
            }
            if (lbox2.SelectedIndex == 1 && lbox3.SelectedIndex == 2)
            {
                ii = 23;
                rtbox.Text = "Русский язык - 12:40-13:25";
            }
            if (lbox2.SelectedIndex == 1 && lbox3.SelectedIndex == 3)
            {
                ii = 24;
                rtbox.Text = "Английский язык - 14:20-15:05";
            }

            // среда
            if (lbox2.SelectedIndex == 2 && lbox3.SelectedIndex == 0)
            {
                ii = 31;
                rtbox.Text = "Мультимедиа - 10:10-11:45";
            }
            if (lbox2.SelectedIndex == 2 && lbox3.SelectedIndex == 1)
            {
                ii = 32;
                rtbox.Text = "Биология - 11:50-12:35";
            }
            if (lbox2.SelectedIndex == 2 && lbox3.SelectedIndex == 2)
            {
                ii = 33;
                rtbox.Text = "Математика - 12:40-14:15";
            }
            if (lbox2.SelectedIndex == 2 && lbox3.SelectedIndex == 3)
            {
                ii = 34;
                rtbox.Text = "Веб программирование - 15:10-16:45";
            }

            // четверг
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 0)
            {
                ii = 41;
                rtbox.Text = "История - 8:30-9:15";
            }
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 1)
            {
                ii = 42;
                rtbox.Text = "Химия - 9:20-10:05";
            }
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 2)
            {
                ii = 43;
                rtbox.Text = "Эстонский язык - 11:00-11:45";
            }
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 3)
            {
                ii = 44;
                rtbox.Text = "Английский язык - 11:50-12:35";
            }
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 4)
            {
                ii = 45;
                rtbox.Text = "Программирование - 12:40-15:55";
            }

            // пятница
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 0)
            {
                ii = 51;
                rtbox.Text = "Физика - 8:30-9:15";
            }
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 1)
            {
                ii = 52;
                rtbox.Text = "Эстонский язык - 9:20-10:05";
            }
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 2)
            {
                ii = 53;
                rtbox.Text = "Химия - 10:10-10:55";
            }
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 3)
            {
                ii = 54;
                rtbox.Text = "История - 11:50-12:35";
            }
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 4)
            {
                ii = 55;
                rtbox.Text = "Веб программирование - 12:40-15:55";
            }

            //суббота
            if (lbox2.SelectedIndex == 5 && lbox3.SelectedIndex == 0)
            {
                ii = 61;
                rtbox.Text = "Отдых - 11:00-23:00";
            }

            //суббота
            if (lbox2.SelectedIndex == 6 && lbox3.SelectedIndex == 0)
            {
                ii = 71;
                rtbox.Text = "Отдых - 11:00-15:00";
            }
            if (lbox2.SelectedIndex == 6 && lbox3.SelectedIndex == 1)
            {
                ii = 72;
                rtbox.Text = "Автошкола - 16:00-18:00";
            }
            if (lbox2.SelectedIndex == 6 && lbox3.SelectedIndex == 2)
            {
                ii = 73;
                rtbox.Text = "Программирование - 19:00-23:00";
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            rtbox.Clear();
        }

        private void LBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbox2.SelectedItems.ToString())
            {
                case ("Понедельник"): break;
                case ("Вторник"): break;
                case ("Среда"): break;
                case ("Четверг"): break;
                case ("Пятница"): break;
                case ("Суббота"): break;
                case ("Воскресенье"): break;
            }
            if (lbox2.SelectedIndex == 0)
            {

                lbox3.Width = 160;
                lbox3.Items.Clear();
                lbox3.Items.Add("Эстонский");
                lbox3.Items.Add("Мультимедиа");
                lbox3.Items.Add("Английский");
                lbox3.Items.Add("Физика");
                rtbox2.Text = "Понедельник";
                rtbox.Text = " ";
            }
            if (lbox2.SelectedIndex == 1)
            {
                lbox3.Width = 180;
                lbox3.Items.Clear();
                lbox3.Items.Add("Программирование");
                lbox3.Items.Add("Биология на эстонском");
                lbox3.Items.Add("Русский и Литература");
                lbox3.Items.Add("Английский");
                rtbox2.Text = "Вторник";
                rtbox.Text = " ";
            }
            if (lbox2.SelectedIndex == 2)
            {
                lbox3.Width = 180;
                lbox3.Items.Clear();
                lbox3.Items.Add("Мультимедиа");
                lbox3.Items.Add("Биология на эстонском");
                lbox3.Items.Add("Математика");
                lbox3.Items.Add("Веб разработка");
                rtbox2.Text = "Среда";
                rtbox.Text = " ";
            }
            if (lbox2.SelectedIndex == 3)
            {
                lbox3.Width = 160;
                lbox3.Items.Clear();
                lbox3.Items.Add("История");
                lbox3.Items.Add("Химия");
                lbox3.Items.Add("Эстонский");
                lbox3.Items.Add("Английский");
                lbox3.Items.Add("Программирование");
                rtbox2.Text = "Четверг";
                rtbox.Text = " ";
            }
            if (lbox2.SelectedIndex == 4)
            {
                lbox3.Width = 180;
                lbox3.Items.Clear();
                lbox3.Items.Add("Физика");
                lbox3.Items.Add("Эстонский");
                lbox3.Items.Add("Химия");
                lbox3.Items.Add("История");
                lbox3.Items.Add("Веб программирование");
                rtbox2.Text = "Пятница";
                rtbox.Text = " ";
            }
            if (lbox2.SelectedIndex == 5)
            {
                lbox3.Width = 160;
                lbox3.Items.Clear();
                lbox3.Items.Add("Отдых");
                rtbox2.Text = "Суббота";
                rtbox.Text = " ";
            }
            if (lbox2.SelectedIndex == 6)
            {
                lbox3.Width = 160;
                lbox3.Items.Clear();
                lbox3.Items.Add("Отдых");
                lbox3.Items.Add("Автошкола");
                lbox3.Items.Add("Программирование");
                rtbox2.Text = "Воскресенье";
                rtbox.Text = " ";
            }
        }
        private void LBox2_DoubleClick(object sender, EventArgs e)
        {
            rtbox2.Clear();
            rtbox2.Text = lbox2.SelectedItem.ToString() + " - " + "\n";
            for (int i = 0; i < lbox3.Items.Count; i++)
            {
                rtbox2.Text = rtbox2.Text + "\n" + lbox3.Items[i];
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        
    }
}
