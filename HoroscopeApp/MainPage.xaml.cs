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
                Text = "Horoskoop",
                TextColor = Color.Black,
                FontSize = 30,
                HorizontalOptions = LayoutOptions.Center,
            };

            task1 = new Label
            {
                Text = "Valige oma sünnipäeva kuupäev: ",
                FontSize = 24
            };

            task2 = new Label
            {
                Text = "Kirjutage oma sodiaagimärk: ",
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
                Placeholder = "Sisestage oma sodiaagimärk",
            };
            editor.Completed += Editor_Completed;

            info = new Label
            {
                Text = "Teave kuvatakse siin",
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
                info.Text = "Kaljukits" +
                    "\n 22. Detsember – 21. Jaanuar" +
                    "\n Kaljukitsed tunnevad end vabanenuna, vastutuse ja pingete rasked köidikud murtakse. " +
                    "Leiad koha rõõmudele ja naudingutele, mitte ainult muredele ja tööle.";
                img.Content = new Image { Source = "kozerog.jpg" };
            }
            else if (m == 1 && d >= 20 && d <= 31 || m == 2 && d >= 1 && d <= 18)
            {
                info.Text = "Veevalaja" +
                    "\n21. Jaanuar – 19. Veebruar" +
                    "\n Veevalaja jaoks on tulemas tähtis aasta – see nõuab vägitegusid. 2023. aastal pange alus muudatustele tulevikus.";
                img.Content = new Image { Source = "vodolei.jpg" };
            }
            else if (m == 2 && d >= 19 && d <= 29 || m == 3 && d >= 1 && d <= 20)
            {
                info.Text = "Kalad" +
                    "\n19. Veebruar – 20. Märts" +
                    "\n Kalasid ootab ees ebatavaline aasta. Oled altid üksindusele. Oma suhtlusringkonna valimisel tuleb olla valiv.";
                img.Content = new Image { Source = "rqbqjpg.jpg" };
            }
            else if (m == 3 && d >= 21 && d <= 31 || m == 4 && d >= 1 && d <= 19)
            {
                info.Text = "Jäär" +
                    "\n20. Märts – 21. Aprill" +
                    "\n Jäära jaoks on 2023. aasta üsna oluline aeg. Sa vajad " +
                    "otsustavad lõpuks ise oma seisukohad ja arvamused kõigis valdkondades.";
                img.Content = new Image { Source = "oven.jpg" };
            }
            else if (m == 4 && d >= 21 && d <= 30 || m == 5 && d >= 1 && d <= 20)
            {
                info.Text = "Sõnn" +
                    "\n21. Aprill – 22. Mai" +
                    "\n Muutused, mille Sõnn juba ammu käivitas, kannavad lõpuks vilja." +
                    " Suudad kohaneda uute oludega ja saavutad oma töös suurt edu.";
                img.Content = new Image { Source = "telec.jpg" };
            }
            else if (m == 5 && d >= 21 && d <= 31 || m == 6 && d >= 1 && d <= 20)
            {
                info.Text = "Kaksikud" +
                    "\n22. Mai – 22. Juuni" +
                    "\n Aastal 2023 peaksid asjad teie jaoks lihtsamaks minema. Kõigis eluvaldkondades on rohkem stabiilsust ja selgust.";
                img.Content = new Image { Source = "bliznecq.jpg" };
            }
            else if (m == 6 && d >= 21 && d <= 30 || m == 7 && d >= 1 && d <= 22)
            {
                info.Text = "Vähk" +
                    "\n22. Juuni – 23. Juuli" +
                    "\n Õnnitlused Vähkidele! Aastal 2022 olete läbinud pika ümberkujunemise teekonna " +
                    "isiklike suhete sfäär: vabanes ebavajalikest inimestest ja leidis häid sõpru." +
                    " Aastal 2023 tunnete end vabalt ja teil on soov asju raputada ja midagi uut alustada.";
                img.Content = new Image { Source = "rak.jpg" };
            }
            else if (m == 7 && d >= 23 && d <= 31 || m == 8 && d >= 1 && d <= 22)
            {
                info.Text = "Lõvi" +
                    "\n23. Juuli – 24. August" +
                    "\n Lõvidel on ees pöördeline suurte muutustega aasta. Sul on võimalus end avada ja maailmale näidata, " +
                    "kuid ole ettevaatlik ja jälgi oma emotsioone ja vaimset tervist.";
                img.Content = new Image { Source = "lev.jpg" };
            }
            else if (m == 8 && d >= 23 && d <= 31 || m == 9 && d >= 1 && d <= 22)
            {
                info.Text = "Neitsi" +
                    "\n24. August – 23. September" +
                    "\n Neitside jaoks toob 2023. aasta palju märkimisväärseid sündmusi. Sinust võib ootamatult saada omaenda moraalistandard ja vaimsuse vektor. " +
                    "Teie ümber olevad inimesed tajuvad teid toe ja juhina.";
                img.Content = new Image { Source = "deva.jpg" };
            }
            else if (m == 9 && d >= 23 && d <= 30 || m == 10 && d >= 1 && d <= 22)
            {
                info.Text = "Kaallud" +
                    "\n23. September – 23. Oktoober" +
                    "\n 2023. aastal võivad Kaalud tunda, et kõik nende ümber on igav – võitle sellega ja värvi rutiini. " +
                    "Arvate, et kellelgi on rohkem õnne kui sina. Töötage selle nimel, et olla vastutustundlik ja kogutud.";
                img.Content = new Image { Source = "vesq.jpg" };
            }
            else if (m == 10 && d >= 23 && d <= 31 || m == 11 && d >= 1 && d <= 21)
            {
                info.Text = "Skorpion" +
                    "\n23. Oktoober – 23. November" +
                    "\n Skorpionide jaoks on tulemas õnnelik aasta, mis on täis võimsaid energiaid.";
                img.Content = new Image { Source = "skorpion.jpg" };
            }
            else if (m == 11 && d >= 22 && d <= 30 || m == 12 && d >= 1 && d <= 21)
            {
                info.Text = "Ambur" +
                    "\n23. November – 22. Detsember" +
                    "\n Amburid tõmbab ligi meelelahutusjanu – nad tahavad elu tähistamist. " +
                    "On aeg tegutseda loomingulise impulsi alusel ja mitte kellelegi alluda.";
                img.Content = new Image { Source = "strelec.jpg" };
            }

        }

        private void Editor_Completed(object sender, EventArgs e)
        {
            enter = editor.Text;
            if (enter == "Kaljukits" || enter == "kaljukits")
            {
                info.Text = "Kaljukits" + 
                    "\n 22. Detsember – 21. Jaanuar" +
                    "\n Kaljukitsed tunnevad end vabanenuna, vastutuse ja pingete rasked köidikud murtakse. " +
                    "Leiad koha rõõmudele ja naudingutele, mitte ainult muredele ja tööle.";
                img.Content = new Image { Source = "kozerog.jpg" };
            }
            else if (enter == "Veevalaja" || enter == "veevalaja")
            {
                info.Text = "Veevalaja" +
                    "\n21. Jaanuar – 19. Veebruar" +
                    "\n Veevalaja jaoks on tulemas tähtis aasta – see nõuab vägitegusid. 2023. aastal pange alus muudatustele tulevikus.";
                img.Content = new Image { Source = "vodolei.jpg" };
            }
            else if (enter == "Kalad" || enter == "kalad")
            {
                info.Text = "Kalad" +
                    "\n19. Veebruar – 20. Märts" +
                    "\n Kalasid ootab ees ebatavaline aasta. Oled altid üksindusele. Oma suhtlusringkonna valimisel tuleb olla valiv.";
                img.Content = new Image { Source = "rqbqjpg.jpg" };
            }
            else if (enter == "Jäär" || enter == "jäär")
            {
                info.Text = "Jäär" +
                       "\n20. Märts – 21. Aprill" +
                       "\n Jäära jaoks on 2023. aasta üsna oluline aeg. Peate lõpuks  " +
                       "otsustama oma seisukohtade ja arvamuste üle kõigis valdkondades.";
                img.Content = new Image { Source = "oven.jpg" };
            }
            else if (enter == "Sõnn" || enter == "sõnn")
            {
                info.Text = "Sõnn" +
                    "\n21. Aprill – 22. Mai" +
                    "\n Muutused, mille Sõnn juba ammu käivitas, kannavad lõpuks vilja." +
                    " Suudad kohaneda uute oludega ja saavutad oma töös suurt edu.";
                img.Content = new Image { Source = "telec.jpg" };
            }
            else if (enter == "Kaksikud" || enter == "kaksikud")
            {
                info.Text = "Kaksikud" +
                    "\n22. Mai – 22. Juuni" +
                    "\n Aastal 2023 peaksid asjad teie jaoks lihtsamaks minema. Kõigis eluvaldkondades on rohkem stabiilsust ja selgust.";
                img.Content = new Image { Source = "bliznecq.jpg" };
            }
            else if (enter == "Vähk" || enter == "vähk")
            {
                info.Text = "Vähk" +
                     "\n22. Juuni – 23. Juuli" +
                     "\n Õnnitlused Vähkidele! Aastal 2022 olete läbinud pika ümberkujunemise teekonna " +
                     "isiklike suhete sfäär: vabanes ebavajalikest inimestest ja leidis häid sõpru." +
                     " Aastal 2023 tunnete end vabalt ja teil on soov asju raputada ja midagi uut alustada.";
                img.Content = new Image { Source = "rak.jpg" };
            }
            else if (enter == "Lõvi" || enter == "lõvi")
            {
                info.Text = "Lõvi" +
                   "\n23. Juuli – 24. August" +
                   "\n Lõvidel on ees pöördeline suurte muutustega aasta. Sul on võimalus end avada ja maailmale näidata, " +
                   "kuid ole ettevaatlik ja jälgi oma emotsioone ja vaimset tervist.";
                img.Content = new Image { Source = "lev.jpg" };
            }
            else if (enter == "Neitsi" || enter == "neitsi")
            {
                info.Text = "Neitsi" +
                    "\n24. August – 23. September" +
                    "\n Neitside jaoks toob 2023. aasta palju märkimisväärseid sündmusi. Sinust võib ootamatult saada omaenda moraalistandard ja vaimsuse vektor. " +
                    "Teie ümber olevad inimesed tajuvad teid toe ja juhina.";
                img.Content = new Image { Source = "deva.jpg" };
            }
            else if (enter == "Kaallud" || enter == "kaallud")
            {
                info.Text = "Kaallud" +
                     "\n23. September – 23. Oktoober" +
                     "\n 2023. aastal võivad Kaalud tunda, et kõik nende ümber on igav – võitle sellega ja värvi rutiini. " +
                     "Arvate, et kellelgi on rohkem õnne kui sina. Töötage selle nimel, et olla vastutustundlik ja kogutud.";
                img.Content = new Image { Source = "vesq.jpg" };
            }
            else if (enter == "Skorpion" || enter == "skorpion")
            {
                info.Text = "Skorpion" +
                    "\n23. Oktoober – 23. November" + 
                    "\n Skorpionide jaoks on tulemas õnnelik aasta, mis on täis võimsaid energiaid.";
                img.Content = new Image { Source = "skorpion.jpg" };
            }
            else if (enter == "Ambur" || enter == "ambur")
            {
                info.Text = "Ambur" +
                    "\n23. November – 22. Detsember" +
                    "\n Amburid tõmbab ligi meelelahutusjanu – nad tahavad elu tähistamist. " +
                    "On aeg tegutseda loomingulise impulsi alusel ja mitte kellelegi alluda.";
                img.Content = new Image { Source = "strelec.jpg" };
            }
            else
            {
                info.Text = "Kontrollige, kas kõik on õige?";
            }
        }
    }
}

