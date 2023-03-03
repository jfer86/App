using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;

namespace App.Resources.Activities
{
    [Activity(Label = "OtroActivity")]
    public class OtroActivity : AppCompatActivity
    {
        private Android.Widget.Toolbar toolbar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.otro);


            // Create your application here
        }
    }

}