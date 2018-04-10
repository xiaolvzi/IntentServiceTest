using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using IntentServiceTest.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(UploadImpl))]
namespace IntentServiceTest.Droid
{
    public class UploadImpl : IUpLoad
    {
        public void upLoad()
        {
            // 2.5 obsolete
            //Xamarin.Forms.Forms.Context.StartService(new Intent(Xamarin.Forms.Forms.Context,typeof(MyIntentService)));

            Application.Context.StartService(new Intent(Application.Context, typeof(MyIntentService)));
        }
    }
}