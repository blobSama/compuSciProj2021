using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace compuSciProj2021
{
    public class Connect
    {
        const string FileName = "compuSciProj2021.2.accdb";
        public static string GetConnectionString()
        {
            string location = HttpContext.Current.Server.MapPath("~/App_Data/" + FileName);
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; data source=" + location;
            return ConnectionString;
        }
        public Connect() { }

    }
}