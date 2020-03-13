using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDemoDB7.Interfaces.SQLite;
using AppDemoDB7.UWP.SQLite;
using System.IO;
using Windows.Storage;
using Xamarin.Forms;
using AppDemoDB7;
using AppDemo;

[assembly: Dependency(typeof(FicDataBasePathSQLiteUWP))]
namespace AppDemoDB7.UWP.SQLite
{
    class FicDataBasePathSQLiteUWP : IFicDataBasePathSQLite
    {
        public string FicGetDataBasePath()
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, FicAppSettings.FicDataBaseName);
        }
    }
}
