using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MB_METIER;

namespace MB_DONNEES
{
    public class Connexion

    {
        public static MySqlConnection Connect()
        {
            MySqlConnection connex = null;
            string chaineConnex = "server=localhost; user id=root; password= ; database=multiburo;";
            try
            {
                connex = new MySqlConnection(chaineConnex);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de la connexion à la base de données." + e.Message);
            }
            return connex;
        }

        



    }
}
