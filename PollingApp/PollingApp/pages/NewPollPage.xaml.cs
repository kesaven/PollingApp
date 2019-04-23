using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PollingApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewPollPage : ContentPage
    {
        public NewPollPage()
        {
            InitializeComponent();
        }

        private void SavePoll(object sender, EventArgs e)
        {
            
        }
    }
}