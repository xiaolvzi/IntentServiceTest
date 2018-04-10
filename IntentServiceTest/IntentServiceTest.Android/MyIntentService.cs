using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace IntentServiceTest.Droid
{   [Service]
   public class MyIntentService : IntentService
    {
        // this method will run in work thread not UI thread
        protected override void OnHandleIntent(Intent intent)
        {
            //do something that spends much time
            Log.Error("lv","1111111111111111");
        }
    }
}