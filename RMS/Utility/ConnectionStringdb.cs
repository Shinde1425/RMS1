using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using RMS.Models;

namespace RMS.Utility
{

    public static class ConnectionStringdb
    {
      
        private static string cName = "Data Source=10.103.3.70;  Initial Catalog=RMS;User ID=sa;Password=password@1;Integrated Security=True";
        //SqlConnection cName = new SqlConnection("Data Source=10.103.3.70;Initial Catalog=RMS; User ID=sa;Password=password@1; Integrated Security=True");
        public static string CName { get => cName; }
    }
}

