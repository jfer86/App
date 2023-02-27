using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;

namespace App.Resources.Activities
{
    [Activity(Label = "ConsultarActivity")]
    public class ConsultarActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.consultar);

            // Create your application here
        }
    }
}