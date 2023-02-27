using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;

namespace App.Resources.Activities
{
    [Activity(Label = "AgregarActivity")]
    public class AgregarActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.agregar);

            // Create your application here
        }
    }
}