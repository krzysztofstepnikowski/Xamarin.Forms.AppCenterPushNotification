using System.Diagnostics;
using Android.Widget;
using Firebase;
using Firebase.Iid;
using XamFCMDemo.Droid.Services;
using XamFCMDemo.Services;

[assembly: Xamarin.Forms.Dependency(typeof(DroidFirebaseMessanging))]
namespace XamFCMDemo.Droid.Services
{
    public class DroidFirebaseMessanging : IFirebaseMessanging
    {
        public void ShowToast()
        {
            var token = FirebaseInstanceId.Instance.Token;
            var context = Android.App.Application.Context;
            Debug.WriteLine($"InstanceId: {token}");
            Toast.MakeText(context,$"InstanceId: {token}",ToastLength.Long).Show();
        }
    }
}