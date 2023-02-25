using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;

namespace App.Resources.Activities
{
    [Activity(Label = "WelcomeActivity")]
    public class WelcomeActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Establecer nuestra vista a partir del recurso de diseño 'welcome'
            SetContentView(Resource.Layout.welcome);

        }
    }
}