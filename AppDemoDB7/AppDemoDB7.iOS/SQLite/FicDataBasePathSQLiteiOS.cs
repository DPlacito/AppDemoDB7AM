using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Foundation;
using UIKit;
using Xamarin.Forms;
using AppDemoDB7.iOS.SQLite;
using AppDemo;

[assembly: Dependency(typeof(FicDataBasePathSQLiteiOS))]
namespace AppDemoDB7.iOS.SQLite
{
    public class FicDataBasePathSQLiteiOS : IFicDataBasePathSQLite
    {
        public string FicGetDataBasePath()
        {
            string libFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "..", "Library", "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, FicAppSettings.FicDataBaseName);
        }
    }
}