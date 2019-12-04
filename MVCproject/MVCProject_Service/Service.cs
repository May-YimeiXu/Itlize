using MVCProject_Repository;
using MVCProject_DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace MVCProject_Service
{
    public class Service
    {
        static string val = "metadata = res://*/ItlizeMVCProject.csdl|res://*/ItlizeMVCProject.ssdl|res://*/ItlizeMVCProject.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=LENOVO-PC\\SQLEXPRESS;initial catalog=ItlizeMVCProject;integrated security=True;multipleactiveresultsets=True;application name=EntityFramework&quot";
        static DbContext context = new DbContext(val);
        ApplicationContext now = new ApplicationContext(context);

        public bool Userlogin(string email,string password) 
        {
            List<Login> lst = now.logins.GetAll().ToList();
            bool var = new bool();
            foreach (var item in lst) 
            {
                if ( item.Email == email && item.Password == password)
                { 
                     var = true;
                }
                else 
                {
                    var = false;
                }
            }
            return var;
        }
    }
}