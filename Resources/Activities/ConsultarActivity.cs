using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
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
            Button consultarButton = FindViewById<Button>(Resource.Id.btnConsultar);
            consultarButton.Click += (sender, e) =>
            {
                Toast.MakeText(this, "El ID no existe", ToastLength.Short).Show();
            };
        }

    }
}