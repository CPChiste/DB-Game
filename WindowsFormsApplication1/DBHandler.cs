using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

   public  class DBHandler
    {
       public static string SrvName = @"NIRAJ";//server name
       public static string DbName = @"Back_Images";//database name
       public static string Usrname = "niraj\niraj.deval";

       public static string GetConnectionString()
       {
           return "Data Source" + SrvName + "; initial catalog=" + DbName + "; user id=" + Usrname; 

       }
    }

