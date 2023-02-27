using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace App.Resources.Activities
{
    [Activity(Label = "WelcomeActivity")]
    public class WelcomeActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Cargar el layout de la actividad
            SetContentView(Resource.Layout.welcome);

         

            
        }
    }
}
