using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace prac_imagenes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class carousel : CarouselPage
    {
        public carousel()
        {
            InitializeComponent();
        }
    }
}