using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using AppDemoDB7;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppDemoDB7.Interfaces.SQLite;


namespace AppDemoDB7.Droid.SQLite
{
    public class FicDataBasePathSQLiteAndroid : IFicDataBasePathSQLite
    {
        public string FicGetDataBasePath()
        {

            var FicExternalPath = Android.OS.Environment.ExternalStorageDirectory +
                Java.IO.File.Separator + "CocaColaNay" + Java.IO.File.Separator + "DataBase";

            if (!Directory.Exists(FicExternalPath))
            {
                Directory.CreateDirectory(FicExternalPath);
            }

            FicExternalPath = FicExternalPath + Java.IO.File.Separator + FicAppSettings.FicDataBaseName;
            return FicExternalPath;
        }
    }
}
