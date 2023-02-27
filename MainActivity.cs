using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using App.Resources.Activities;

namespace App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            // Encuentro el botón por su ID y agrego el código para verificar credenciales
            Button loginButton = FindViewById<Button>(Resource.Id.login_button);
            loginButton.Click += delegate
            {
                EditText emailEditText = FindViewById<EditText>(Resource.Id.email);
                EditText passwordEditText = FindViewById<EditText>(Resource.Id.password);
                string email = emailEditText.Text;
                string password = passwordEditText.Text;
                if (email == "admin" && password == "admin")
                {
                    // Configurar la página de bienvenida
                    SetupWelcomePage();
                }
                else
                {
                    Toast.MakeText(this, "Invalid credentials", ToastLength.Short).Show();
                }
            };
        }

        private void SetupWelcomePage()
        {
            // Establecer el contenido de la vista para la página de bienvenida
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
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
