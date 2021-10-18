using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace CapaLogica
{
    public class ConexionBD
    {

        public static MySqlConnection conectar = new MySqlConnection("server = 127.0.0.2; port = 3306; database = bdsistema; Uid = root; pwd = MalvinyBolso;");
        

        public static bool Conexion()
        {
            
            try
            {
                MySqlConnection conectar = new MySqlConnection("server = 127.0.0.2; port = 3306; database = bdsistema; Uid = root; pwd = MalvinyBolso;");
                conectar.Open();
                return true;
                
            }
            catch (MySqlException ex)
            {
                return false;
            }

            
            
        }

        public static bool CerrarConexion()
        {

            try
            {
                MySqlConnection conectar = new MySqlConnection("server = 127.0.0.2; port = 3306; database = bdsistema; Uid = root; pwd = MalvinyBolso;");
                conectar.Close();
                return true;

            }
            catch (MySqlException ex)
            {
                return false;
            }



        }
    }
}
