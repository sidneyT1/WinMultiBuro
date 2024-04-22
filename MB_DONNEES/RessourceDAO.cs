using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MB_METIER;
using MySql.Data.MySqlClient;

namespace MB_DONNEES
{
   public static class RessourceDAO
    {
        public static void InsertRessource(Ressource R)
        {
            try
            {
                MySqlConnection connexion = Connexion.Connect();
                connexion.Open();
                MySqlCommand cmdInsert = new MySqlCommand();
                cmdInsert.Connection = connexion;
                cmdInsert.CommandText = "INSERT INTO ressource(id_ress, lib_ress, code_type, capacite_ress, tarif_ress)"
                + "VALUES (@id_ress, @lib_ress, @code_type, @capacite_ress, @tarif_ress)";

                cmdInsert.Parameters.AddWithValue("@id_ress", R.GetNumero());
                cmdInsert.Parameters.AddWithValue("@lib_ress", R.GetLibelle());
                cmdInsert.Parameters.AddWithValue("@code_type", R.GetUnType());
                cmdInsert.Parameters.AddWithValue("@capacite_ress", R.GetCapacite());
                cmdInsert.Parameters.AddWithValue("@tarif_ress", R.GetTarif());
                

                int res = cmdInsert.ExecuteNonQuery();
                connexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur lors de l'insertion" + e.Message);
            }
        }
    }
}
