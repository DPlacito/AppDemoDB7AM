using System;
using System.Collections.Generic;
using System.Text;
using AppDemoDB7.Model;

namespace AppDemo
{
    public class FicAppSettings
    {
        public static string FicDataBaseName = "DB_COCACOLA_NAY.db3";
        public static cat_usuarios FicUserConnect { get; set; }
        public static rh_cat_personas FicUserPersona { get; set; }
        public static List<seg_roles_usuarios> FicUserRoles { get; set; }
        public static string FicUrlBase { get => "http://localhost:60304/"; set { } }
    }
}