using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HoroscopeApp
{
    public partial class MainPage : ContentPage
    {
        Label title;
        Label task1;
        Label task2;
        DatePicker calendar;
        Editor editor;
        Label info;
        Frame img;
        string enter = " ";

        public MainPage()
        {
            title = new Label
            {
                Text = "Кто ты по гороскопу?",
                TextColor = Color.Black,
                FontSize = 30,
                HorizontalOptions = LayoutOptions.Center,
            };

            task1 = new Label
            {
                Text = "У тебя есть два варианта узнать о себе: отметь на календарике своё день рождение...",
                FontSize = 24
            };

            task2 = new Label
            {
                Text = "ИЛИ впиши свой знак зодиака: ",
                FontSize = 24
            };


            calendar = new DatePicker
            {
                Format = "D",
                MaximumDate = DateTime.Now,
                MinimumDate = new DateTime(1920, 1, 1),
                Date = DateTime.Now,
            };
            calendar.DateSelected += Calendar_DateSelected;


            editor = new Editor
            {
                TextColor = Color.Black,
                Placeholder = "Введи свой знак",
            };
            editor.Completed += Editor_Completed;

            info = new Label
            {
                Text = "Здесь появиться информация",
                FontSize = 28, 
                BackgroundColor = Color.LightGray
            };

            img = new Frame()
            {
                Content = new Image {},
                WidthRequest = 50,
                HeightRequest = 250,
            };


            StackLayout stack = new StackLayout
            {
                Children = { title, task1, calendar, task2, editor, info, img }
            };
            Content = stack;

        }

       

        private void Calendar_DateSelected(object sender, DateChangedEventArgs e)
        {
            var m = e.NewDate.Month;
            var d = e.NewDate.Day;
            if (m==1 && d>1 && d<=20 || m==12 && d>=22)
            {
                info.Text = "Козерог" + 
                    "\n Козероги почувствуют освобождение, разрушатся тяжелые оковы ответственности и напряженности. " +
                    "Вы найдете место для радости и удовольствий, а не только для забот и работы.";
                img.Content = new Image { Source = "kozerog.jpg" };
            }
            else if (m == 1 && d >= 20 && d <= 31 || m == 2 && d >= 1 && d <= 18)
            {
                info.Text = "Водолей" + 
                    "\n Важный год наступает для Водолеев – он будет звать на подвиги. В 2023 году закладывайте фундамент для изменений в будущем.";
                img.Content = new Image { Source = "vodolei.jpg" };
            }
            else if (m == 2 && d >= 19 && d <= 29 || m == 3 && d >= 1 && d <= 20)
            {
                info.Text = "Рыбы" + 
                    "\n Рыбы ждет необычный год. Вы будете склонны к уединению. Необходимо избирательно подходить к выбору круга общения.";
                img.Content = new Image { Source = "rqbqjpg.jpg" };
            }
            else if (m == 3 && d >= 21 && d <= 31 || m == 4 && d >= 1 && d <= 19)
            {
                info.Text = "Овен" +
                    "\n Для Овнов 2023 год станет довольно важным временем. Вам необходимо " +
                    "будет окончательно определиться с собственными позициями и мнениями касаемо всех сфер.";
                img.Content = new Image { Source = "oven.jpg" };
            }
            else if (m == 4 && d >= 21 && d <= 30 || m == 5 && d >= 1 && d <= 20)
            {
                info.Text = "Телец" + 
                    "\n Изменения которые Тельцы запустили когда-то давно наконец-то дадут свои плоды." +
                    " Вы сможете подстроиться под новые обстоятельства и достигнуть больших успехов в работе.";
                img.Content = new Image { Source = "telec.jpg" };
            }
            else if (m == 5 && d >= 21 && d <= 31 || m == 6 && d >= 1 && d <= 20)
            {
                info.Text = "Близнецы" + 
                    "\n В 2023 году вам должно стать легче. Во всех сферах жизни появится больше стабильности и ясности.";
                img.Content = new Image { Source = "bliznecq.jpg" };
            }
            else if (m == 6 && d >= 21 && d <= 30 || m == 7 && d >= 1 && d <= 22)
            {
                info.Text = "Рак" +
                    "\n Раков можно поздравить! В 2022 году вы прошли большой путь трансформаций в " +
                    "сфере личных взаимоотношений: избавились от ненужных людей и обрели хороших друзей." +
                    " В 2023 году вы будете чувствовать себя свободно и появится желание встряхнуться и начать что-то новое.";
                img.Content = new Image { Source = "rak.jpg" };
            }
            else if (m == 7 && d >= 23 && d <= 31 || m == 8 && d >= 1 && d <= 22)
            {
                info.Text = "Лев" + 
                    "\n Львам предстоит пережить краеугольный год с большими изменениями. У вас будет шанс раскрыться и показать себя миру, " +
                    "но будьте осторожны и следите за эмоциями и ментальным здоровьем.";
                img.Content = new Image { Source = "lev.jpg" };
            }
            else if (m == 8 && d >= 23 && d <= 31 || m == 9 && d >= 1 && d <= 22)
            {
                info.Text = "Дева" + 
                    "\n Девам 2023 год принесет много значительных событий. Вы внезапно можете стать для себя мерилом нравственности и вектором духовности. " +
                    "Окружающие будут воспринимать вас, как опору и лидера.";
                img.Content = new Image { Source = "deva.jpg" };
            }
            else if (m == 9 && d >= 23 && d <= 30 || m == 10 && d >= 1 && d <= 22)
            {
                info.Text = "Весы" + 
                    "\n Весам в 2023 году может казаться, что всё вокруг скучно – боритесь с этим и раскрашивайте рутину. " +
                    "Вы будете считать, что кому-то везет больше вас. Поработайте над ответственностью и собранностью.";
                img.Content = new Image { Source = "vesq.jpg" };
            }
            else if (m == 10 && d >= 23 && d <= 31 || m == 11 && d >= 1 && d <= 21)
            {
                info.Text = "Скорпион" + "\n Для Скорпионов наступает счастливый и наполненный мощными энергиями год.";
                img.Content = new Image { Source = "skorpion.jpg" };
            }
            else if (m == 11 && d >= 22 && d <= 30 || m == 12 && d >= 1 && d <= 21)
            {
                info.Text = "Стрелец" + 
                    "\n Стрельцов будет влечь жажда развлечений – захочется праздника жизни. " +
                    "Приходит время действовать по творческому импульсу, а не подчиняться кому-то.";
                img.Content = new Image { Source = "strelec.jpg" };
            }

        }

        private void Editor_Completed(object sender, EventArgs e)
        {
            enter = editor.Text;
            if (enter == "Козерог" || enter == "козерог")
            {
                info.Text = "Козерог" +
                    "\n Козероги почувствуют освобождение, разрушатся тяжелые оковы ответственности и напряженности. " +
                    "Вы найдете место для радости и удовольствий, а не только для забот и работы.";
                img.Content = new Image { Source = "kozerog.jpg" };
            }
            else if (enter == "Водолей" || enter == "водолей")
            {
                info.Text = "Водолей" +
                    "\n Важный год наступает для Водолеев – он будет звать на подвиги. В 2023 году закладывайте фундамент для изменений в будущем.";
                img.Content = new Image { Source = "vodolei.jpg" };
            }
            else if (enter == "Рыбы" || enter == "рыбы")
            {
                info.Text = "Рыбы" +
                    "\n Рыбы ждет необычный год. Вы будете склонны к уединению. Необходимо избирательно подходить к выбору круга общения.";
                img.Content = new Image { Source = "rqbqjpg.jpg" };
            }
            else if (enter == "Овен" || enter == "овен")
            {
                info.Text = "Овен" +
                       "\n Для Овнов 2023 год станет довольно важным временем. Вам необходимо " +
                       "будет окончательно определиться с собственными позициями и мнениями касаемо всех сфер.";
                img.Content = new Image { Source = "oven.jpg" };
            }
            else if (enter == "Телец" || enter == "телец")
            {
                info.Text = "Телец" +
                    "\n Изменения которые Тельцы запустили когда-то давно наконец-то дадут свои плоды." +
                    " Вы сможете подстроиться под новые обстоятельства и достигнуть больших успехов в работе.";
                img.Content = new Image { Source = "telec.jpg" };
            }
            else if (enter == "Близнецы" || enter == "близнецы")
            {
                info.Text = "Близнецы" +
                       "\n В 2023 году вам должно стать легче. Во всех сферах жизни появится больше стабильности и ясности.";
                img.Content = new Image { Source = "bliznecq.jpg" };
            }
            else if (enter == "Рак" || enter == "рак")
            {
                info.Text = "Рак" +
                     "\n Раков можно поздравить! В 2022 году вы прошли большой путь трансформаций в " +
                     "сфере личных взаимоотношений: избавились от ненужных людей и обрели хороших друзей." +
                     " В 2023 году вы будете чувствовать себя свободно и появится желание встряхнуться и начать что-то новое.";
                img.Content = new Image { Source = "rak.jpg" };
            }
            else if (enter == "Лев" || enter == "лев")
            {
                info.Text = "Лев" +
                   "\n Львам предстоит пережить краеугольный год с большими изменениями. У вас будет шанс раскрыться и показать себя миру, " +
                   "но будьте осторожны и следите за эмоциями и ментальным здоровьем.";
                img.Content = new Image { Source = "lev.jpg" };
            }
            else if (enter == "Дева" || enter == "дева")
            {
                info.Text = "Дева" +
                    "\n Девам 2023 год принесет много значительных событий. Вы внезапно можете стать для себя мерилом нравственности и вектором духовности. " +
                    "Окружающие будут воспринимать вас, как опору и лидера.";
                img.Content = new Image { Source = "deva.jpg" };
            }
            else if (enter == "Весы" || enter == "весы")
            {
                info.Text = "Весы" +
                       "\n Весам в 2023 году может казаться, что всё вокруг скучно – боритесь с этим и раскрашивайте рутину. " +
                       "Вы будете считать, что кому-то везет больше вас. Поработайте над ответственностью и собранностью.";
                img.Content = new Image { Source = "vesq.jpg" };
            }
            else if (enter == "Скорпион" || enter == "скорпион")
            {
                info.Text = "Скорпион" + "\n Для Скорпионов наступает счастливый и наполненный мощными энергиями год.";
                img.Content = new Image { Source = "skorpion.jpg" };
            }
            else if (enter == "Стрелец" || enter == "стрелец")
            {
                info.Text = "Стрелец" +
                    "\n Стрельцов будет влечь жажда развлечений – захочется праздника жизни. " +
                    "Приходит время действовать по творческому импульсу, а не подчиняться кому-то.";
                img.Content = new Image { Source = "strelec.jpg" };
            }
            else
            {
                info.Text = "Проверьте правильность написания";
            }
        }
    }
}

