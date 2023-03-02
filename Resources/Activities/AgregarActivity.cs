using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
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
            Button consultarButton = FindViewById<Button>(Resource.Id.btnAgregar);
            consultarButton.Click += (sender, e) =>
            {
                Toast.MakeText(this, "Producto registrado!", ToastLength.Short).Show();
            };
        }
    }
}