using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace prac_imagenes
{
    public partial class MainPage : CarouselPage
    {
        int i1, i2, i3, i4, i5, i6, i7, i8, i9, i10;
        int d1, d2, d3, d4, d5, d6, d7, d8, d9, d10;

        public MainPage()
        {
            InitializeComponent();
        }


        private void l1_Clicked(object sender, EventArgs e)
        {
            if (like1.IsEnabled)
            {
                d1 = 1;
                if (d1 == 1)
                {
                    i1 = 1;
                    like1.IsEnabled = false;
                    deslike1.IsEnabled = true;
                }

            }
        }

        private void l2_Clicked(object sender, EventArgs e)
        {
            if (like2.IsEnabled)
            {
                d2 = 1;
                if (d2 == 1)
                {
                    i2 = 1;
                    like2.IsEnabled = false;
                    deslike2.IsEnabled = true;
                }
            }
        }
        private void l3_Clicked(object sender, EventArgs e)
        {
            if (like3.IsEnabled)
            {
                d3 = 1;
                if (d3 == 1)
                {
                    i3 = 1;
                    like3.IsEnabled = false;
                    deslike3.IsEnabled = true;
                }
            }
        }
        private void l4_Clicked(object sender, EventArgs e)
        {
            if (like4.IsEnabled)
            {
                d4 = 1;
                if (d4 == 1)
                {
                    i4 = 1;
                    like4.IsEnabled = false;
                    deslike4.IsEnabled = true;
                }
            }

        }
        private void l5_Clicked(object sender, EventArgs e)
        {
            if (like5.IsEnabled)
            {
                d5 = 1;
                if (d5 == 1)
                {
                    i5 = 1;
                    like5.IsEnabled = false;
                    deslike5.IsEnabled = true;
                }
            }
        }
        private void l6_Clicked(object sender, EventArgs e)
        {
            if (like6.IsEnabled)
            {
                d6 = 1;
                if (d6 == 1)
                {
                    i6 = 1;
                    like6.IsEnabled = false;
                    deslike6.IsEnabled = true;
                }
            }
        }
        private void l7_Clicked(object sender, EventArgs e)
        {
            if (like7.IsEnabled)
            {

                d7 = 1;
                if (d7 == 1)
                {
                    i7 = 1;
                    like7.IsEnabled = false;
                    deslike7.IsEnabled = true;
                }
            }
        }
        private void l8_Clicked(object sender, EventArgs e)
        {
            if (like8.IsEnabled)
            {
                d8 = 1;
                if (d8 == 1)
                {
                    i8 = 1;
                    like8.IsEnabled = false;
                    deslike8.IsEnabled = true;
                }
            }
        }
        private void l9_Clicked(object sender, EventArgs e)
        {
            if (like9.IsEnabled)
            {
                d9 = 1;
                if (d9 == 1)
                {
                    i9 = 1;
                    like9.IsEnabled = false;
                    deslike9.IsEnabled = true;
                }
            }
        }
        private void l10_Clicked(object sender, EventArgs e)
        {
            if (like10.IsEnabled)
            {
                d10 = 1;
                if (d10 == 1)
                {
                    i10 = 1;
                    like10.IsEnabled = false;
                    deslike10.IsEnabled = true;
                }
            }
        }
        //-----------------------------------------------------------------------
        private void d1_Clicked(object sender, EventArgs e)
        {
            if (deslike1.IsEnabled)
            {
                i1 = 0;
                if (i1 == 0)
                {
                    d1 = 0;
                    deslike1.IsEnabled = false;
                    like1.IsEnabled = true;
                }

            }
        }
        private void d2_Clicked(object sender, EventArgs e)
        {
            if (deslike2.IsEnabled)
            {
                i2 = 0;
                if (i2 == 0)
                {
                    d2 = 0;
                    deslike2.IsEnabled = false;
                    like2.IsEnabled = true;
                }

            }
        }
        private void d3_Clicked(object sender, EventArgs e)
        {
            if (deslike3.IsEnabled)
            {
                i3 = 0;
                if (i3 == 0)
                {
                    d3 = 0;
                    deslike3.IsEnabled = false;
                    like3.IsEnabled = true;
                }

            }
        }
        private void d4_Clicked(object sender, EventArgs e)
        {
            if (deslike4.IsEnabled)
            {
                i4 = 0;
                if (i4 == 0)
                {
                    d4 = 0;
                    deslike4.IsEnabled = false;
                    like4.IsEnabled = true;
                }

            }
        }
        private void d5_Clicked(object sender, EventArgs e)
        {
            if (deslike5.IsEnabled)
            {
                i5 = 0;
                if (i5 == 0)
                {
                    d5 = 0;
                    deslike5.IsEnabled = false;
                    like5.IsEnabled = true;
                }

            }
        }
        private void d6_Clicked(object sender, EventArgs e)
        {
            if (deslike6.IsEnabled)
            {
                i6 = 0;
                if (i6 == 0)
                {
                    d6 = 0;
                    deslike6.IsEnabled = false;
                    like6.IsEnabled = true;
                }

            }
        }
        private void d7_Clicked(object sender, EventArgs e)
        {
            if (deslike7.IsEnabled)
            {
                i7 = 0;
                if (i7 == 0)
                {
                    d7 = 0;
                    deslike7.IsEnabled = false;
                    like7.IsEnabled = true;
                }

            }
        }
        private void d8_Clicked(object sender, EventArgs e)
        {
            if (deslike8.IsEnabled)
            {
                i8 = 0;
                if (i8 == 0)
                {
                    d8 = 0;
                    deslike8.IsEnabled = false;
                    like8.IsEnabled = true;
                }

            }
        }
        private void d9_Clicked(object sender, EventArgs e)
        {
            if (deslike9.IsEnabled)
            {
                i9 = 0;
                if (i9 == 0)
                {
                    d9 = 0;
                    deslike9.IsEnabled = false;
                    like9.IsEnabled = true;
                }

            }
        }
        private void d10_Clicked(object sender, EventArgs e)
        {
            if (deslike10.IsEnabled)
            {
                i10 = 0;
                if (i10 == 0)
                {
                    d10 = 0;
                    deslike10.IsEnabled = false;
                    like10.IsEnabled = true;
                }

            }
        }



        public void Conteo()
        {
            if (d1 == 1)
            {
                DisplayAlert("", "imagen1 me gusta", "ok");
            }
            if (i1 == 0)
            {
                DisplayAlert("", "imagen1 me gusta", "ok");
            }
            if (d2 == 1)
            {
                DisplayAlert("", "imagen2 no me gusta", "ok");
            }
            if (i2 == 0)
            {
                DisplayAlert("", "imagen2 no me gusta", "ok");
            }
            if (i3 == 0)
            {
                DisplayAlert("", "imagen3 me gusta", "ok");
            }
            if (d3 == 1)
            {
                DisplayAlert("", "imagen3 no me gusta", "ok");
            }
            if (i4 == 0)
            {
                DisplayAlert("", "imagen4 me gusta", "ok");
            }
            if (d4 == 1)
            {
                DisplayAlert("", "imagen4 no me gusta", "ok");
            }
            if (i5 == 0)
            {
                DisplayAlert("", "imagen5 me gusta", "ok");
            }
            if (d5 == 1)
            {
                DisplayAlert("", "imagen5 no me gusta", "ok");
            }
            if (i6 == 0)
            {
                DisplayAlert("", "imagen6 me gusta", "ok");
            }
            if (d6 == 1)
            {
                DisplayAlert("", "imagen6 no me gusta", "ok");
            }
            if (i7 ==0)
            {
                DisplayAlert("", "imagen7 me gusta", "ok");
            }
            if (d7 == 1)
            {
                DisplayAlert("", "imagen7 no me gusta", "ok");
            }
            if (i8 == 0)
            {
                DisplayAlert("", "imagen8 me gusta", "ok");
            }
            if (d8 == 1)
            {
                DisplayAlert("", "imagen8 no me gusta", "ok");
            }
            if (i9 == 0)
            {
                DisplayAlert("", "imagen9 me gusta", "ok");
            }
            if (d9 == 1)
            {
                DisplayAlert("", "imagen9 no me gusta", "ok");
            }
            if (i10 == 0)
            {
                DisplayAlert("", "imagen10 me gusta", "ok");
            }
            if (d10 == 1)
            {
                DisplayAlert("", "imagen10 no me gusta", "ok");
            }
        }
        private void Conteo_Clicked(object sender, EventArgs e)
        {
            Conteo();
        }


    }
}
