using Android.App;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamFCMDemo.Views;

namespace XamFCMDemo.Droid
{
    [Activity(Label = "WelcomeActivity", Icon = "@mipmap/icon", Theme = "@style/MainTheme")]
    public class WelcomeActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            Forms.Init(this, savedInstanceState);
            LoadApplication(new App
            {
                MainPage = new WelcomePage()
            });
        }
    }
}