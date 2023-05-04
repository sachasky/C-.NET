using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Proje;

namespace DataAccess
{
    class ConnectionSql
    {
        LoginFrm Logn;

        string ConnectionString = "server=127.0.0.1;user id=root;password=wood11;database=loginspa;";

        MySqlConnection conn = new MySqlConnection();

      /*  MySqlCommand scd = new MySqlCommand("SELECT * FROM loginspa.spalogin WHERE cedula = '" + txtUser.Text + "' and password ='" + txtPass.Text + "'", conn);
        MySqlDataReader myRd;
        con.Open();
        myRd = scd.ExecuteReader();

            try  
            {  
                SqlDataReader rd = cmd.ExecuteReader();
        dt.Load(rd);  
                return dt;  
            }  
            catch (Exception e)
            {  
                throw;  
            } */


    }
}
