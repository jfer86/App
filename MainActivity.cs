using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using Android.Content;
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
            // Encuentro el botón por su ID
            Button loginButton = FindViewById<Button>(Resource.Id.login_button);
            // Agrego el código de verificación de credenciales
            loginButton.Click += delegate
            {
                EditText emailEditText = FindViewById<EditText>(Resource.Id.email);
                EditText passwordEditText = FindViewById<EditText>(Resource.Id.password);
                string email = emailEditText.Text;
                string password = passwordEditText.Text;
                if (email == "admin" && password == "admin")
                {
                    Intent intent = new Intent(this, typeof(WelcomeActivity));
                    StartActivity(intent);
                }
                else
                {
                    Toast.MakeText(this, "Invalid credentials", ToastLength.Short).Show();
                }
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}