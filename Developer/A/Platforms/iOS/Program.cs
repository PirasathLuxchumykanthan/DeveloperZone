﻿using ObjCRuntime;
using Security;
using UIKit;

namespace A
{
    public class Program
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            SecKeyChain.Add(new SecRecord { Service= "social.object.app.microsoft.maui.essentials.preference" });
            UIApplication.Main(args, null, typeof(AppDelegate));
        }
    }
}