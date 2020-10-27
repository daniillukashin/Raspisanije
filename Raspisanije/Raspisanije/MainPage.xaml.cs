using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Raspisanije
{
    public partial class MainPage : ContentPage
    {
        Label pon, vtor, sred, tset, pjat, zvanije, russkij, miha, oleinik, skrul, angl, alina, lury, skrul1, him, lury1, miha1, angl1, him1, oleinik1;
        public MainPage()

        {
            Grid grid = new Grid();
            for (int i = 0; i < 10; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }
            for (int i = 0; i < 5; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }
            {
                BackgroundColor = Color.White;
            }
            //Фамилия и имя и группа.
            zvanije = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Blue, Text = "                  LOGITpv19               ", FontSize = 30 };
            grid.Children.Add(zvanije, 0, 0);
            Grid.SetColumnSpan(zvanije, 11);

            //Понедельник.
            pon = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Blue, Text = "Понедельник       ", FontSize = 15 };
            grid.Children.Add(pon, 0, 1);
            Grid.SetColumnSpan(pon, 2);

            //Вторник.
            vtor = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Blue, Text = "Вторник      ", FontSize = 15 };
            grid.Children.Add(vtor, 0, 2);
            Grid.SetColumnSpan(vtor, 2);

            //Среда.
            sred = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Blue, Text = "Среда      ", FontSize = 15 };
            grid.Children.Add(sred, 0, 3);
            Grid.SetColumnSpan(sred, 2);

            //Четверг.
            tset = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Blue, Text = "Четверг      ", FontSize = 15 };
            grid.Children.Add(tset, 0, 4);
            Grid.SetColumnSpan(tset, 2);

            //Пятница.
            pjat = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Blue, Text = "Пятница     ", FontSize = 15 };
            grid.Children.Add(pjat, 0, 5);
            Grid.SetColumnSpan(pjat, 2);

            //Понедельник Keel.
            russkij = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGreen, Text = "  Keel  ", FontSize = 15 };
            grid.Children.Add(russkij, 2, 1);
            Grid.SetColumnSpan(russkij, 2);
            var tap = new TapGestureRecognizer();
            tap.Tapped += (s, e) =>
            {
                russkij = (Label)s;
                MoreInfo();
            };
            //Понедельник Võrgud ja seadm.

            miha = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Beige, Text = "Võrgud ja seadm.", FontSize = 15 };
            grid.Children.Add(miha, 4, 1);
            Grid.SetColumnSpan(miha, 2);
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += (s, e) =>
            {
                miha = (Label)s;
                MoreInfo1();
            };

            //Понедельник Mob.rak.
            oleinik = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightBlue, Text = "Mob.rak.  ", FontSize = 15 };
            grid.Children.Add(oleinik, 7, 1);
            Grid.SetColumnSpan(oleinik, 3);
            var tap2 = new TapGestureRecognizer();
            tap2.Tapped += (s, e) =>
            {
                oleinik = (Label)s;
                MoreInfo2();
            };

            //Вторник Transp.log.juht.
            skrul = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightCoral, Text = "Transp.log.juht.      ", FontSize = 15 };
            grid.Children.Add(skrul, 2, 2);
            Grid.SetColumnSpan(skrul, 3);
            var tap3 = new TapGestureRecognizer();
            tap3.Tapped += (s, e) =>
            {
                skrul = (Label)s;
                MoreInfo3();
            };

            //Вторник Ing.
            angl = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = " Ing   ", FontSize = 15 };
            grid.Children.Add(angl, 6, 2);
            Grid.SetColumnSpan(angl, 2);
            var tap4 = new TapGestureRecognizer();
            tap4.Tapped += (s, e) =>
            {
                angl = (Label)s;
                MoreInfo4();
            };

            //Вторник Eesti keel.
            alina = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Pink, Text = "Eesti keel", FontSize = 15 };
            grid.Children.Add(alina, 8, 2);
            Grid.SetColumnSpan(alina, 2);
            var tap5 = new TapGestureRecognizer();
            tap5.Tapped += (s, e) =>
            {
                alina = (Label)s;
                MoreInfo5();
            };
            //Среда W.paig.sead.
            lury = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightPink, Text = "  W.paig.sead.", FontSize = 15 };
            grid.Children.Add(lury, 2, 3);
            Grid.SetColumnSpan(lury, 3);
            var tap6 = new TapGestureRecognizer();
            tap6.Tapped += (s, e) =>
            {
                lury = (Label)s;
                MoreInfo6();
            };
            //Среда Transp.log.juht.
            skrul1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightCoral, Text = "Transp.log.juht.                      ", FontSize = 15 };
            grid.Children.Add(skrul1, 5, 3);
            Grid.SetColumnSpan(skrul1, 5);
            var tap7 = new TapGestureRecognizer();
            tap7.Tapped += (s, e) =>
            {
                skrul1 = (Label)s;
                MoreInfo7();
            };
            //Среда Keemia.
            him = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightPink, Text = "Keemia", FontSize = 15 };
            grid.Children.Add(him, 10, 3);
            Grid.SetColumnSpan(him, 1);
            var tap8 = new TapGestureRecognizer();
            tap8.Tapped += (s, e) =>
            {
                him = (Label)s;
                MoreInfo8();
            };

            //Четверг W.paig.sead.
            lury1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightPink, Text = "  W.paig.sead.", FontSize = 15 };
            grid.Children.Add(lury1, 2, 4);
            Grid.SetColumnSpan(lury1, 3);
            var tap9 = new TapGestureRecognizer();
            tap9.Tapped += (s, e) =>
            {
                lury1 = (Label)s;
                MoreInfo9();
            };

            //Четверг Võrgud ja seadm.
            miha1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Beige, Text = "Võrgud ja seadm.", FontSize = 15 };
            grid.Children.Add(miha1, 6, 4);
            Grid.SetColumnSpan(miha1, 2);
            var tap10 = new TapGestureRecognizer();
            tap10.Tapped += (s, e) =>
            {
                miha1 = (Label)s;
                MoreInfo10();
            };

            //Четверг Ing.
            angl1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = " Ing   ", FontSize = 15 };
            grid.Children.Add(angl1, 8, 4);
            Grid.SetColumnSpan(angl1, 2);
            var tap11 = new TapGestureRecognizer();
            tap11.Tapped += (s, e) =>
            {
                angl1 = (Label)s;
                MoreInfo11();
            };
            //Пятница Keemia.
            him1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightPink, Text = "Keemia", FontSize = 15 };
            grid.Children.Add(him1, 2, 5);
            Grid.SetColumnSpan(him1, 1);
            var tap12 = new TapGestureRecognizer();
            tap12.Tapped += (s, e) =>
            {
                him1 = (Label)s;
                MoreInfo12();
            };

            //Мобильная Mob.rak.
            oleinik1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightBlue, Text = "Mob.rak.  ", FontSize = 15 };
            grid.Children.Add(oleinik1, 4, 5);
            Grid.SetColumnSpan(oleinik1, 3);
            var tap13 = new TapGestureRecognizer();
            tap13.Tapped += (s, e) =>
            {
                oleinik1 = (Label)s;
                MoreInfo13();
            };
            russkij.GestureRecognizers.Add(tap);
            miha.GestureRecognizers.Add(tap1);
            oleinik.GestureRecognizers.Add(tap2);
            skrul.GestureRecognizers.Add(tap3);
            angl.GestureRecognizers.Add(tap4);
            alina.GestureRecognizers.Add(tap5);
            lury.GestureRecognizers.Add(tap6);
            skrul1.GestureRecognizers.Add(tap7);
            him.GestureRecognizers.Add(tap8);
            lury1.GestureRecognizers.Add(tap9);
            miha1.GestureRecognizers.Add(tap10);
            angl1.GestureRecognizers.Add(tap11);
            him1.GestureRecognizers.Add(tap12);
            oleinik1.GestureRecognizers.Add(tap13);
            Content = grid;

        }

        public async void MoreInfo()
        {
            await DisplayAlert("Подробная информация", "Кабинет B221, Людмила Михайловна", "Закрыть");
        }
        public async void MoreInfo1()
        {
            await DisplayAlert("Подробная информация", "Кабинет A123, Михаил Агапов", "Закрыть");
        }
        public async void MoreInfo2()
        {
            await DisplayAlert("Подробная информация", "Кабинет E07, Марина Олейник", "Закрыть");
        }
        public async void MoreInfo3()
        {
            await DisplayAlert("Подробная информация", "Кабинет B002, Яянус Крулль", "Закрыть");
        }
        public async void MoreInfo4()
        {
            await DisplayAlert("Подробная информация", "Кабинет , B242,Юлия Воронецкая", "Закрыть");
        }
        public async void MoreInfo5()
        {
            await DisplayAlert("Подробная информация", "Кабинет , B242, Алина Ляневали-Тоотс", "Закрыть");
        }
        public async void MoreInfo6()
        {
            await DisplayAlert("Подробная информация", "Кабинет , A243, Лури Шкарбанова", "Закрыть");
        }
        public async void MoreInfo7()
        {
            await DisplayAlert("Подробная информация", "Кабинет , B003, Яянус Крулль", "Закрыть");
        }
        public async void MoreInfo8()
        {
            await DisplayAlert("Подробная информация", "Кабинет , B144, Светлана Песецкая", "Закрыть");
        }
        public async void MoreInfo9()
        {
            await DisplayAlert("Подробная информация", "Кабинет , A243, Лури Шкарбанова", "Закрыть");
        }
        public async void MoreInfo10()
        {
            await DisplayAlert("Подробная информация", "Кабинет A123, Михаил Агапов", "Закрыть");
        }
        public async void MoreInfo11()
        {
            await DisplayAlert("Подробная информация", "Кабинет , B242, Юлия Воронецкая", "Закрыть");
        }
        public async void MoreInfo12()
        {
            await DisplayAlert("Подробная информация", "Кабинет , B144, Светлана Песецкая", "Закрыть");
        }
        public async void MoreInfo13()
        {
            await DisplayAlert("Подробная информация", "Кабинет E07, Марина Олейник", "Закрыть");
        }
    }
}
