using UIKit;
using Xamarin.Forms;
using XamFCMDemo.iOS.Services;
using XamFCMDemo.Services;

[assembly:Dependency(typeof(iOSFirebaseMessanging))]
namespace XamFCMDemo.iOS.Services
{
    public class iOSFirebaseMessanging : IFirebaseMessanging
    {
        public void ShowToast()
        {
            var alertController = UIAlertController.Create("InstanceId", "This is place for value of token", UIAlertControllerStyle.Alert);
            ((AppDelegate)UIApplication.SharedApplication.Delegate)
                .Window.RootViewController.PresentViewController(alertController, true, null);
        }
    }
}