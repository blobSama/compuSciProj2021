using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace compuSciProj2020
{
    public class Connect
    {
        const string FileName = "compuProj2020.1.accdb";
        public static string GetConnectionString()
        {
            string location = HttpContext.Current.Server.MapPath("~/App_Data/" + FileName);
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; data source=" + location;
            return ConnectionString;
        }
        public Connect() { }

    }
}