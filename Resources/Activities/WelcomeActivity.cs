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
            SetContentView(Resource.Layout.welcome);

            // Configurar el botón "Consultar" para abrir la actividad "ConsultarActivity"
            Button consultarButton = FindViewById<Button>(Resource.Id.btnConsultar);
            consultarButton.Click += delegate
            {
                Intent intent = new Intent(this, typeof(ConsultarActivity));
                StartActivity(intent);
            };

            // Configurar el botón "Agregar" para abrir la actividad "AgregarActivity"
            Button agregarButton = FindViewById<Button>(Resource.Id.btnAgregar);
            agregarButton.Click += delegate
            {
                Intent intent = new Intent(this, typeof(AgregarActivity));
                StartActivity(intent);
            };

            Button otroButton = FindViewById<Button>(Resource.Id.btnOtro);
            otroButton.Click += delegate
            {
                Intent intent = new Intent(this, typeof(OtroActivity));
                StartActivity(intent);
            };
        }
    }
}